using Newtonsoft.Json.Linq;
using System;
namespace Vs.WebVOWL
{
    public class JsonModelParser
    {
        public JsonModelParser(string json)
        {
            Json = json ?? throw new System.ArgumentNullException(nameof(json));
            _root = (JContainer)JToken.Parse(json);
            Model = new Welcome();
        }

        public string Json { get; }
        private JContainer _root { get; }

        public Welcome Model { get; private set; }

        public JToken ResolveRef(string path)
        {
            JToken token = _root;
            foreach (var item in path.Remove(0, 2).Split('/'))
                token = token[item];
            return token;
        }

        private enum OpenApiTypeEnum
        {
            undefined,
            @object,
            @string,
            array,
            integer,
            boolean
        }

        public void ParseHeader()
        {
            var header = new Header();
            header.Title = new Comments();
            header.Title.Undefined = _root["info"]["title"].ToString();
            header.Description = new Comments();
            header.Description.Undefined = _root["info"]["description"].ToString();
            header.BaseIris = new System.Collections.Generic.List<Uri>();
            header.BaseIris.Add(new Uri("http://www.w3.org/2000/01/rdf-schema"));
            header.Iri =new Uri(_root["info"]["contact"]["url"].ToString());
            Model.Header = header;
        }

        private void ParseSchema(JContainer container)
        {
            if (container["type"] == null)
            {
                if (container["allOf"] != null)
                {
                    return;
                }
            }
            if (container["type"].ToString() != "object")
                throw new Exception($"Expected container of type object instead got {container["type"].ToString()}");
            foreach (JProperty property in container["properties"])
            {
                OpenApiTypeEnum result = OpenApiTypeEnum.undefined;
                if (property.Value["type"] == null)
                {
                    if (((JProperty)property.Value.First).Name == "$ref")
                    {
                        var tokn = ResolveRef(((JProperty)property.Value.First).Value.ToString());
                        if (tokn["type"] == null)
                            continue;
                        Enum.TryParse<OpenApiTypeEnum>(tokn["type"].ToString(), out result);
                        if (result == OpenApiTypeEnum.undefined)
                            throw new Exception($"Can't parse {property.Value["type"].ToString()} to OpenApiTypeEnum.");
                        switch (result)
                        {
                            case OpenApiTypeEnum.@object:
                                ParseSchema((JContainer)tokn);
                                continue;
                            case OpenApiTypeEnum.@string:
                                continue;
                            default:
                                throw new Exception("Token type not supported");
                        }
                    }
                    else if(((JProperty)property.Value.First).Name == "allOf")
                    {
                        continue;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                Enum.TryParse<OpenApiTypeEnum>(property.Value["type"].ToString(), out result);
                if (result == OpenApiTypeEnum.undefined)
                    throw new Exception($"Can't parse {property.Value["type"].ToString()} to OpenApiTypeEnum.");
                switch (result)
                {
                    case OpenApiTypeEnum.@string:
                        break;
                    case OpenApiTypeEnum.array:
                        break;
                    case OpenApiTypeEnum.integer:
                        break;
                    case OpenApiTypeEnum.boolean:
                        break;
                    default:
                        throw new Exception("Token type not supported");
                }
                if (property.Name.ToLower() == "$ref")
                {

                }
            }
        }

 
        public void ParseSchemas()
        {
            foreach (JContainer schema in _root["components"]["schemas"])
            {
                try {
                    ParseSchema((JContainer)schema.First);
                }
                catch (Exception ex)
                {

                }
            }
        }
}
}

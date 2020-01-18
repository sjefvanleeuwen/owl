using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Welcome
    {
        [JsonProperty("_comment")]
        public string Comment { get; set; }

        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("namespace")]
        public List<object> Namespace { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("class")]
        public List<Class> Class { get; set; }

        [JsonProperty("classAttribute")]
        public List<ClassAttribute> ClassAttribute { get; set; }

        [JsonProperty("property")]
        public List<Class> Property { get; set; }

        [JsonProperty("propertyAttribute")]
        public List<PropertyAttribute> PropertyAttribute { get; set; }

        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, Converter.Settings);
    }
}
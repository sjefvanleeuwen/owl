using System;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    internal class PropertyAttributeLabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PropertyAttributeLabel) || t == typeof(PropertyAttributeLabel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new PropertyAttributeLabel { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<FluffyLabel>(reader);
                    return new PropertyAttributeLabel { FluffyLabel = objectValue };
            }
            throw new Exception("Cannot unmarshal type PropertyAttributeLabel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (PropertyAttributeLabel)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.FluffyLabel != null)
            {
                serializer.Serialize(writer, value.FluffyLabel);
                return;
            }
            throw new Exception("Cannot marshal type PropertyAttributeLabel");
        }

        public static readonly PropertyAttributeLabelConverter Singleton = new PropertyAttributeLabelConverter();
    }
}
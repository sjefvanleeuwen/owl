using System;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    internal class ClassAttributeLabelConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClassAttributeLabel) || t == typeof(ClassAttributeLabel?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new ClassAttributeLabel { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<PurpleLabel>(reader);
                    return new ClassAttributeLabel { PurpleLabel = objectValue };
            }
            throw new Exception("Cannot unmarshal type ClassAttributeLabel");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ClassAttributeLabel)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.PurpleLabel != null)
            {
                serializer.Serialize(writer, value.PurpleLabel);
                return;
            }
            throw new Exception("Cannot marshal type ClassAttributeLabel");
        }

        public static readonly ClassAttributeLabelConverter Singleton = new ClassAttributeLabelConverter();
    }
}
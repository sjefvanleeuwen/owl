using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Vs.WebVOWL
{
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ClassAttributeLabelConverter.Singleton,
                LanguageConverter.Singleton,
                TypeEnumConverter.Singleton,
                PropertyAttributeLabelConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
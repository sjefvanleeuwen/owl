using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class BackwardCompatibleWith
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("language")]
        public Language Language { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }
    }
}
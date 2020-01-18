using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class PurpleDescription
    {
        [JsonProperty("de", NullValueHandling = NullValueHandling.Ignore)]
        public string De { get; set; }

        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public string En { get; set; }

        [JsonProperty("es", NullValueHandling = NullValueHandling.Ignore)]
        public string Es { get; set; }
    }
}
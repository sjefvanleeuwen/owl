using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class PurpleLabel
    {
        [JsonProperty("IRI-based", NullValueHandling = NullValueHandling.Ignore)]
        public string IriBased { get; set; }

        [JsonProperty("undefined", NullValueHandling = NullValueHandling.Ignore)]
        public string Undefined { get; set; }

        [JsonProperty("de", NullValueHandling = NullValueHandling.Ignore)]
        public string De { get; set; }

        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public string En { get; set; }
    }
}
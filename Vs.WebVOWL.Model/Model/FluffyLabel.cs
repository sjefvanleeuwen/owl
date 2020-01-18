using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class FluffyLabel
    {
        [JsonProperty("IRI-based")]
        public string IriBased { get; set; }

        [JsonProperty("zh-hans", NullValueHandling = NullValueHandling.Ignore)]
        public string ZhHans { get; set; }

        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public string En { get; set; }

        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public string Fr { get; set; }

        [JsonProperty("undefined", NullValueHandling = NullValueHandling.Ignore)]
        public string Undefined { get; set; }
    }
}
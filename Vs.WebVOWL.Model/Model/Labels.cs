using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Labels
    {
        [JsonProperty("IRI-based")]
        public string IriBased { get; set; }
    }
}
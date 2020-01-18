using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class CheckBox
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("checked")]
        public bool Checked { get; set; }
    }
}
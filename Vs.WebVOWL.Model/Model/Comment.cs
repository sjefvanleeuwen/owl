using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Comment
    {
        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public string En { get; set; }

        [JsonProperty("undefined", NullValueHandling = NullValueHandling.Ignore)]
        public string Undefined { get; set; }
    }
}
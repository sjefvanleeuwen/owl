using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class CommentClass
    {
        [JsonProperty("en")]
        public string En { get; set; }
    }
}
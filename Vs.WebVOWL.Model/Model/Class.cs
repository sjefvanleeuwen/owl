using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public  class Class
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
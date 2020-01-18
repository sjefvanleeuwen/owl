using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Gravity
    {
        [JsonProperty("classDistance")]
        public long ClassDistance { get; set; }

        [JsonProperty("datatypeDistance")]
        public long DatatypeDistance { get; set; }
    }
}
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Other
    {
        [JsonProperty("date")]
        public List<BackwardCompatibleWith> Date { get; set; }

        [JsonProperty("priorVersion")]
        public List<BackwardCompatibleWith> PriorVersion { get; set; }

        [JsonProperty("creator")]
        public List<BackwardCompatibleWith> Creator { get; set; }

        [JsonProperty("contributor")]
        public List<BackwardCompatibleWith> Contributor { get; set; }

        [JsonProperty("incompatibleWith")]
        public List<BackwardCompatibleWith> IncompatibleWith { get; set; }

        [JsonProperty("rights")]
        public List<BackwardCompatibleWith> Rights { get; set; }

        [JsonProperty("versionInfo")]
        public List<BackwardCompatibleWith> VersionInfo { get; set; }

        [JsonProperty("title")]
        public List<BackwardCompatibleWith> Title { get; set; }

        [JsonProperty("backwardCompatibleWith")]
        public List<BackwardCompatibleWith> BackwardCompatibleWith { get; set; }
    }
}
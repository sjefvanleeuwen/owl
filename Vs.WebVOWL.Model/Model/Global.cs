using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Global
    {
        [JsonProperty("zoom")]
        public string Zoom { get; set; }

        [JsonProperty("translation")]
        public List<double> Translation { get; set; }

        [JsonProperty("paused")]
        public bool Paused { get; set; }
    }
}
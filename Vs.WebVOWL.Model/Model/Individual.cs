using System;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Individual
    {
        [JsonProperty("iri")]
        public Uri Iri { get; set; }

        [JsonProperty("labels")]
        public Labels Labels { get; set; }
    }
}
using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Header
    {
        [JsonProperty("languages")]
        public List<string> Languages { get; set; }

        [JsonProperty("baseIris")]
        public List<Uri> BaseIris { get; set; }

        [JsonProperty("prefixList")]
        public PrefixList PrefixList { get; set; }

        [JsonProperty("title")]
        public Comments Title { get; set; }

        [JsonProperty("iri")]
        public Uri Iri { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("author")]
        public List<string> Author { get; set; }

        [JsonProperty("description")]
        public Comments Description { get; set; }

        [JsonProperty("labels")]
        public Comments Labels { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("other")]
        public Other Other { get; set; }
    }
}
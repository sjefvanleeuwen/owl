using System;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class PrefixList
    {
        [JsonProperty("owl")]
        public Uri Owl { get; set; }

        [JsonProperty("rdf")]
        public Uri Rdf { get; set; }

        [JsonProperty("other")]
        public Uri Other { get; set; }

        [JsonProperty("xsd")]
        public Uri Xsd { get; set; }

        [JsonProperty("")]
        public Uri Empty { get; set; }

        [JsonProperty("dc")]
        public Uri Dc { get; set; }

        [JsonProperty("xml")]
        public Uri Xml { get; set; }

        [JsonProperty("rdfs")]
        public Uri Rdfs { get; set; }

        [JsonProperty("this")]
        public Uri This { get; set; }
    }
}
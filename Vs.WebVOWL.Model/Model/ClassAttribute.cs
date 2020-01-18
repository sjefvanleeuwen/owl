using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class ClassAttribute
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iri", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Iri { get; set; }

        [JsonProperty("baseIri", NullValueHandling = NullValueHandling.Ignore)]
        public Uri BaseIri { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public ClassAttributeLabel? Label { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Attributes { get; set; }

        [JsonProperty("pos", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Pos { get; set; }

        [JsonProperty("equivalent", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Equivalent { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public Comment Comment { get; set; }

        [JsonProperty("individuals", NullValueHandling = NullValueHandling.Ignore)]
        public List<Individual> Individuals { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public CommentClass Description { get; set; }
    }
}
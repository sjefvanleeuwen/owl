using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class PropertyAttribute
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("iri", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Iri { get; set; }

        [JsonProperty("baseIri", NullValueHandling = NullValueHandling.Ignore)]
        public Uri BaseIri { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public PropertyAttributeLabel? Label { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Attributes { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }

        [JsonProperty("pos", NullValueHandling = NullValueHandling.Ignore)]
        public List<double> Pos { get; set; }

        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public CommentClass Comment { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleDescription Description { get; set; }

        [JsonProperty("maxCardinality", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MaxCardinality { get; set; }

        [JsonProperty("minCardinality", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? MinCardinality { get; set; }

        [JsonProperty("inverse", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Inverse { get; set; }

        [JsonProperty("cardinality", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringConverter))]
        public long? Cardinality { get; set; }

        [JsonProperty("subproperty", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Subproperty { get; set; }

        [JsonProperty("superproperty", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> Superproperty { get; set; }
    }
}
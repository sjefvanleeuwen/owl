using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Filter
    {
        [JsonProperty("checkBox")]
        public List<CheckBox> CheckBox { get; set; }

        [JsonProperty("degreeSliderValue")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long DegreeSliderValue { get; set; }
    }
}
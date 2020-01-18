using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public partial class Modes
    {
        [JsonProperty("checkBox")]
        public List<CheckBox> CheckBox { get; set; }

        [JsonProperty("colorSwitchState")]
        public bool ColorSwitchState { get; set; }
    }
}
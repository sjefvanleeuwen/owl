using Newtonsoft.Json;

namespace Vs.WebVOWL
{
    public static class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
using System.IO;

namespace Vs.WebVOWL.Tests.Data
{
    public static class YAMLOpenAPIBewoning
    {
        public static string Json = File.ReadAllText(@"./Data/openapi-bewoning.json");
    }
}

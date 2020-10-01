using Newtonsoft.Json;

namespace WarframeSharp
{
    public class OrbVallis
    {
        [JsonProperty("id")]
        public string Id { get; internal set; }

        [JsonProperty("expiry")]
        public string Expiry { get; internal set; }

        [JsonProperty("timeLeft")]
        public string TimeLeft { get; internal set; }

        [JsonProperty("isWarm")]
        public bool IsWarm { get; internal set; }
    }
}
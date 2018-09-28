using Newtonsoft.Json;

namespace WarframeSharp
{
    public struct Mission
    {
        [JsonProperty("node")]
        public string Node { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("faction")]
        public string Faction { get; private set; }

        [JsonProperty("reward")]
        public Reward Reward { get; private set; }
    }
}

using Newtonsoft.Json;

namespace WarframeSharp
{
    public struct Fissure
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("node")]
        public string Node { get; private set; }

        [JsonProperty("missionType")]
        public string MissionType { get; private set; }

        [JsonProperty("enemy")]
        public string Enemy { get; private set; }

        [JsonProperty("tier")]
        public string Tier { get; private set; }

        [JsonProperty("tierNum")]
        public int TierNumber { get; private set; }

        [JsonProperty("activation")]
        public string Activation { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("eta")]
        public string Eta { get; private set; }
    }
}

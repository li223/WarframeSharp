using Newtonsoft.Json;

namespace WarframeSharp
{
    public struct ConclaveChallenge
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("amount")]
        public int Amount { get; private set; }

        [JsonProperty("mode")]
        public string Mode { get; private set; }

        [JsonProperty("category")]
        public string Category { get; private set; }

        [JsonProperty("eta")]
        public string Eta { get; private set; }

        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        [JsonProperty("daily")]
        public bool IsDaily { get; private set; }

        [JsonProperty("rootChallenge")]
        public bool IsRootChallenge { get; private set; }

        [JsonProperty("endString")]
        public string EndString { get; private set; }

        [JsonProperty("asString")]
        public string AsString { get; private set; }
    }
}

using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Conclave Challenge Struct
    /// </summary>
    public struct ConclaveChallenge
    {
        /// <summary>
        /// Challenge Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Challenge Description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Challenge Expiration Timestamp
        /// </summary>
        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        /// <summary>
        /// Number of times the challenge needs to be done before completion
        /// </summary>
        [JsonProperty("amount")]
        public int Amount { get; private set; }

        /// <summary>
        /// Gamemode required for the challenge
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; private set; }

        /// <summary>
        /// Challenge Category
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; private set; }

        /// <summary>
        /// Time until it expires
        /// </summary>
        [JsonProperty("eta")]
        public string Eta { get; private set; }

        /// <summary>
        /// If the challenge has expired or not
        /// </summary>
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        /// <summary>
        /// If the challenge is a daily challenge
        /// </summary>
        [JsonProperty("daily")]
        public bool IsDaily { get; private set; }

        /// <summary>
        /// If the challenge is a root challenge
        /// </summary>
        [JsonProperty("rootChallenge")]
        public bool IsRootChallenge { get; private set; }

        /// <summary>
        /// Time until the challenge ends in string format (seems to be the same as eta)
        /// </summary>
        [JsonProperty("endString")]
        public string EndString { get; private set; }

        /// <summary>
        /// Full Challenge Description
        /// </summary>
        [JsonProperty("asString")]
        public string AsString { get; private set; }
    }
}

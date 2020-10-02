using System.Collections.Generic;
using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Syndicate Mission Struct
    /// </summary>
    public struct SyndicateMission
    {
        /// <summary>
        /// Syndicate Mission Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Syndicate Mission Activation date
        /// </summary>
        [JsonProperty("activation")]
        public string Activation { get; private set; }

        /// <summary>
        /// Syndicate Mission Expiration timestamp
        /// </summary>
        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        /// <summary>
        /// Syndicate the Mission is for
        /// </summary>
        [JsonProperty("syndicate")]
        public string Syndicate { get; private set; }

        /// <summary>
        /// Syndicate Mission locations
        /// </summary>
        [JsonProperty("nodes")]
        public IEnumerable<string> Nodes { get; private set; }

        /// <summary>
        /// Syndicate Mission types
        /// </summary>
        [JsonProperty("jobs")]
        public IEnumerable<Job> Jobs { get; private set; }

        /// <summary>
        /// Time until expiration
        /// </summary>
        [JsonProperty("eta")]
        public string Eta { get; private set; }
    }
}

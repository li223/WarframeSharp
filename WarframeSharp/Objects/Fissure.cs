using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Fissure Struct
    /// </summary>
    public class Fissure
    {
        /// <summary>
        /// Fissure Id
        /// </summary>
        [JsonProperty("id")]
        public string? Id { get; private set; }

        /// <summary>
        /// The node and planet the fissure is on
        /// </summary>
        [JsonProperty("node")]
        public string? Node { get; private set; }

        /// <summary>
        /// The mission type
        /// </summary>
        [JsonProperty("missionType")]
        public string? MissionType { get; private set; }

        /// <summary>
        /// The type of enemy present 
        /// </summary>
        [JsonProperty("enemy")]
        public string? Enemy { get; private set; }

        /// <summary>
        /// Fissure tier
        /// </summary>
        [JsonProperty("tier")]
        public string? Tier { get; private set; }

        /// <summary>
        /// Fissure tier expressed as a number
        /// </summary>
        [JsonProperty("tierNum")]
        public int TierNumber { get; private set; }

        /// <summary>
        /// Timestamp of fissure activation
        /// </summary>
        [JsonProperty("activation")]
        public string? Activation { get; private set; }

        /// <summary>
        /// Timestamp of fissure expiration
        /// </summary>
        [JsonProperty("expiry")]
        public string? Expiry { get; private set; }

        /// <summary>
        /// If the fissure has expired
        /// </summary>
        [JsonProperty("expired")]
        public bool HasExpired { get; private set; }

        /// <summary>
        /// Time left before it expires
        /// </summary>
        [JsonProperty("eta")]
        public string? Eta { get; private set; }
    }
}

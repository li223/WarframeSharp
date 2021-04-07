using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Mission Struct
    /// </summary>
    public class Mission
    {
        /// <summary>
        /// Node or planet the mission is on
        /// </summary>
        [JsonProperty("node")]
        public string Node { get; private set; }

        /// <summary>
        /// The mission type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The mission faction
        /// </summary>
        [JsonProperty("faction")]
        public string Faction { get; private set; }

        /// <summary>
        /// Mission reward
        /// </summary>
        [JsonProperty("reward")]
        public Reward Reward { get; private set; }

        /// <summary>
        /// Min level of the enemies
        /// </summary>
        [JsonProperty("minEnemyLevel")]
        public int MinEnemyLevel { get; private set; }

        /// <summary>
        /// Max level of the enemies
        /// </summary>
        [JsonProperty("maxEnemyLevel")]
        public int MaxEnemyLevel { get; private set; }

        /// <summary>
        /// Is nightmare mode
        /// </summary>
        [JsonProperty("nightmare")]
        public bool IsNightmare { get; private set; }


        /// <summary>
        /// Is an archwing mission
        /// </summary>
        [JsonProperty("archwingRequired")]
        public bool IsArchwingRequired { get; private set; }
    }
}

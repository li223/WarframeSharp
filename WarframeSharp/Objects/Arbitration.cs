using System;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class Arbitration
    {
        /// <summary>
        /// When the Arbitration becomes active
        /// </summary>
        [JsonProperty("activation")]
        public DateTime Activation { get; private set; }

        /// <summary>
        /// When the Arbitration becomes inactive
        /// </summary>

        [JsonProperty("expiry")]
        public DateTime Expiry { get; private set; }

        /// <summary>
        /// A Faction in Warframe
        /// </summary>

        [JsonProperty("enemy")]
        public EnemyType Enemy { get; private set; }

        /// <summary>
        /// Mission type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Whether or not this mission requires archwing
        /// </summary>
        [JsonProperty("archwing")]
        public bool Archwing { get; private set; }

        /// <summary>
        /// Whether or not this mission requires sharkwing
        /// </summary>
        [JsonProperty("sharkwing")]
        public bool Sharkwing { get; private set; }

        /// <summary>
        /// Plain name for the node
        /// </summary>
        [JsonProperty("node")]
        public string Node { get; private set; }
    }
}
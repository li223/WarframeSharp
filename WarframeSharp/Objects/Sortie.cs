using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeSharp
{
    /// <summary>
    /// The Sortie Struct
    /// </summary>
    public struct Sortie
    {
        /// <summary>
        /// Sortie Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Timestamp of Sortie Activation
        /// </summary>
        [JsonProperty("activation")]
        public string Activation { get; private set; }

        /// <summary>
        /// Timestamp of Sortie Expiration
        /// </summary>
        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        /// <summary>
        /// The Sortie Rewards Pool
        /// </summary>
        [JsonProperty("rewardPool"), Obsolete("Will just return 'Sortie Rewards', like that's somehow useful")]
        public string RewardPool { get; private set; }

        /// <summary>
        /// List of Sortie Missions
        /// </summary>
        [JsonProperty("variants")]
        public IEnumerable<Variant> Variants { get; private set; }
    }

    /// <summary>
    /// Variant Struct
    /// </summary>
    public struct Variant
    {
        [JsonProperty("boss")]
        public string Boss { get; private set; }

        [JsonProperty("planet"), Obsolete("Will just return 'Deprecated'")]
        public string Planet { get; private set; }

        [JsonProperty("missionType")]
        public string MissionType { get; private set; }

        [JsonProperty("modifier")]
        public string Modifier { get; private set; }

        [JsonProperty("modifierDescription")]
        public string ModifierDescription { get; private set; }

        [JsonProperty("node")]
        public string Node { get; private set; }
    }
}

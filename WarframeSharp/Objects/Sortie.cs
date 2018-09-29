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
        [JsonProperty("rewardPool"), Obsolete(@"Will just return ""Sortie Rewards"", like that's somehow useful")]
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
        /// <summary>
        /// The mission's boss
        /// </summary>
        [JsonProperty("boss")]
        public string Boss { get; private set; }

        /// <summary>
        /// The planet the mission is on
        /// </summary>
        [JsonProperty("planet"), Obsolete(@"Will just return ""Deprecated"", please use the ""Node"" property instead.")]
        public string Planet { get; private set; }

        /// <summary>
        /// The type of mission
        /// </summary>
        [JsonProperty("missionType")]
        public string MissionType { get; private set; }

        /// <summary>
        /// The name of the mission modifier
        /// </summary>
        [JsonProperty("modifier")]
        public string Modifier { get; private set; }

        /// <summary>
        /// The description of the modifier
        /// </summary>
        [JsonProperty("modifierDescription")]
        public string ModifierDescription { get; private set; }

        /// <summary>
        /// The node and planet the mission is on
        /// </summary>
        [JsonProperty("node")]
        public string Node { get; private set; }
    }
}

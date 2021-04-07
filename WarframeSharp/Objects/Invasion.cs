using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeSharp
{
    /// <summary>
    /// Invasion Struct
    /// </summary>
    public class Invasion
    {
        /// <summary>
        /// Invasion Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The node and planet the invasion is on
        /// </summary>
        [JsonProperty("node")]
        public string Node { get; private set; }

        /// <summary>
        /// The invasion description
        /// </summary>
        [JsonProperty("desc")]
        public string Description { get; private set; }

        /// <summary>
        /// The reward gained from the attackers
        /// </summary>
        [JsonProperty("attackerReward")]
        public Reward? AttackerReward { get; private set; }

        /// <summary>
        /// The faction that's attacking
        /// </summary>
        [JsonProperty("attackingFaction")]
        public string AttackingFaction { get; private set; }

        /// <summary>
        /// The reward gained from the defenders
        /// </summary>
        [JsonProperty("defenderReward")]
        public Reward? DefenderReward { get; private set; }

        /// <summary>
        /// The faction that's defending
        /// </summary>
        [JsonProperty("defendingFaction")]
        public string DefendingFaction { get; private set; }

        /// <summary>
        /// If the invasion is against the Infestation
        /// </summary>
        [JsonProperty("vsInfestation")]
        public bool IsAgainstInfestation { get; private set; }

        /// <summary>
        /// Timestamp of invasion activations
        /// </summary>
        [JsonProperty("activation")]
        public string Activation { get; private set; }

        /// <summary>
        /// Current number of community wide runs
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; private set; }

        /// <summary>
        /// Number of community wide runs required for invasion completion
        /// </summary>
        [JsonProperty("requiredRuns")]
        public int RequiredRuns { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("completion")]
        public double Completion { get; private set; }

        /// <summary>
        /// If the invasion has been completed or not
        /// </summary>
        [JsonProperty("completed")]
        public bool IsCompleted { get; private set; }

        /// <summary>
        /// Eta until completion
        /// </summary>
        [JsonProperty("eta")]
        public string Eta { get; private set; }

        /// <summary>
        /// The types of rewards on offer
        /// </summary>
        [JsonProperty("rewardTypes")]
        public IEnumerable<string> RewardTypes { get; private set; }
    }
}

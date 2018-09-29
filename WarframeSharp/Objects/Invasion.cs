using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeSharp
{
    public struct Invasion
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("node")]
        public string Node { get; private set; }

        [JsonProperty("desc")]
        public string Description { get; private set; }

        [JsonProperty("attackerReward")]
        public Reward AttackerReward { get; private set; }

        [JsonProperty("attackingFaction")]
        public string AttackingFaction { get; private set; }

        [JsonProperty("defenderReward")]
        public Reward DefenderReward { get; private set; }

        [JsonProperty("defendingFaction")]
        public string DefendingFaction { get; private set; }

        [JsonProperty("vsInfestation")]
        public bool IsAgainstInfestation { get; private set; }

        [JsonProperty("activation")]
        public string Activation { get; private set; }

        [JsonProperty("count")]
        public int Count { get; private set; }

        [JsonProperty("requiredRuns")]
        public int RequiredRuns { get; private set; }

        [JsonProperty("completion")]
        public int Completion { get; private set; }

        [JsonProperty("completed")]
        public bool IsCompleted { get; private set; }

        [JsonProperty("eta")]
        public string Eta { get; private set; }

        [JsonProperty("rewardTypes")]
        public IEnumerable<Reward> RewardTypes { get; private set; }
    }
}

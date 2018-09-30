using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Job Struct
    /// </summary>
    public struct Job
    {
        /// <summary>
        /// Job Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Job Type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Enemy level, min and max
        /// </summary>
        [JsonProperty("enemyLevels")]
        public int[] EnemyLevels { get; private set; }

        /// <summary>
        /// Standing Stages
        /// </summary>
        [JsonProperty("standingStages")]
        public int[] StandingStages { get; private set; }

        /// <summary>
        /// Reward pool
        /// </summary>
        [JsonProperty("rewardPool")]
        public string[] RewardPool { get; private set; }
    }
}

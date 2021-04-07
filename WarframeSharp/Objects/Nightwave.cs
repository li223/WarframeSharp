using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeSharp
{
    /// <summary>
    /// Nightwave Struct
    /// </summary>
    public class Nightwave
    {
        /// <summary>
        /// Nightwave Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Timestamp of Nightwave Activation
        /// </summary>
        [JsonProperty("activation")]
        public string Activation { get; private set; }

        /// <summary>
        /// Timestamp of Nightwave Expiration
        /// </summary>
        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("params")]
        public Dictionary<string, string> Params { get; private set; }

        /// <summary>
        /// Types of rewards
        /// </summary>
        [JsonProperty("rewardTypes")]
        public IEnumerable<string> RewardTypes { get; private set; }

        /// <summary>
        /// Current nightwave season
        /// </summary>
        [JsonProperty("season")]
        public int Season { get; private set; }

        /// <summary>
        /// Name of the Nightwave Syndicate
        /// </summary>
        [JsonProperty("tag")]
        public string Tag { get; private set; }

        /// <summary>
        /// Current nightwave phase
        /// </summary>
        [JsonProperty("phase")]
        public int Phase { get; private set; }

        /// <summary>
        /// All possible challenges
        /// </summary>
        [JsonProperty("possibleChallenges")]
        public IEnumerable<NightwaveChallenge> PossibleChallenges { get; private set; }

        /// <summary>
        /// Current nightwave challenges
        /// </summary>
        [JsonProperty("activeChallenges")]
        public IEnumerable<NightwaveChallenge> ActiveChallenges { get; private set; }
    }

    /// <summary>
    /// Nightwave Challenge Struct
    /// </summary>
    public class NightwaveChallenge
    {
        /// <summary>
        /// Challenge Id
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Challenge Description
        /// </summary>
        [JsonProperty("desc")]
        public string Description { get; private set; }

        /// <summary>
        /// Challenge Expiration Timestamp
        /// </summary>
        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        /// <summary>
        /// Amount of reputation rewarded on completion 
        /// </summary>
        [JsonProperty("reputation")]
        public int Reputation { get; private set; }

        /// <summary>
        /// Challenge title
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; private set; }

        /// <summary>
        /// If the challenge is a daily challenge
        /// </summary>
        [JsonProperty("isDaily")]
        public bool IsDaily { get; private set; }

        /// <summary>
        /// If the challenge is an elite challenge
        /// </summary>
        [JsonProperty("isElite")]
        public bool IsElite { get; private set; }
    }
}
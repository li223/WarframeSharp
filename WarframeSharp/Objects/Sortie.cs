using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WarframeSharp
{
    public struct Sortie
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public string Activation { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("rewardPool")]
        public string RewardPool { get; private set; }

        [JsonProperty("variants")]
        public IEnumerable<Variant> Variants { get; private set; }
    }

    public struct Variant
    {
        [JsonProperty("boss")]
        public string Boss { get; private set; }

        [JsonProperty("planet")]
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

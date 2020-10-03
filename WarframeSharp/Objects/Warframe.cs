using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// Warframe Struct
    /// </summary>
    public struct Warframe
    {
        /// <summary>
        /// Name of the Warframe
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Url for the warframe
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; private set; }

        /// <summary>
        /// Required Mastery Rank to use the frame
        /// </summary>
        [JsonProperty("mr")]
        public string MasteryRank { get; private set; }

        /// <summary>
        /// Frame base health
        /// </summary>
        [JsonProperty("health")]
        public double Health { get; private set; }

        /// <summary>
        /// Frame base shield
        /// </summary>
        [JsonProperty("shield")]
        public double Shield { get; private set; }

        /// <summary>
        /// Frame base armour
        /// </summary>
        [JsonProperty("armor")]
        public double Armour { get; private set; }

        /// <summary>
        /// Frame base power
        /// </summary>
        [JsonProperty("power")]
        public int Power { get; private set; }

        /// <summary>
        /// Frame base speed
        /// </summary>
        [JsonProperty("speed")]
        public double Speed { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("conclave")]
        public string Conclave { get; private set; }

        /// <summary>
        /// Frame polarities
        /// </summary>
        [JsonProperty("polarities")]
        public string[] Polarities { get; private set; }

        /// <summary>
        /// Frame aura
        /// </summary>
        [JsonProperty("aura")]
        public string Aura { get; private set; }

        /// <summary>
        /// Frame description
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; private set; }

        /// <summary>
        /// Frame info
        /// </summary>
        [JsonProperty("info")]
        public string Info { get; private set; }

        /// <summary>
        /// Frame thumbnail
        /// </summary>
        [JsonProperty("thumbnail")]
        public string Thumbnail { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("color")]
        public int Color { get; private set; }

        /// <summary>
        /// Url for prime version of the warframe
        /// </summary>
        [JsonProperty("primeUrl")]
        public string PrimeUrl { get; private set; }

        /// <summary>
        /// MR Requirement for the prime version
        /// </summary>
        [JsonProperty("primeMasteryRank")]
        public int PrimeMasteryRank { get; private set; }

        /// <summary>
        /// Base prime health
        /// </summary>
        [JsonProperty("primeHealth")]
        public string PrimeHealth { get; private set; }

        /// <summary>
        /// Base prime shield
        /// </summary>
        [JsonProperty("primeShield")]
        public string PrimeShield { get; private set; }

        /// <summary>
        /// Base prime armour
        /// </summary>
        [JsonProperty("primeArmor")]
        public string PrimeArmour { get; private set; }

        /// <summary>
        /// Base prime speed
        /// </summary>
        [JsonProperty("primeSpeed")]
        public string PrimeSpeed { get; private set; }

        /// <summary>
        /// Base prime power
        /// </summary>
        [JsonProperty("primePower")]
        public string PrimePower { get; private set; }

        /// <summary>
        /// Unknown
        /// </summary>
        [JsonProperty("primeConclave")]
        public string PrimeConclave { get; private set; }

        /// <summary>
        /// Prime polarities
        /// </summary>
        [JsonProperty("primePolarities")]
        public string[] PrimePolarities { get; private set; }

        /// <summary>
        /// Prime aura
        /// </summary>
        [JsonProperty("primeAura")]
        public string PrimeAura { get; private set; }
    }
}

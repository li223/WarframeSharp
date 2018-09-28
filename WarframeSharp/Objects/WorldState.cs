using Newtonsoft.Json;
using System.Collections.Generic;

namespace WarframeSharp
{
    public struct WorldState
    {
        [JsonProperty("timestamp")]
        public string WorldTimestamp { get; private set; }

        [JsonProperty("news")]
        public IEnumerable<News> News { get; private set; }

        [JsonProperty("events")]
        public IEnumerable<Event> Events { get; private set; }

        [JsonProperty("alerts")]
        public IEnumerable<Alert> Alerts { get; private set; }

        [JsonProperty("sortie")]
        public Sortie Sortie { get; private set; }

        [JsonProperty("syndicateMissions")]
        public IEnumerable<SyndicateMission> SyndicateMissions { get; private set; }

        [JsonProperty("fissures")]
        public IEnumerable<Fissure> Fissure { get; private set; }

        [JsonProperty("globalUpgrades")]
        public IEnumerable<string> GlobalUpgrades { get; private set; }

        [JsonProperty("flashSales")]
        public IEnumerable<FlashSale> FlashSale { get; private set; }

        [JsonProperty("darkSectors")]
        public IEnumerable<DarkSector> DarkSectors { get; private set; }

        [JsonProperty("voidTrader")]
        public VoidTrader VoidTrader { get; private set; }

        [JsonProperty("dailyDeals")]
        public IEnumerable<DailyDeal> DailyDeals { get; private set; }

        [JsonProperty("simaris")]
        public Simaris Simaris { get; private set; }

        [JsonProperty("conclaveChallenges")]
        public IEnumerable<ConclaveChallenge> ConclaveChallenges { get; private set; }

        [JsonProperty("persistentEnemies")]
        public IEnumerable<string> PersistentEnemies { get; private set; }

        [JsonProperty("earthCycle")]
        public Cycle EarthCycle { get; private set; }

        [JsonProperty("cetusCycle")]
        public Cycle CetusCycle { get; private set; }

        [JsonProperty("constructionProgress")]
        public ConstructionProgress ConstructionProgress { get; private set; }
    }
    
    public struct ConstructionProgress
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("fomorianProgress")]
        public string FomorianProgress { get; private set; }

        [JsonProperty("razorbackProgress")]
        public string RazorbackProgress { get; private set; }

        [JsonProperty("unknownProgress")]
        public string UnknownProgress { get; private set; }
    }

    public sealed class Cycle
    {
        [JsonProperty("id")]
        public int Id { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("isDay")]
        public bool IsDay { get; private set; }

        [JsonProperty("timeLeft")]
        public string TimeLeft { get; private set; }

        [JsonProperty("isCetus")]
        public bool IsCetus { get; private set; } = false;
    }

    public struct Simaris
    {
        [JsonProperty("target")]
        public string Target { get; private set; }

        [JsonProperty("isTargetActive")]
        public bool IsTargetActive { get; private set; }

        [JsonProperty("asString")]
        public string AsString { get; private set; }
    }

    public struct DailyDeal
    {
        [JsonProperty("item")]
        public string Item { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("originalPrice")]
        public int OriginalPrice { get; private set; }

        [JsonProperty("salePrice")]
        public int SalePrice { get; private set; }

        [JsonProperty("total")]
        public int Total { get; private set; }

        [JsonProperty("sold")]
        public int Sold { get; private set; }

        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("eta")]
        public string Eta { get; private set; }

        [JsonProperty("discount")]
        public int Discount { get; private set; }
    }

    public struct VoidTrader
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public string Activation { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("character")]
        public string Character { get; private set; }

        [JsonProperty("location")]
        public string Location { get; private set; }

        [JsonProperty("inventory")]
        public IEnumerable<string> Inventory { get; private set; }

        [JsonProperty("psId")]
        public string PsId { get; private set; }

        [JsonProperty("active")]
        public bool IsActive { get; private set; }

        [JsonProperty("startString")]
        public string StartString { get; private set; }

        [JsonProperty("endString")]
        public string EndString { get; private set; }
    }

    public struct DarkSector
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("isAlliance")]
        public bool IsAlliance { get; private set; }

        [JsonProperty("defenderName")]
        public string DefenderName { get; private set; }

        [JsonProperty("defenderDeployemntActivation")]
        public int DefenderDeployemntActivation { get; private set; }

        [JsonProperty("defenderMOTD")]
        public string DefenderMOTD { get; private set; }

        [JsonProperty("deployerName")]
        public string DeployerName { get; private set; }

        [JsonProperty("deployerClan")]
        public string DeployerClan { get; private set; }

        [JsonProperty("history")]
        public IEnumerable<DarkSector?> History { get; private set; }
    }

    public class Event : Alert { }

    public class Alert
    {
        [JsonProperty("id")]
        public string Id { get; private set; }

        [JsonProperty("activation")]
        public string Activation { get; private set; }

        [JsonProperty("expiry")]
        public string Expiry { get; private set; }

        [JsonProperty("mission")]
        public Mission Mission { get; private set; }
    }

    public struct Item
    {
        [JsonProperty("count")]
        public int Count { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }
    }
}

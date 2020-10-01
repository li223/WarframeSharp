using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarframeSharp
{
    /// <summary>
    /// The Main Client Class
    /// </summary>
    public class WarframeSharpClient
    {
        private readonly string _baseQuery = "https://api.warframestat.us";
        private readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Warframe stats and general information.
        /// </summary>
        /// <returns></returns>
        public async Task<Warframe?> GetWarframeAsync(string query) => await this.GetAsync<Warframe?>($"warframes/search/{query}");

        /// <summary>
        /// Warframe stats and general information.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Warframe>> GetWarframesDataAsync() => await this.GetAsync<IEnumerable<Warframe>>($"warframes");

        /// <summary>
        /// The full response from each of the other methods, useful if you want all the data with only one call.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<WorldState?> GetWorldStateDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<WorldState?>($"{platform.ToString().ToLower()}");

        /// <summary>
        /// Translated News items from the worldstate
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<News>> GetNewsDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<News>>($"{platform.ToString().ToLower()}/news");

        /// <summary>
        /// Events, such as Fomorian Attacks are included here
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<Event>> GetEventsDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<Event>>($"{platform.ToString().ToLower()}/events");

        /// <summary>
        /// Description and rewards for Alerts
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        [Obsolete("Alerts have been replaced by Nightwave")]
        public async Task<IEnumerable<Alert>> GetAlertsDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<Alert>>($"{platform.ToString().ToLower()}/alerts");

        /// <summary>
        /// Data about the missions for the current sortie
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<Sortie?> GetSortieDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<Sortie?>($"{platform.ToString().ToLower()}/sortie");

        /// <summary>
        /// Cycling through different nodes each day, these are a general listing of the nodes that each syndicate will use for the day.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<SyndicateMission>> GetSyndicateMissionsDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<SyndicateMission>>($"{platform.ToString().ToLower()}/syndicateMissions");

        /// <summary>
        /// Information about current Void Fissure missions
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<Fissure>> GetFissuresDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<Fissure>>($"{platform.ToString().ToLower()}/fissures");

        /// <summary>
        /// Popular Deals, discounts, featured deals.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<FlashSale>> GetFlashSalesDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<FlashSale>>($"{platform.ToString().ToLower()}/flashSales");

        /// <summary>
        /// Data on invasion missions, such as estimated completion time, rewards, etc.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<Invasion>> GetInvasionsDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<Invasion>>($"{platform.ToString().ToLower()}/invasions");

        /// <summary>
        /// The endpoint this method uses is deprecated and only returns a joke response.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        [Obsolete("The endpoint this method uses is deprecated.", false)]
        public async Task<IEnumerable<DarkSector>> GetDarkSectorsDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<DarkSector>>($"{platform.ToString().ToLower()}/darkSector");

        /// <summary>
        /// Information on the current Void Trader offerings, or when he will arrive.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<VoidTrader?> GetVoidTraderDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<VoidTrader?>($"{platform.ToString().ToLower()}/voidTrader");

        /// <summary>
        /// Darvo's Daily Deal details
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<DailyDeal>> GetDarvoDealsAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<DailyDeal>>($"{platform.ToString().ToLower()}/dailyDeals");

        /// <summary>
        /// Status data for Simaris' Sanctuary
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<SimarisTarget?> GetSancturayDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<SimarisTarget?>($"{platform.ToString().ToLower()}/simaris");

        /// <summary>
        /// Data on each day and week's conclave challenges
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<ConclaveChallenge>> GetConclaveChallengesDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<IEnumerable<ConclaveChallenge>>($"{platform.ToString().ToLower()}/conclaveChallenges");

        /// <summary>
        /// Data on the Day/night cycle for Cetus on earth
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<CetusCycle?> GetCetusCycleDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<CetusCycle?>($"{platform.ToString().ToLower()}/cetusCycle");

        /// <summary>
        /// The current Earth day/night cycle progress.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<EarthCycle?> GetEarthCycleDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<EarthCycle?>($"{platform.ToString().ToLower()}/earthCycle");

        /// <summary>
        /// Construction percentages for showing how far constructed the enemy fleets are.
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<ConstructionProgress?> GetConstructionProgressDataAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<ConstructionProgress>($"{platform.ToString().ToLower()}/constructionProgress");

        /// <summary>
        /// The time that the worldstate was last generated
        /// </summary>
        /// <param name="platform">The platform you would like to get the data for</param>
        /// <returns></returns>
        public async Task<string> GetTimestampAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<string>($"{platform.ToString().ToLower()}/timestamp");

        /// <summary>
        /// Weapon Statistics
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Weapon>> GetWeaponsDataAsync() => await this.GetAsync<IEnumerable<Weapon>>($"weapons");

        /// <summary>
        /// Get the current state of the Orb Vallis
        /// </summary>
        /// <param name="platform"></param>
        /// <returns></returns>
        public async Task<OrbVallis> GetVallisCycleAsync(PlatformType platform = PlatformType.PC) => await this.GetAsync<OrbVallis>($"{platform.ToString().ToLower()}/vallisCycle");

        /// <summary>
        /// Gets a generic endpoint response.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        protected async Task<T> GetAsync<T>(string endpoint)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"{_baseQuery}/{endpoint}");

            return response.IsSuccessStatusCode
                ? JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync())
                : default;
        }
    }
}

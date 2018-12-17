using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.RegularExpressions;
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
        private HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Warframe stats and general information.
        /// </summary>
        /// <returns></returns>
        public async Task<Warframe?> GetWarframeAsync(string query)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/warframes/search/{query}").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<Warframe>(content);
            }
            else return null;
        }        
        
        /// <summary>
        /// Warframe stats and general information.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Warframe>> GetWarframesDataAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/warframes").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<Warframe>>(content);
            }
            else return null;
        }

        /// <summary>
        /// The full response from each of the other methods, useful if you want all the data with only one call.
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<WorldState?> GetWorldStateDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<WorldState>(content);
            }
            else return null;
        }

        /// <summary>
        /// Translated News items from the worldstate
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<News>> GetNewsDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/news").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<News>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Events, such as Fomorian Attacks are included here
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<Event>> GetEventsDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/events").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<Event>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Description and rewards for Alerts
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<Alert>> GetAlertsDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/alerts").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<Alert>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Data about the missions for the current sortie
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<Sortie?> GetSortieDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/sortie").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<Sortie>(content);
            }
            else return null;
        }

        /// <summary>
        /// Cycling through different nodes each day, these are a general listing of the nodes that each syndicate will use for the day.
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<SyndicateMission>> GetSyndicateMissionsDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/syndicateMissions").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<SyndicateMission>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Information about current Void Fissure missions
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<Fissure>> GetFissuresDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/fissures").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<Fissure>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Popular Deals, discounts, featured deals.
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<FlashSale>> GetFlashSalesDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/flashSales").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<FlashSale>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Data on invasion missions, such as estimated completion time, rewards, etc.
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<Invasion>> GetInvasionsDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/invasions").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<Invasion>>(content);
            }
            else return null;
        }

        /// <summary>
        /// The endpoint this method uses is deprecated and only returns a joke response.
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        [Obsolete("The endpoint this method uses is deprecated.", false)]
        public async Task<IEnumerable<DarkSector>> GetDarkSectorsDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/darkSector").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<DarkSector>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Information on the current Void Trader offerings, or when he will arrive.
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<VoidTrader?> GetVoidTraderDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/voidTrader").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<VoidTrader>(content);
            }
            else return null;
        }

        /// <summary>
        /// Darvo's Daily Deal details
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<DailyDeal>> GetDarvoDealsAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/dailyDeals").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<DailyDeal>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Status data for Simaris' Sanctuary
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<SimarisTarget?> GetSancturayDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/simaris").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<SimarisTarget>(content);
            }
            else return null;
        }

        /// <summary>
        /// Data on each day and week's conclave challenges
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<IEnumerable<ConclaveChallenge>> GetConclaveChallengesDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/conclaveChallenges").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<ConclaveChallenge>>(content);
            }
            else return null;
        }

        /// <summary>
        /// Data on the Day/night cycle for Cetus on earth
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<Cycle?> GetCetusCycleDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/cetusCycle").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<Cycle>(content);
            }
            else return null;
        }

        /// <summary>
        /// The current Earth day/night cycle progress.
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<Cycle?> GetEarthCycleDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/earthCycle").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<Cycle>(content);
            }
            else return null;
        }

        /// <summary>
        /// Construction percentages for showing how far constructed the enemy fleets are.
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<ConstructionProgress?> GetConstructionProgressDataAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/constructionProgress").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<ConstructionProgress>(content);
            }
            else return null;
        }

        /// <summary>
        /// The time that the worldstate was last generated
        /// </summary>
        /// <param name="platform.ToString().ToLower()">The platform.ToString().ToLower() you would like to get the data for</param>
        /// <returns></returns>
        public async Task<string> GetTimestampAsync(PlatformType platform = PlatformType.PC)
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/{platform.ToString().ToLower()}/timestamp").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<string>(content);
            }
            else return null;
        }

        /// <summary>
        /// Weapon Statistics
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Weapon>> GetWeaponsDataAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/weapons").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<IEnumerable<Weapon>>(content);
            }
            else return null;
        }
    }
}

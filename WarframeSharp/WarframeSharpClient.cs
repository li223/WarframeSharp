using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WarframeSharp
{
    public class WarframeSharpClient
    {
        private SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);
        private readonly string _baseQuery = "https://api.warframestat.us";
        private HttpClient _httpClient = new HttpClient();

        public async Task<WorldState?> GetWorldStateAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseQuery}/pc");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<WorldState>(content);
            }
            else return null;
        }
    }
}

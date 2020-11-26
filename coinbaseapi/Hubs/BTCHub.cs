
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Memory;

namespace coinbaseapi.Hubs
{
    public class BTCHub : Hub
    {
        private readonly IApiService _apiService;
        private readonly IMemoryCache _memoryCache;

        public BTCHub(IApiService apiService, IMemoryCache memoryCache)
        {
            _apiService = apiService;
            _memoryCache = memoryCache;
        }

        public override async Task OnConnectedAsync()
        {
            await InitializeCurrencyPolling();
            await base.OnConnectedAsync();
        }

        private async Task InitializeCurrencyPolling()
        {
            var priceList = _memoryCache.Get("PriceList");
            if (priceList == null)
            {
                await _apiService.StartPollingCoindesk();
            }
        }

    }
}
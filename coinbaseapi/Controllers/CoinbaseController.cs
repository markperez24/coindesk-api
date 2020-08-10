using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coinbaseapi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace coinbaseapi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CoinbaseController : ControllerBase
  {
    private readonly ILogger<CoinbaseController> _logger;
    private readonly IMemoryCache _memoryCache;

    public CoinbaseController(
      ILogger<CoinbaseController> logger,
      IMemoryCache memoryCache
    )
    {
      _logger = logger;
      _memoryCache = memoryCache;
    }

    [HttpGet]
    public IEnumerable<Price> Get()
    {
      IList<Price> prices = _memoryCache.Get("PriceList") as IList<Price>;
      if (prices != null)
      {
        return prices;
      }

      return new List<Price>();
    }
  }
}

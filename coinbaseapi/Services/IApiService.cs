using System.Threading.Tasks;
using coinbaseapi.Models;

public interface IApiService
{
  public Task<Price> GetCurrentBtcPrice();
  public Task<Price> GetCurrentEthPrice();
  public Task StartPollingCoindesk();
}
using System.Threading.Tasks;
using coinbaseapi.Models;

public interface IApiService
{
  public Task<Price> GetCurrentBtcPrice();
  public Task StartPollingCoindesk();
}
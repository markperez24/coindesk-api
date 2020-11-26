using Newtonsoft.Json;

namespace coinbaseapi.Models
{
  public class CurrentPriceResponse
  {
    public CurrentPriceResponseTime Time { get; set; }
    public CurrentPriceResponseBPI BPI { get; set; }
    public CurrentPriceResponseData Data { get; set; }
  }

  public class CurrentPriceResponseTime
  {
    public string Updated { get; set; }
    public string UpdatedIso { get; set; }
    public string UpdatedUk { get; set; }
  }

  public class CurentPriceResponseIndex
  {
    public string Code { get; set; }
    public string Rate { get; set; }
    public string Description { get; set; }

    [JsonProperty("rate_float")]
    public float RateFloat { get; set; }

    [JsonProperty("NZD")]
    public float RateFloatNZD { get; set; }
  }

  public class CurrentPriceResponseBPI
  {
    public CurentPriceResponseIndex USD { get; set; }
    public CurentPriceResponseIndex NZD { get; set; }
  }

  public class CurrentPriceResponseData
  {
    public CurentPriceResponseIndex Rates { get; set;  }
  }
}
using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Trade;

public record RejectTradeOfferRequest
{
    [Required]
    public string TradeId { get; set; }
}

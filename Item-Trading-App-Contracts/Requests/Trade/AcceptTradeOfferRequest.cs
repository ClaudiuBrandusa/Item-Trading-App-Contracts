using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Trade;

public record AcceptTradeOfferRequest
{
    [Required]
    public string TradeId { get; set; }
}

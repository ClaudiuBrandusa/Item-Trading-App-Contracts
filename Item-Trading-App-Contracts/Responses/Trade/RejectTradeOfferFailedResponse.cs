using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Trade;

// used when something went wrong while rejecting the received trade offer
public record RejectTradeOfferFailedResponse : FailedResponse
{
    public string TradeId { get; set; }

    public string SenderId { get; set; }

    public string SenderName { get; set; }
}

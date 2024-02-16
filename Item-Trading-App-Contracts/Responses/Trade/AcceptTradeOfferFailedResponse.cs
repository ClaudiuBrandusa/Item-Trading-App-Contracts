using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Trade;

public record AcceptTradeOfferFailedResponse : FailedResponse
{
    public string TradeId { get; set; }

    public string SenderId { get; set; }

    public string SenderName { get; set; }
}

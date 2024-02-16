using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Trade;

public record GetSentTradeOfferFailedResponse : FailedResponse
{
    public string TradeId { get; set; }

    public string ReceiverId { get; set; }

    public string ReceiverName { get; set; }
}

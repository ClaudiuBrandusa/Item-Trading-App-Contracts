namespace Item_Trading_App_Contracts.Responses.Trade;

public record CancelTradeOfferSuccessResponse
{
    public string TradeId { get; set; }

    public string ReceiverId { get; set; }

    public string ReceiverName { get; set; }
}

namespace Item_Trading_App_Contracts.Responses.Trade;

public record CancelTradeOfferSuccessResponse
{
    public string TradeOfferId { get; set; }

    public string ReceiverId { get; set; }

    public string ReceiverName { get; set; }
}

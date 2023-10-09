namespace Item_Trading_App_Contracts.Requests.Trade;

public record AcceptTradeOfferRequest
{
    public string TradeId { get; set; }
}

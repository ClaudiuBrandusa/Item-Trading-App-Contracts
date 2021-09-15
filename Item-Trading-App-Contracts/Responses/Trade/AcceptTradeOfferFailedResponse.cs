using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Trade
{
    public class AcceptTradeOfferFailedResponse : FailedResponse
    {
        public string TradeOfferId { get; set; }
    }
}

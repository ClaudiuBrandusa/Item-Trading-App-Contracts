using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Trade
{
    // used when something went wrong while rejecting the received trade offer
    public class RejectTradeOfferFailedResponse : FailedResponse
    {
        public string Id { get; set; }
    }
}

using Item_Trading_App_Contracts.Responses.Base;

namespace Item_Trading_App_Contracts.Responses.Trade
{
    class GetSentTradeOfferFailedResponse : FailedResponse
    {
        public string TradeOfferId { get; set; }

        public string ReceiverId { get; set; }

        public string ReceiverName { get; set; }
    }
}

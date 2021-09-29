namespace Item_Trading_App_Contracts.Responses.Trade
{
    public class CancelTradeOfferSuccessResponse
    {
        public string TradeOfferId { get; set; }

        public string ReceiverId { get; set; }

        public string ReceiverName { get; set; }
    }
}

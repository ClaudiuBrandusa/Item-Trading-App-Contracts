using Item_Trading_App_Contracts.Base.TradeOffer;

namespace Item_Trading_App_Contracts.Responses.Trade
{
    public class GetReceivedTradeOfferSuccessResponse : TradeOffer
    {
        public string SenderId { get; set; }
        
        public string SenderName { get; set; }
    }
}

using Item_Trading_App_Contracts.Base.TradeOffer;
using System;

namespace Item_Trading_App_Contracts.Responses.Trade
{
    public class GetReceivedTradeOfferSuccessResponse : TradeOffer
    {
        public string SenderId { get; set; }
        
        public string SenderName { get; set; }

        public DateTime SendDate { get; set; }

        public string ReceiverId { get; set; }

        public string ReceiverName { get; set; }
    }
}

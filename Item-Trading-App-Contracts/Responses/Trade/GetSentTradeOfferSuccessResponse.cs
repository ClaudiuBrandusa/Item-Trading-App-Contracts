using Item_Trading_App_Contracts.Base.TradeOffer;
using System;

namespace Item_Trading_App_Contracts.Responses.Trade
{
    // used for sent trade offers
    public class GetSentTradeOfferSuccessResponse : TradeOffer
    {
        public DateTime SendDate { get; set; }

        public string ReceiverId { get; set; }

        public string ReceiverName { get; set; }
    }
}

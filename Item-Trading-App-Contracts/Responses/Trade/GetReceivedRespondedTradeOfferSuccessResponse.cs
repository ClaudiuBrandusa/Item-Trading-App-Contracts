using System;

namespace Item_Trading_App_Contracts.Responses.Trade
{
    public class GetReceivedRespondedTradeOfferSuccessResponse : GetReceivedTradeOfferSuccessResponse
    {
        public DateTime RespondedTime { get; set; }

        public bool Response { get; set; }
    }
}

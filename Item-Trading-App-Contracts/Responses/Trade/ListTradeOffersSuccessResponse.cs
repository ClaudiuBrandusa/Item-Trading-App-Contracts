using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Responses.Trade
{
    // used when we request a list of trade offers
    // then we can request each trade offer by id
    public class ListTradeOffersSuccessResponse
    {
        public IEnumerable<string> TradeOffersIds { get; set; }
    }
}

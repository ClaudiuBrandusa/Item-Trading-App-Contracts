using Item_Trading_App_Contracts.Base.Item;
using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Requests.Trade
{
    // used when we want to send a trade offer to another user
    public class TradeOfferRequest
    {
        public string TargetUserId { get; set; }

        public IEnumerable<ItemWithPrice> Items { get; set; }
    }
}

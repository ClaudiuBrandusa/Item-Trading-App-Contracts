using Item_Trading_App_Contracts.Base.Item;
using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Base.TradeOffer
{
    public class TradeOffer
    {
        public string Id { get; set; }

        public IEnumerable<ItemWithPrice> Items { get; set; }
    }
}

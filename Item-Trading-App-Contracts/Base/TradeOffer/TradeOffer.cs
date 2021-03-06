using Item_Trading_App_Contracts.Base.Item;
using System;
using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Base.TradeOffer
{
    public class TradeOffer
    {
        public string TradeId { get; set; }

        public DateTime SentDate { get; set; }

        public IEnumerable<ItemWithPrice> Items { get; set; }
    }
}

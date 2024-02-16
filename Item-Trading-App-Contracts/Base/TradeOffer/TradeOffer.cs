using Item_Trading_App_Contracts.Base.Item;
using System;
using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Base.TradeOffer;

public record TradeOffer
{
    public string TradeId { get; set; }

    public DateTime CreationDate { get; set; }

    public IEnumerable<ItemWithPrice> Items { get; set; }
}

using Item_Trading_App_Contracts.Base.Item;
using System;
using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Responses.Trade;

public record TradeOfferSuccessResponse
{
    public string TradeId { get; set; }

    public string SenderId { get; set; }

    public string SenderName { get; set; }

    public string ReceiverId { get; set; }

    public string ReceiverName { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? ResponseDate { get; set; }

    public bool? Response { get; set; }

    public IEnumerable<ItemWithPrice> Items { get; set; }
}

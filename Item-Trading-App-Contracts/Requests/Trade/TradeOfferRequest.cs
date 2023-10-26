using Item_Trading_App_Contracts.Base.Item;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Trade;

// used when we want to send a trade offer to another user
public record TradeOfferRequest
{
    [Required]
    public string TargetUserId { get; set; }

    [Required]
    public IEnumerable<ItemWithPrice> Items { get; set; }
}

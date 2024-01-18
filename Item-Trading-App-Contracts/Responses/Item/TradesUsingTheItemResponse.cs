using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Responses.Item;
public record TradesUsingTheItemResponse
{
    public string ItemId { get; set; }

    public IEnumerable<string> TradeIds { get; set; }
}

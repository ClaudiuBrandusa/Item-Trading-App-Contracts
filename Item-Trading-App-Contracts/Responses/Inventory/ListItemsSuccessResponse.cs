using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Responses.Inventory;

public record ListItemsSuccessResponse
{
    public IEnumerable<string> ItemsId { get; set; }
}

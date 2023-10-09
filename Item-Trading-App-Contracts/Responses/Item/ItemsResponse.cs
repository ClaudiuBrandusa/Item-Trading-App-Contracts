using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Responses.Item;

public record ItemsResponse
{
    public IEnumerable<string> ItemsId { get; set; }
}

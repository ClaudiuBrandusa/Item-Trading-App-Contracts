using System.Collections.Generic;

namespace Item_Trading_App_Contracts.Responses.Item
{
    public class ItemsResponse
    {
        public IEnumerable<ItemResponse> Items { get; set; }
    }
}

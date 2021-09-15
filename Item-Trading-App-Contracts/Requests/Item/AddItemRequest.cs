namespace Item_Trading_App_Contracts.Requests.Item
{
    // used when we want to add an amount of an item to our inventory
    public class AddItemRequest
    {
        public string ItemId { get; set; }

        public int Quantity { get; set; }
    }
}

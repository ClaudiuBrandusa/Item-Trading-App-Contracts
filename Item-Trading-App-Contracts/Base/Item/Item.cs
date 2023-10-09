namespace Item_Trading_App_Contracts.Base.Item;

public record Item
{
    public string Id { get; set; }

    public string Name { get; set; }

    public int Quantity { get; set; }
}

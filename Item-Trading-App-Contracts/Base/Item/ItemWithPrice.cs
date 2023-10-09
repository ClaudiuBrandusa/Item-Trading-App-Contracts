namespace Item_Trading_App_Contracts.Base.Item;

public record ItemWithPrice : Item
{
    public int Price { get; set; }
}

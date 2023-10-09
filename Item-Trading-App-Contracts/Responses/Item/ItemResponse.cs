namespace Item_Trading_App_Contracts.Responses.Item;

public record ItemResponse
{
    public string Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }
}

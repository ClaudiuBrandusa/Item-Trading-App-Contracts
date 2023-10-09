namespace Item_Trading_App_Contracts.Notifications.Content;

public record ModifiedContentWithCustomData : ModifiedContent
{
    public object CustomData { get; set; }
}

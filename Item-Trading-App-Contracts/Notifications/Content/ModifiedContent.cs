namespace Item_Trading_App_Contracts.Notifications.Content;

public record ModifiedContent : NotificationContent
{
    public string Category { get; set; }

    public string Id { get; set; }
}

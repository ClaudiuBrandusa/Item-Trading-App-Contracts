using System.Text.Json.Nodes;

namespace Item_Trading_App_Contracts.Notifications.Content;

public record ModifiedContentJson : NotificationContent
{
    public string Category { get; set; }

    public string Id { get; set; }

    public JsonNode Content { get; set; }
}

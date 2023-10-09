using Item_Trading_App_Contracts.Notifications.Content;

namespace Item_Trading_App_Contracts.Notifications;

public record Notification<T> where T : NotificationContent
{
    public string Type { get; set; }

    public T Content { get; set; }
}

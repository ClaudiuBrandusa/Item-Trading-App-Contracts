using System;

namespace Item_Trading_App_Contracts.Notifications.Content;

public record MessageContent : NotificationContent
{
    public object Content { get; set; }

    public DateTime CreatedDateTime { get; set; }
}

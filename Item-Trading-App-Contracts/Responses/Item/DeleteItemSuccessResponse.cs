﻿namespace Item_Trading_App_Contracts.Responses.Item;

public record DeleteItemSuccessResponse
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }
}

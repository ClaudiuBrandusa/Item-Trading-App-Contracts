﻿namespace Item_Trading_App_Contracts.Responses.Inventory;

public record DropItemSuccessResponse
{
    public string ItemId { get; set; }

    public string ItemName { get; set; }

    public int Quantity { get; set; } // represents the removed amount
}

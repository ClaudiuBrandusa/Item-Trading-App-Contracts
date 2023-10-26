using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Inventory;

// used when we want to add an amount of an item to our inventory
public record AddItemRequest
{
    [Required]
    public string ItemId { get; set; }

    public int Quantity { get; set; }
}

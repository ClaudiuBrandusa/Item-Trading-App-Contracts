using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Item;

// used when we update data about an item
public record UpdateItemRequest
{
    [Required]
    public string ItemId { get; set; }

    [Required]
    public string ItemName { get; set; }

    public string ItemDescription { get; set; }
}

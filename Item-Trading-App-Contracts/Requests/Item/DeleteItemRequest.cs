using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Item;

public record DeleteItemRequest
{
    [Required]
    public string ItemId { get; set; }
}

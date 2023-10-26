using System.ComponentModel.DataAnnotations;

namespace Item_Trading_App_Contracts.Requests.Item;

public record CreateItemRequest
{
    [Required]
    public string ItemName { get; set; }

    public string ItemDescription { get; set; }
}

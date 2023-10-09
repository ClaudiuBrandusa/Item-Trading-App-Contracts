using System;

namespace Item_Trading_App_Contracts.Responses.Trade;

// used when we reject a received trade offer
public record RejectTradeOfferSuccessResponse
{
    public string Id { get; set; }

    public string SenderId { get; set; }

    public string SenderName { get; set; }

    public DateTime ReceivedDate { get; set; }

    public DateTime ResponseDate { get; set; }
}

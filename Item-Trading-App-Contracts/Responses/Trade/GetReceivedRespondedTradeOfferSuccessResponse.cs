using System;

namespace Item_Trading_App_Contracts.Responses.Trade;

public record GetReceivedRespondedTradeOfferSuccessResponse : GetReceivedTradeOfferSuccessResponse
{
    public DateTime ResponseDate { get; set; }

    public bool Response { get; set; }
}

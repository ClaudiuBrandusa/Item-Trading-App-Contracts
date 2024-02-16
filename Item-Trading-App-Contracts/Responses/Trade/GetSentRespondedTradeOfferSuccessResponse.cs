using System;

namespace Item_Trading_App_Contracts.Responses.Trade;

// used for responded sent trade offers
public record GetSentRespondedTradeOfferSuccessResponse : GetSentTradeOfferSuccessResponse
{
    public DateTime? ResponseDate { get; set; }

    public bool? Response { get; set; }
}

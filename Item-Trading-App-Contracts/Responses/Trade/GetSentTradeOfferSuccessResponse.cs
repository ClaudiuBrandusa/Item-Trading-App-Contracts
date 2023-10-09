using Item_Trading_App_Contracts.Base.TradeOffer;

namespace Item_Trading_App_Contracts.Responses.Trade;

// used for sent trade offers
public record GetSentTradeOfferSuccessResponse : TradeOffer
{
    public string ReceiverId { get; set; }

    public string ReceiverName { get; set; }
}

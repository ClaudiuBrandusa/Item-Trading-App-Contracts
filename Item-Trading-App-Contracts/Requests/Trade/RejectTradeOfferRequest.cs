﻿namespace Item_Trading_App_Contracts.Requests.Trade;

public record RejectTradeOfferRequest
{
    public string TradeId { get; set; }
}

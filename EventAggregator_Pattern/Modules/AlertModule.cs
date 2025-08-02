using EventAggregator_Pattern.Events;
using EventAggregator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventAggregator_Pattern.Modules
{
    public class AlertModule : ISubscriber<StockPriceUpdatedEvent>
    {
        public void OnEvent(StockPriceUpdatedEvent eventData)
        {
            if (eventData.Price > 500)
                Console.WriteLine($"[ALERT] {eventData.Symbol} crossed threshold: {eventData.Price:C}");
        }
    }

}

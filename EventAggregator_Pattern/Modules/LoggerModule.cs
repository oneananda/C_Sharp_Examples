using EventAggregator_Pattern.Events;
using EventAggregator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventAggregator_Pattern.Modules
{
    public class LoggerModule : ISubscriber<StockPriceUpdatedEvent>
    {
        public void OnEvent(StockPriceUpdatedEvent eventData)
        {
            Console.WriteLine($"[Logger] {eventData.Symbol} updated to {eventData.Price:C}");
        }
    }

}

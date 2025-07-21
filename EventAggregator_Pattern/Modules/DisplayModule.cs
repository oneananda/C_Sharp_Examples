using EventAggregator_Pattern.Events;
using EventAggregator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventAggregator_Pattern.Modules
{
    public class DisplayModule : ISubscriber<StockPriceUpdatedEvent>
    {
        public void OnEvent(StockPriceUpdatedEvent eventData)
        {
            Console.WriteLine($"[Display] Price for {eventData.Symbol}: {eventData.Price:C}");
        }
    }

}

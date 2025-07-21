using EventAggregator_Pattern.Events;
using EventAggregator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EventAggregator_Pattern.Services
{
    public class StockService
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly Random _rand = new();

        public StockService(IEventAggregator aggregator)
        {
            _eventAggregator = aggregator;
        }

        public async Task StartAsync()
        {
            string[] symbols = { "MSFT", "AAPL", "GOOG" };
            while (true)
            {
                var symbol = symbols[_rand.Next(symbols.Length)];
                var price = (decimal)(_rand.NextDouble() * 1000);
                _eventAggregator.Publish(new StockPriceUpdatedEvent(symbol, price));
                await Task.Delay(1000);
            }
        }
    }

}

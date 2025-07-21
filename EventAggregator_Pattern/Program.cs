using EventAggregator_Pattern.Core;
using EventAggregator_Pattern.Modules;
using EventAggregator_Pattern.Services;
using System;

namespace EventAggregator_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var aggregator = new EventAggregator();

            aggregator.Subscribe(new LoggerModule());
            aggregator.Subscribe(new AlertModule());
            aggregator.Subscribe(new DisplayModule());

            var stockService = new StockService(aggregator);
            await stockService.StartAsync();

            Console.WriteLine("EventAggregator_Pattern!");
        }
    }
}

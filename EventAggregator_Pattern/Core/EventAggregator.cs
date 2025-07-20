using EventAggregator_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventAggregator_Pattern.Core
{
    public class EventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, List<object>> _subscribers = new();

        public void Subscribe<T>(ISubscriber<T> subscriber)
        {
            if (!_subscribers.TryGetValue(typeof(T), out var subs))
            {
                subs = new List<object>();
                _subscribers[typeof(T)] = subs;
            }
            subs.Add(subscriber);
        }

        public void Publish<T>(T eventData)
        {
            if (_subscribers.TryGetValue(typeof(T), out var subs))
            {
                foreach (var sub in subs.Cast<ISubscriber<T>>())
                {
                    sub.OnEvent(eventData);
                }
            }
        }
    }
}

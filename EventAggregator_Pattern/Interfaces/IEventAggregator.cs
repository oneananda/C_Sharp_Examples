using System;
using System.Collections.Generic;
using System.Text;

namespace EventAggregator_Pattern.Interfaces
{
    public interface IEventAggregator
    {
        void Subscribe<T>(ISubscriber<T> subscriber);
        void Publish<T>(T eventData);
    }
}

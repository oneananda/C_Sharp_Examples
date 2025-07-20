using System;
using System.Collections.Generic;
using System.Text;

namespace EventAggregator_Pattern.Interfaces
{
    public interface ISubscriber<T>
    {
        void OnEvent(T eventData);
    }
}

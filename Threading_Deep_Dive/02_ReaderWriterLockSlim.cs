using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_Deep_Dive
{
    internal class _02_ReaderWriterLockSlim
    {
        // This class demonstrates the use of ReaderWriterLockSlim for thread-safe caching.
        // It allows multiple threads to read from the cache simultaneously while ensuring
        // that only one thread can write to the cache at a time.
        // The GetOrAdd method retrieves a value from the cache or adds it if it does not exist.
    }
    public sealed class RWCache<TKey, TValue>
    {
        private readonly Dictionary<TKey, TValue> _dict = new();
        private readonly ReaderWriterLockSlim _lock = new(LockRecursionPolicy.NoRecursion);

        public TValue GetOrAdd(TKey key, Func<TKey, TValue> factory)
        {
            _lock.EnterReadLock();
            try
            {
                if (_dict.TryGetValue(key, out var v)) return v;
            }
            finally { _lock.ExitReadLock(); }

            _lock.EnterWriteLock();
            try
            {
                if (!_dict.TryGetValue(key, out var v))
                {
                    v = factory(key);
                    _dict[key] = v;
                }
                return v;
            }
            finally { _lock.ExitWriteLock(); }
        }
    }

    public static class ReaderWriterLockSlimDemo
    {
        public static void Run()
        {
            var cache = new RWCache<int, string>();
            Console.WriteLine(cache.GetOrAdd(42, k => $"Value for {k}"));
        }
    }
}

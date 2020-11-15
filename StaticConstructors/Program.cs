using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    class Program
    {
        class ClassA
        {
            static readonly DateTime InitializedTime;
            static ClassA()
            {
                InitializedTime = DateTime.Now;
                Console.WriteLine("Static Constructor ClassA is called! Initialized at "
                    +InitializedTime.ToString("HH:mm:ms"));

            }
            public ClassA(int Count)
            {
                Console.WriteLine("Public Constructor ClassA is called! Count is :" + Count.ToString() 
                    + " Initialized at" + InitializedTime.ToString("HH:mm:ms"));
            }
        }
        static void Main(string[] args)
        {
            ClassA ClsObjA = new ClassA(2);
            ClassA ClsObjB = new ClassA(3);
            Console.ReadLine();
        }
    }
}

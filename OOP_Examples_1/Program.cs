using System;

namespace C_Sharp_OOP_1
{
    class Program
    {
        class BaseClass1
        {
            public BaseClass1()
            {
                Console.WriteLine("In BaseClass1 constructor");
            }
        }
        class DerivedClass1 : BaseClass1
        {
            public DerivedClass1()
            {
                Console.WriteLine("In DerivedClass1 constructor");
            }
        }

        static void Main(string[] args)
        {
            BaseClass1 BC1Obj = new BaseClass1();

            Console.WriteLine();


            BaseClass1 BC1Obj2 = new DerivedClass1();

            Console.WriteLine();


            DerivedClass1 DC1Obj1 = new DerivedClass1();

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}

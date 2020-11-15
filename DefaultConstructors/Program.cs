using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Example 1, This works, uncomment below line to work on
            //ClassA ClsAObj1 = new ClassA();

            //// Example 2, This will not work, uncomment below line to work on
            //ClassB ClsBObj1 = new ClassB();

            ////Example 3 , uncomment below line to work on
            //ClassC ClsCObj1 = new ClassC();


            ////Example 4 & 5 , uncomment below line to work on
            //ClassD ClsDObj1 = new ClassD();
        }

        class ClassA
        {

        }

        class ClassB
        {
            private ClassB()
            {

            }
        }
        

        class ClassC
        {
            public ClassC()
            {

            }
            // Uncomment this to see an complile time error message
            //private ClassC()
            //{

            //}
        }


        class ClassD
        {
            private int Age { get; set; }
            private string Location { get; set; }

            public ClassD()
            {
                ClassD _Cla = new ClassD(30, "Sydney");
            }

            private ClassD(int pAge, string pLocation)
            {
                this.Age = pAge;
                this.Location = pLocation;
            }
        }

    }
}

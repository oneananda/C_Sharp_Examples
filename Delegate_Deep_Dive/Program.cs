﻿
using Delegate_Deep_Dive.Advanced_Delegate;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Delegate_Deep_Dive
{    
    public class Program
    {
        static void Main(string[] args)
        {
            //// Executes the basic delegate example, demonstrating how to define and invoke a simple delegate.
            //BasicDelegateExample.BasicDelegate();

            //// Executes the multicast delegate example, showing how a delegate can reference multiple methods.
            //MulticastDelegateExample.MulticastDelegate();

            //// Executes the delegate as a parameter example, illustrating how to pass delegates as method parameters.
            //DelegateAsParameterExample.DelegateAsParameter();

            //// Executes the anonymous method example, demonstrating how to use an anonymous method with a delegate.
            //AnonymousMethodExample.AnonymousMethod();


            ConsoleEventHandlingExample.ConsoleEventHandling();



            //Console.ReadLine(); // Hold screen
        }      
    }
}

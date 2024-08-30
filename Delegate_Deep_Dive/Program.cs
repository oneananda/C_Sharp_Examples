
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

namespace Delegate_Deep_Dive
{    
    public class Program
    {
        static void Main(string[] args)
        {
            BasicDelegateExample.BasicDelegate();
            MulticastDelegateExample.MulticastDelegate();
            Console.ReadLine(); // Hold screen
        }      
    }
}

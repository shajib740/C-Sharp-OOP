using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class DisplayMessage
    {
        public static void WelComeMessage(string firstName)
        {
            Console.WriteLine($"Welcome to our APP {firstName}");
        }

        public static void DisplayResult(string message)
        {
            Console.WriteLine(message);
        }
    }
}

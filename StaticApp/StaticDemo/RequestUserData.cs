using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class RequestUserData
    {
        public static string GetFirstName(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            return output;
        }
        public static double GetNumber(string message)
        {
            double output;
            bool isValidDouble;
            string textData;

            do
            {
                Console.Write(message);
                textData = Console.ReadLine();
                isValidDouble = double.TryParse(textData, out output);
                if (isValidDouble == false)
                {
                    Console.WriteLine("You have entered a worng type of number");
                }

            } while (isValidDouble == false);

            return output;
        }
    }
}

using System;

namespace ExtensionMethods
{
    public static class ConsoleHelper
    {
        public static int RequestInt(this string message)
        {
            return message.RequestInt(false);
           
        }
        public static int RequestInt(this string message, int minValue, int maxValue)
        {
            return message.RequestInt(true, minValue, maxValue );
        }
        private static int RequestInt(this string message, bool useMinMax, int minValue = 0, int maxValue = 0)
        {
            int output = 0;
            bool isValidInt = false;
            bool isinValidRange = true;

            while (isValidInt == false || isinValidRange == false)
            {
                Console.Write(message);
                isValidInt = int.TryParse(Console.ReadLine(), out output);
                
                if (useMinMax == true)
                {
                    isinValidRange = (output >= minValue && output <= maxValue) ;
                }
            }
            return output;
        }
        public static string RequestString(this string message)
        {
            string output = "";
          
            while (string.IsNullOrEmpty(output))
            {
                Console.Write(message);
                output = Console.ReadLine();
            }
            return output;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public static class Calculate
    {

        public static double Add(double x, double y)
        {
            double output = x + y;
            
            return output;
        }
        public static double Multiply (double x, double y) 
        { 
            double output = x * y;

            return output;
        }

        public static double Subtract(double x, double y)
        {
            double output = (x - y);

            return output;
        }

        public static double Divide(double x, double y)
        {
            double output = x / y;

            return output;
        }

        public static bool CheckDataValidity(double x , double y )
        {
            bool output = (y == 0) || (x == 0 && y == 0) ? false : true ;

            return output;
        }


    }
}

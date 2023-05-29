using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number14
{
    public class MySearch
    {
        static void Main(string[] args)
        {
        }
        public static double MyMax(double number1, double number2, double number3)
        {
            if (number1 > number2)
            {
                if (number1 > number3)
                {
                    return number1;
                }
                else
                {
                    return number3;
                }
            }
            else
            {
                if (number2 > number3)
                {
                    return number2;
                }
                else
                {
                    return number3;
                }
            }
        }
    }
}

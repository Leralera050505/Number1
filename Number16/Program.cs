using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number16
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Nums(string str)
        {
            int output = 0;
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    output++;
                }
            }
            return output;
        }
    }
}

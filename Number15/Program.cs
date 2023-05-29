using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number15
{
    public class Litter
    {
        static void Main(string[] args)//опциональный код самого приложения
        {
            Console.WriteLine(CountLitters("Hello!"));
            Console.ReadKey();
        }
        public static int CountLitters(string word)//Тестируемый метод, в данном случае находит Количество букв в строке
        {
            if (word != null || word == "")
            {
                string[] arrW = word.Split(' '); //Убираем пробеллы мз строки
                word = "";
                for (int i = 0; i < arrW.Length; i++)
                {
                    word += arrW[i];
                }
                return word.Length;
            }
            else
            {
                return 0;
            }
        }
    }
}

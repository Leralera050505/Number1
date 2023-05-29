using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number12
{
    public class Arr
    {
        static void Main(string[] args)
        {
            double[] arr = new double[5] { 1, 2, 3, 4, 5 }; //опциональный код самого приложения
            Console.WriteLine(MaxFromArr(arr));
            Console.ReadKey();
        }
        public static double MaxFromArr(double[] arr) //Тестируемый метод, в данном случае находит максимальное значение в массиве
        {
            if (arr.Length > 0) //Проверка на пустоту массива
            {
                return arr.Max();
            }
            else
            {
                return 0;
            }
            //------------(Нормальный метод в одну строчку)



            //if (arr.Length > 0)
            //{
            //    double temp = arr[0];                     //---------------(Если придерётся к нормальному методу)
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (temp < arr[i])
            //        {
            //            temp = arr[i];
            //        }
            //    }
            //    return temp;
            //}
            //else
            //{
            //    return 0;
            //}

        }
    }
}

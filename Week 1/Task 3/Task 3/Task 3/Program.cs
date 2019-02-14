using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// Вводим n для размера массива
            int[] arr = new int[n];// Присваиваем n и определяем размер массива
            string[] s = Console.ReadLine().Split();// Ввод чисел через строчный массив и разделение чисел через пробел
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(s[i]);// Преобразование строчного массива в числовой
            }
            for (int i = 0; i < arr.Length; i++) // Вывод продублированных чисел
            {
                Console.Write("{0} {0} ", arr[i]); //параметры в помощь
            }
            Console.ReadKey();// Терминал не закрывается)))
        }
       
    }
}

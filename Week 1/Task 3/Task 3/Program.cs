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
            int n = int.Parse(Console.ReadLine()); // Создаем переменную n для количества столбцов и рядов

            string a = "";
            string b = "[*]";
            for(int i = 0; i < n; i++) // Отрисовка
            {
                a += b;
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}

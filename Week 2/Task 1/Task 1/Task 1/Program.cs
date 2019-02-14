using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Darkhan\Documents\PP2\Week 2\Task 1\Task 1\read.txt");
            string s = sr.ReadToEnd(); //Считывает строку c файла
            char[] c = s.ToCharArray(); //Копирует знаки данного экземпляра в массив знаков Юникода
            Array.Reverse(c); // проверка на полиндромность с помощью reverse
            string s2 = new string(c);
            if (s2 == s) // сравнивание строк
            
                Console.WriteLine("YES");
                else
                Console.WriteLine("NO");


            Console.ReadKey();
        }
    }
}

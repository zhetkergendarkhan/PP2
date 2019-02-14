using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_3
{
    class Program
    {
        public static void PrintSpaces(int level) //функция для создания уровней

        {

            for (int i = 0; i < level; i++)

                Console.Write("     ");

        }



        public static void Lev(DirectoryInfo dir, int level)// функция для определения файлов и папок

        {

            foreach (FileInfo f in dir.GetFiles())

            {

                PrintSpaces(level);//вызов функции printspace

                Console.WriteLine(f.Name);//вывод имен файлов

            }

            foreach (DirectoryInfo d in dir.GetDirectories())

            {

                PrintSpaces(level);// вызов функции

                Console.WriteLine(d.Name);// вывод имен директорий

                Lev(d, level + 2);//вызов функции  с увеличенным уровнем для распознавания

            }

        }
        static void Main(string[] args)
        {

            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Darkhan\Documents\PP2");// путь
            Lev(dir, 0); //первоначальный уровень 
            Console.ReadKey();
        }
    }
}

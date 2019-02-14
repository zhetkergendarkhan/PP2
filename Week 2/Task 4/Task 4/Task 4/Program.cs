using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"C:\Users\Darkhan\Documents\PP2\Week 2\Path\ex.txt"; //путь к первой папке с файлом
            string file2 = @"C:\Users\Darkhan\Documents\PP2\Week 2\Path2\ex.txt";// второй путь , куда мы будем копировать файл 
if (File.Exists(@"C:\Users\Darkhan\Documents\PP2\Week 2\Path\ex.txt"))// проверка на существования файла
            {
                Console.WriteLine("File Exists");
            }
else
                Console.WriteLine("You cannot do this operation");
            File.Copy(file, file2);// копирование файла из первой папки во вторую
            Console.WriteLine("Copied");
            if(File.Exists(@"C:\Users\Darkhan\Documents\PP2\Week 2\Path\ex.txt"))//проверка
            {
                
                    File.Delete(@"C:\Users\Darkhan\Documents\PP2\Week 2\Path\ex.txt");//удаление файла с первой папки после копирования во вторую папку
                        
               
            }

            Console.WriteLine( "Original file deleted");
        }
    }
}

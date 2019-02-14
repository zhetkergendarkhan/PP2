using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student //Создаем класс Student
    {
        public string name;
        public string id;
        public int year;
        
        public Student(string name,string id,int year)
        {
            this.name = name; // Назначение классу Student имени введенного пользозователем
            this.id = id; // Назначение классу Student id введенного пользозователем
            this.year = year; // Назначение классу Student year введенного пользозователем

        }
        public void print()
        {
            Console.WriteLine("Имя студента:  {0}",name); // Вывод имени студента используя параметр
            Console.WriteLine(  "ID студента: {0}",id); // Вывод id студента используя параметр
            if (year == 1)
                
                
            {
                Console.WriteLine("Вы перваш!");
                year++; // Увелечение года обучения на 1 (инкремент)
                Console.WriteLine("В cледющим году вы будете второкурсником!");
            }
            else if (year == 4)
            {
                Console.WriteLine("поздравляю!ты выпускник");
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя,id и год обучения:");
            Student st1 = new Student(Console.ReadLine(), Console.ReadLine(), int.Parse(Console.ReadLine())); // Ввод данных
        
            st1.print();// Вывод данных

            Console.ReadLine(); // Терминал не закрывается))))

        }
    }
}

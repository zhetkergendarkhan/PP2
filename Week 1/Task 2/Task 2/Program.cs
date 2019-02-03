using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public string id;
        public int year;
        
        public Student(string name,string id,int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;

        }
        public void print()
        {
            Console.WriteLine("Имя студента:  {0}",name);
            Console.WriteLine(  "ID студента: {0}",id);
            if (year == 1)
            {
                Console.WriteLine("Вы перваш!");
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
        
            st1.print();

            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream number = new FileStream(@"C:\Users\Darkhan\Documents\PP2\Week 2\Task 2\Task 2\in.txt",FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(number);
            FileStream prime = new FileStream(@"C:\Users\Darkhan\Documents\PP2\Week 2\Task 2\Task 2\out.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(prime);
            string s = sr.ReadLine();
            int cnt = 0;
            for(int i = 0; i < s.Length; i++)
            { if(s[i]==' ')
                {
                    cnt++;
                }

            }
            string[] n = s.Split(' ');
            for(int i = 0; i < cnt + 1; i++)
            {
                bool m = true;
                int a = int.Parse(n[i]);
                for (int j = 2; j < a; j++)
                {
                    if (a % j == 0)
                    {
                        m = false;

                    }
                }
                if(a!=1 && m == true)
                {
                    sw.Write(a + " ");
                    Console.Write(a + " ");

                }
            }
            sr.Close();
            number.Close();
            sw.Close();
            prime.Close();
        }
    }
}

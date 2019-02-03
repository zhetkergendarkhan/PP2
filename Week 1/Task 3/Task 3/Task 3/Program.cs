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
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            string[] s = Console.ReadLine().Split();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} {0} ", arr[i]);
            }
            Console.ReadKey();
        }
       
    }
}

Using System;



namespace Task 1


{

    class Program

    {

        // Создаём функцию для проверки, является ли число простым или нет

        static bool Prime(int k)

        {

            if (k == 1) return false;

            for (int i = 2; i <= k; i++)

            {

                if (k % i == 0)
                    return false;

            }

            return true;

        }



        static void Main(string[] args)

        {



            int n = int.Parse(Console.ReadLine()); // Ввод 



            string[] s = Console.ReadLine().Split(); // Ввод чисел  и разделение чисел через пробел



            int[] arr = new int[n]; // Создание числового массива 



            int cnt = 0; // Создание счетчика для простых чисел



            int[] arrPrime = new int[n]; // Создание массива для простых чисел



            for (int i = 0; i < arr.Length; i++) // Преобразование строчного массива в числовой

            {

                arr[i] = int.Parse(s[i]);

            }



            int it = 0; // Создание it в роли итератора по массиву c простыми числами arrPrime



            for (int i = 0; i < n; i++) // Проверка для простых чисел из первого массива arr и добавление их в массив для простых чисел arrPrime

            {

                if (Prime(arr[i]) == true)

                {

                    arrPrime[it] = arr[i];

                    cnt++;

                    it++;

                }

            }



            Console.WriteLine(cnt); // Вывод размера простых чисел



            for (int i = 0; i < cnt; i++) // Вывод чисел массива для простых чисел arrPrime

            {

                Console.Write(arrPrime[i] + " ");

            }



            Console.ReadLine();



        }



    }

}

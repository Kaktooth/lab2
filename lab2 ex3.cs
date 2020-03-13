using System;
namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину масиву");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть цифри масиву");
            int[] array = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            array = ClearArray(array, n);
            count=CountArray(array, count, n);
            array = Sorting(array, n);
            Console.WriteLine();
            Array.Resize(ref array, count);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" " + array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("довжина масиву" + array.Length);
        }
        static int[] ClearArray(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Array.Clear(array, i, 1);

                }
            }
            return array;
        }
        static int CountArray(int[] array, int count, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Array.Clear(array, i, 1);
                    count++;
                }
            }
            return count;
        }
        static int[] Sorting(int[] array, int n)
        {
            for (int j = 0; j < n; j++)

            {

                for (int i = j + 1; i < n; i++)

                {

                    if (array[j] == 0)

                    {
                        int a;
                        a = array[i];
                        array[i] = array[j];
                        array[j] = a;
                    }
                }
            }
            return array;
        }
    }

}
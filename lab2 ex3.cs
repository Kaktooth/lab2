using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int count = 0;

            for (int i = 0; i < n; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < n; i++)
            {

                if (array[i] % 2 == 0)
                {
                    Array.Clear(array, i, 1);
                    count++;
                }
            }

            for (int j = 0; j < n; j++)
            {
                for (int i= j + 1; i < n; i++)
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
            Console.WriteLine();
            Array.Resize(ref array, count);
            for (int i = 0; i <array.Length; i++)
            {
                    Console.Write(" "+array[i]);
            }

        }
    }
}

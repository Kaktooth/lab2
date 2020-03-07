using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)

        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            

            for (int i = 0; i < n; i++)
            {
                
                    array[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < n; i++)
            {
               
                    if (array[i] % 2 != 0)
                    {
                    Array.Clear(array,i,1);

                    }
                    Console.WriteLine(array[i]);
                


            }

        }
    }
}

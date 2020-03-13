using System;
using System.Diagnostics;
namespace ConsoleApp21

{

    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть довжину масиву");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] array = new int[n, m];
            int[][] arr = new int[n][];
            Console.Write("Видалити рядки починаючи з ");
            int k1 = int.Parse(Console.ReadLine());
            Console.Write(" рядка до ");
            int k2 = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                    arr[i] = new int[m];
                }
            }

         
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)

                {
                    arr[i][j] = array[i, j];
                }
            }
            count = k2 - k1+1;
            Array.Clear(arr, k1-1, count);
         
            for (int j = 0; j < n; j++)

            {

                for (int i = j + 1; i < n; i++)

                {

                    if (arr[j] == null)

                    {

                        int[] a = new int[n];

                        a = arr[i];

                        arr[i] = arr[j];

                        arr[j] = a;

                    }

                }

            }
          
            Console.WriteLine();

            Array.Resize(ref arr, count);

            for (int i = 0; i < n-count; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write(" " + arr[i][j]);
                }
            }
           
            Console.WriteLine();
            Console.WriteLine("елементів масиву {0}", n-count);
            Console.WriteLine("довжина масиву " + m); 
           
        }

    }

}
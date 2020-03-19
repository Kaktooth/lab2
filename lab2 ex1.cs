using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        
       {     int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int[] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i] = 1;
                    array[i, j] = int.Parse(Console.ReadLine());
                 
                }
            }
            for (int j= 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    arr[j] *= array[i, j];
                }
                if (arr[j] != 0)
                {
                    
                    Console.WriteLine("В {0} стопчику добуток дорівнює {1}", j + 1, arr[j]);
                }
               
            }
           
        }
    }
}

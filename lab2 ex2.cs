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
                    array[i, j] = int.Parse(Console.ReadLine());
                 
                }
            }
            for (int j= 0; j < n; j++)
            {
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    Console.Write(array[i,j]);
                }
              
            
            }
           
        }
    }
}

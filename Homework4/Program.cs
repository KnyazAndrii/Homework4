using System;

namespace Homework4
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] arr = CreateArray();
            Console.WriteLine("Task 1: " + FindMinElement(arr));
            Console.WriteLine("Task 2: " + FindMaxElement(arr));
            Console.WriteLine("Task 3: " + FindMinIndex(arr));
            Console.WriteLine("Task 4: " + FindMaxIndex(arr));
            Console.WriteLine("Task 5: " + CalcSumOddElements(arr));
            Console.Write("Task 6: ");
            foreach (int n in ReverseArray(arr))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Task 7: " + CountOddElements(arr));
            Console.Write("Task 8: ");
            foreach (int n in SwapHalfs(arr))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.Write("Task 9: ");
            foreach (int n in SortSelection(arr))
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.Write("Task 10: ");
            foreach (int n in SortDescend(arr))
            {
                Console.Write(n + " ");
            }     
        }
    }
}

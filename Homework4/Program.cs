using System;

namespace Homework4
{
    class Program
    {
        private static int[] CreateArray()
        {
            int size = 11;
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 100);
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            return array;
        }

        static int FindMinElement(int[] arr)
        {
            int minI = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minI])
                {
                    minI = i;
                }
            }

            return arr[minI];
        }

        static int FindMaxElement(int[] arr)
        {
            int maxI = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxI])
                {
                    maxI = i;
                }
            }

            return arr[maxI];
        }

        static int FindMinIndex(int[] arr)
        {
            int minI = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[minI])
                {
                    minI = i;
                }
            }

            return minI;
        }

        static int FindMaxIndex(int[] arr)
        {
            int maxI = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxI])
                {
                    maxI = i;
                }
            }

            return maxI;
        }

        static int CalcSumOddElements(int[] arr)
        {
            int sum = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += arr[i];
                }
            }

            return sum;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int[] ReverseArray(int[] arr)
        {
            int lastIndex = arr.Length - 1;

            for (int i = 0; i < (arr.Length / 2); i++)
            {
                Swap(ref arr[i], ref arr[lastIndex]);
                lastIndex--;
            }

            return arr;
        }

        static int CountOddElements(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count += arr[i];
                }
            }

            return count;
        }

        static int[] SwapHalfs(int[] arr)
        {
            int middle = arr.Length / 2;
            int startLastHalf = arr.Length - middle;

            for (int i = 0; i < middle; i++)
            {
                Swap(ref arr[i], ref arr[startLastHalf]);
                startLastHalf++;
            }

            return arr;
        }

        static int[] SortSelection(int[] arr)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                int smallestVal = j;
                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (arr[i] < arr[smallestVal])
                    {
                        smallestVal = i;
                    }
                }
                int temp = arr[smallestVal];
                arr[smallestVal] = arr[j];
                arr[j] = temp;
            }
            return arr;
        }

        static int[] SortDescend(int[] arr)
        {
            int temp;

            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            return arr;
        }

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

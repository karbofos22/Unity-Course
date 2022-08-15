using System;

namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = CreateArray();
            Console.WriteLine("Original array:");
            PrintArray(testArray);
            BubbleSort(testArray);
            Console.WriteLine("\nSorted array:");
            PrintArray(testArray);
        }
        static int[] CreateArray()
        {
            Random random = new Random();
            int[] array = new int[100];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1001);
            }
            return array;
        }
        static void PrintArray(int[] array)

        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Array item {i} value: {array[i]}");
            }
        }
        static int[] BubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}

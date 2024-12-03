using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time watch = new Time();
            int[] array = GenerateRandomArray(100000, 1, 1000000);
            watch.Start();
            SelectionSort(array);
            watch.Stop();

            Console.WriteLine("Execution time: {0}ms", watch.GetElapsedTime());
            Console.ReadLine();
        }

        static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }
            return array;
        }

        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Tìm phần tử nhỏ nhất trong mảng chưa sắp xếp
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Hoán đổi phần tử nhỏ nhất với phần tử đầu tiên
                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}

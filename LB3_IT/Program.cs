using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину масссива:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random rand = new();
            Console.WriteLine("Изначальный массив, Z(N):");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            List<int> numbers = new();
            if (array[0] != 0)
            {
                numbers.Add(array[0]);
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] * array[i + 1] < 0)
                {
                    numbers.Add(array[i + 1]);
                }
                else if (array[i] == 0 && array[i + 1] * numbers[numbers.Count - 1] < 0)
                {
                    numbers.Add(array[i + 1]);
                }
            }
            array = numbers.ToArray();

            Console.WriteLine("Знакочередующаяся последовательность:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
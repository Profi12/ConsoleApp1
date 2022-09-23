using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        static void Main(string[] args)
        {
            int size = 10;
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 10);
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                array[i] *= 2;
            }

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            MoveZerosToBeginning(array);

            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        private static void MoveZerosToBeginning(int[] array)
        {
            int position = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    Swap (ref array[i], ref array[position++]);
                }
            }
        }

        private static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}

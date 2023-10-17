using System;

namespace _2D_Array213036
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 99 } };
            foreach (int i in numbers2D)
            {
                System.Console.WriteLine("{0}", i);
            }
        }
    }
    }


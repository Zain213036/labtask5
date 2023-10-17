using System;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays = { "sun", "mon", "tue", "wed", "thu", "fri", "sat" };
            PrintArray(weekdays);
            ChangeArray(weekdays);
            Console.WriteLine("Array after change");
            PrintArray(weekdays);
            System.Console.WriteLine();
            Changearrayelement(weekdays);
            Console.WriteLine("change element of arrray");
            PrintArray(weekdays);

        }
        private static void Changearrayelement(string[] weekdays)
        {

            weekdays[0] = "sat";
            weekdays[1] = "fri";
            weekdays[2] = "mon";

            Console.WriteLine("array[0] is {0} in ChangearrayElement", weekdays[0]);
        }

        private static void ChangeArray(string[] weekdays)
        {

            weekdays = (weekdays.Reverse()).ToArray();
            Console.WriteLine("array[0] is {0} in Changearray", weekdays[0]);

        }

        private static void PrintArray(string[] weekdays)
        {

            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.Write(weekdays[i] + "{0}", i < weekdays.Length - 1 ? " " : "");
            }
            Console.WriteLine();
        }
    }
 

}

using System.Globalization;

namespace Assignment_10._2._1_Creating_a_LINQ_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, -1, 3, -3, 10, -200 };

            var numQuery =
                from num in array
                where num > 0
                select num;

            Console.Write("Positive numbers in query:");

            foreach (int num in numQuery)
            {
                Console.Write( " " + num);
            }
        }
    }

}

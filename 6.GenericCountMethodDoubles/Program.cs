using System;
using System.Collections.Generic;

namespace _6.GenericCountMethodDoubles
{
    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var value = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(value);
                boxes.Add(box);
            }

            var valueToCompare = double.Parse(Console.ReadLine());
            Console.WriteLine(CountCompare(boxes, valueToCompare));
        }

        public static int CountCompare<T>(IEnumerable<Box<T>> collection, T item)
            where T : IComparable<T>
        {
            int count = 0;

            foreach (var box in collection)
            {
                if (box.CompareTo(item) > 0)
                {
                    count++;
                }
            }

            return count;

        }
    }
}

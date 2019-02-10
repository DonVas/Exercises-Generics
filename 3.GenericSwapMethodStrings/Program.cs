using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.GenericSwapMethodStrings
{
    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Box<string>> boxes=new List<Box<string>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var value =Console.ReadLine();
                Box<string> box = new Box<string>(value);

                boxes.Add(box);
            }

            int[] indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            Swap(boxes,indexes[0],indexes[1]);

            boxes.ForEach(Console.WriteLine);
        }

         public static void Swap<T>(List<Box<T>> list, int index1, int index2)
        {
            Box<T> temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}

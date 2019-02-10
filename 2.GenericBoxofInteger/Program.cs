using System;

namespace _2.GenericBoxofInteger
{
    public class Program
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                int value = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(value);

                Console.WriteLine(box);
            }
        }
    }
}

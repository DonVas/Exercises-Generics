using System;

namespace _7.Tuple
{
    public class Program
    {
        public static void Main()
        {
            string[] lineOne = Console.ReadLine()
                .Split();
            string name = lineOne[0] + " " + lineOne[1];
            string addres = lineOne[2];

            Tuple<string,string> tupleOne = new Tuple<string, string>(name,addres);

            string[] lineTwo = Console.ReadLine()
                .Split();

            Tuple<string, int> tupleTwo= new Tuple<string, int>(lineTwo[0], int.Parse(lineTwo[1]));

            string[] lineTree = Console.ReadLine()
                .Split();

            Tuple<int,double> tupleTree=new Tuple<int, double>(int.Parse(lineTree[0]),double.Parse(lineTree[1]));
            Console.WriteLine(tupleOne);
            Console.WriteLine(tupleTwo);
            Console.WriteLine(tupleTree);
        }
    }
}

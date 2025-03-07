using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alan Ryan");
            if (args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));
            }

        }
    }
}
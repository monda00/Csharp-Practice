using System;

namespace Sample301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力：");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("zero");
            }
            else if (a == 1)
            {
                Console.WriteLine("one");
            }
            else
            {
                Console.WriteLine("other");
            }

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("one or two or three");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("four or five");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}

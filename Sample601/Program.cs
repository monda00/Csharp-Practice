using System;

namespace Sample601
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            person = new Person();
            person.SetAgeAndName("taro", 24);
            person.ShowAgeAndName();

            Calc calc = new Calc();
            int a = 1, b = 2, c = 3;
            Console.WriteLine(calc.Add(a, b));
            Console.WriteLine(calc.Add(a, b, c));
        }
    }
}

using System;

namespace SampleEX301
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub sub1 = new Sub();
            Sub sub2 = new Sub(100);

            Super su1 = new Super();
            Super su2 = new Sub();
            su1.Foo();
            su2.Foo();
        }
    }
}

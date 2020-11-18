using System;

namespace SampleEX301
{
    class Sub : Super
    {
        public Sub()
        {
            Console.WriteLine("Sub class constructor");
        }

        public Sub(int param) : base(param)
        {
            Console.WriteLine("Sub class constructor param={0}", param);
        }

        public override void Foo()
        {
            Console.WriteLine("Sub Foo");
        }

        ~Sub()
        {
            Console.WriteLine("Sub class destructor");
        }
    }
}

using System;

namespace SampleEX301
{
    class Super
    {
        private int param = 0;

        public Super()
        {
            Console.WriteLine("Super class constructor");
        }

        public Super(int param)
        {
            Console.WriteLine("Super class constructor param={0}", param);
            this.param = param;
        }

        public virtual void Foo()
        {
            Console.WriteLine("Super Foo");
        }

        ~Super()
        {
            Console.WriteLine("Super class destructor");
        }
    }
}

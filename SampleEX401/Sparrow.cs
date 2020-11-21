using System;

namespace SampleEX401
{
    public class Sparrow : Bird
    {
        public Sparrow() : base("すずめ")
        {
        }

        public override void Sing()
        {
            Console.WriteLine("ちゅんちゅん");
        }

        public override string hoge
        {
            set;
            get;
        }
    }
}
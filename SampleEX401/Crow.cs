using System;

namespace SampleEX401
{
    public class Crow : Bird
    {
        public Crow() : base("カラス")
        {
        }

        public override void Sing()
        {
            Console.WriteLine("カーカー");
        }
    }
}
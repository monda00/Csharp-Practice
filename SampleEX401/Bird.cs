using System;

namespace SampleEX401
{
    abstract class Bird
    {
        private String name;

        public Bird(String name)
        {
            this.name = name;
        }

        public String Name
        {
            get { return name; }
        }

        public abstract void Sing();

        public abstract string hoge
        {
            set;
            get;
        }
    }
}
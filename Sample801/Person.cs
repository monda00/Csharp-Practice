using System;

namespace Sample801
{
    class Person
    {
        public Person() : this("名無し", 0)
        {
            Console.WriteLine("no param");
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowAgeAndName()
        {
            Console.WriteLine("name: {0}, age: {1}", Name, Age);
        }

        public void SetAgeAndName(string name, int age)
        {
            Name = name;
            Age = age;
        }

        ~Person()
        {
            Console.WriteLine("デストラクタ");
        }

        public string Name
        {
            // クラス内でしかsetできない
            private set; get;
        }

        public int Age
        {
            set; get;
        }
    }
}

using System;

namespace Sample701
{
    class Person2
    {
        public void ShowAgeAndName()
        {
            Console.WriteLine("name: {0}, age: {1}", Name, Age);
        }

        public void SetAgeAndName(string name, int age)
        {
            Name = name;
            Age = age;
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

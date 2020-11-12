using System;

namespace Sample701
{
    class Person
    {
        private string name = "";
        private int age = 0;

        public void ShowAgeAndName()
        {
            Console.WriteLine("name: {0}, age: {1}", name, age);
        }

        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Age
        {
            set { age = value; }
            get { return age; }
        }
    }
}

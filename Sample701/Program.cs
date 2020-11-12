using System;

namespace Sample701
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "taro";
            person.Age = 25;
            person.ShowAgeAndName();

            Person2 person2 = new Person2();
            person2.SetAgeAndName("jiro", 24);
            person2.Age = 23;
            person2.ShowAgeAndName();
        }
    }
}

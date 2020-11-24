using System;
using System.Collections.Generic;

namespace SampleEX601
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(3);
            a.Add(2);
            a.Add(1);
            a.Insert(1, 4);
            for (int i = 0; i < a.Count; i += 1)
            {
                Console.WriteLine("a[{0}] = {1}", i, a[i]);
            }

            List<String> s = new List<String>();
            s.Add("tom");
            s.Add("john");
            s.Add("taro");
            s.Add("jiro");
            s.Remove("taro");
            s.RemoveAt(1);
            foreach (String st in s)
            {
                Console.WriteLine(st);
            }

            Dictionary<string, string> capital = new Dictionary<string, string>();
            capital["japan"] = "tokyo";
            capital["england"] = "rondon";
            capital["france"] = "paris";
            foreach (string c in capital.Keys)
            {
                Console.WriteLine("{0}'s capital is {1}", c, capital[c]);
            }

            HashSet<int> t = new HashSet<int>();
            t.Add(1);
            t.Add(2);
            t.Add(3);
            t.Add(1);
            foreach (int hs in t)
            {
                Console.WriteLine(hs);
            }
        }
    }
}

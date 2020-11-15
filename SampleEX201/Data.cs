using System;

namespace SampleEX201
{
    class Data
    {
        private static int num = 0;
        private int id;

        public Data(int id)
        {
            this.id = id;
            num += 1;
            Console.WriteLine("id: {0} num: {1]", this.id, num);
        }

        public static void ShowNumber()
        {
            Console.WriteLine("dat object num: {0}", num);
        }

    }
}

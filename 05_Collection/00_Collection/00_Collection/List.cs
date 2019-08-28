using System;
using System.Collections.Generic;
using System.Text;

namespace _00_Collection
{
    class List
    {
        public static void Main()
        {
            List<Dictionary<int, string>> c6 = new List<Dictionary<int, string>>();

            var to1 = new Dictionary<int, string>();
            to1.Add(1, "khoa nguyen");
            to1.Add(2, "bao nguyen");
            c6.Add(to1);

            var to2 = new Dictionary<int, string>();
            to2.Add(11, "ha nguyen");
            to2.Add(12, "nam nguyen");
            c6.Add(to2);

            foreach (var to in c6)
            {
                foreach (var member in to)
                {
                    Console.WriteLine("id: {0}, name: {1}", member.Key, member.Value);
                }
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _00_Collection
{
    class LinkedList
    {
        public static void Main()
        {
            LinkedList<string> relationship = new LinkedList<string>();

            var a = relationship.AddFirst("khoa");
            relationship.AddAfter(a, "bao");
            relationship.AddLast("tu");
            relationship.AddFirst("ha");
            var findBao = relationship.Find("bao");
            relationship.AddAfter(findBao, "Loc");
            foreach (var item in relationship)
            {
                Console.WriteLine("item: {0}", item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _00_Collection
{
    class Stack_Queue
    {
        public static void Main()
        {
            Stack<int> money = new Stack<int>();
            money.Push(500);
            money.Push(200);
            money.Push(100);

            foreach (var item in money)
            {
                Console.WriteLine("item: {0}", item);
            }

            Console.WriteLine("item on top: {0}", money.Peek());
            Console.WriteLine("----------------------------");

            Queue<string> task = new Queue<string>();
            task.Enqueue("build PJ structor");
            task.Enqueue("tasks separater");
            task.Enqueue("Assign task");

            foreach (var item in task)
            {
                Console.WriteLine("item: {0}", item);
            }
            Console.WriteLine("item on top: {0}", task.Peek());
        }
    }
}

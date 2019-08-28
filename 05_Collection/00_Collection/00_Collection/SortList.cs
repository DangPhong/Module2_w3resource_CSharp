using System;
using System.Collections.Generic;
using System.Text;

namespace _00_Collection
{
    public class SortList
    {
        public static void Main()
        {
            SortedList<string, string> EmployeeList = new SortedList<string, string>();
           // Dictionary<string, string> EmployeeList2 = new Dictionary<string, string>();
            EmployeeList.Add("Khoa", "co tuong");
            EmployeeList.Add("Loc", "co vua");
            EmployeeList.Add("Bao", "kara");
            //EmployeeList.Add("Bao", "karaoke");

            //show all by value
            Console.WriteLine("show all values");
            foreach (var item in EmployeeList.Values)
            {
                Console.WriteLine(item);
            }


            //show all by keys
            Console.WriteLine("show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine(key);
            }

            //show all values by keys
            Console.WriteLine("show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("key: {0} - value: {1}", key, EmployeeList[key]);
            }

            ////remove iteam 

            //string locValue;
            //EmployeeList.Remove("khoa");

            ////show all values by keys
            //Console.WriteLine("show all keys");
            //foreach (var key in EmployeeList.Keys)
            //{
            //    Console.WriteLine("key: {0} - value: {1}", key, EmployeeList[key]);
            //}


            ////remove item by key and return value
            //EmployeeList.Remove("loc", out locValue);
            //Console.WriteLine(locValue);

            ////show all values by keys
            //Console.WriteLine("show all keys");
            //foreach (var key in EmployeeList.Keys)
            //{
            //    Console.WriteLine("key: {0} - value: {1}", key, EmployeeList[key]);
            //}

            ////remove item by index 
            //EmployeeList.RemoveAt(EmployeeList.Count - 1);

            ////show all values by keys
            //Console.WriteLine("show all keys");
            //foreach (var key in EmployeeList.Keys)
            //{
            //    Console.WriteLine("key: {0} - value: {1}", key, EmployeeList[key]);
            //}


            // show all value by using enumnator 
            var enumrator = EmployeeList.GetEnumerator();

            Console.WriteLine("----------------");
            while (enumrator.MoveNext())
            {
                Console.WriteLine("Key: {0} - Value: {1}", enumrator.Current.Key , enumrator.Current.Value);
            }
        }
    }
}

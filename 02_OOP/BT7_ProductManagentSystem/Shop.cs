using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace BT7_ProductManagentSystem
{
    public class Shop
    {

        ArrayList productList = new ArrayList();
        public void AddProduct()
        {
            Console.Write("input name: ");
            string name = Console.ReadLine();
            Console.Write("input price: ");
            int price = int.Parse(Console.ReadLine());
            Console.Write("input decription: ");
            string description = Console.ReadLine();
            int[] rate = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("input rate {0}: ", i + 1);
                rate[i] = int.Parse(Console.ReadLine());
            }


            Product product = new Product()
            {
                Name = name,
                Price = price,
                Description = description,
                Rate = rate
            };
            productList.Add(product);
        }

        public void Display()
        {
            foreach (Product product in productList)
            {
                product.ViewInfo();
            }
        }
        public void RemoveProduct()
        {
            Console.Write("input name to remove: ");
            string name = Console.ReadLine();
            foreach (Product product in productList)
            {
                if (product.Name == name)
                {
                    productList.Remove(product);
                    break;
                }
            }
        }
        public void Swap(ref float a, ref float b)
        {
            float temp = a;
            a = b;
            b = temp;
        }

        public void SearchProduct()
        {
            Console.Write("input fisrt: ");
            float first = float.Parse(Console.ReadLine());
            Console.Write("input last: ");
            float last = float.Parse(Console.ReadLine());

            if (first > last)
            {
                Swap(ref first, ref last);
            }
            foreach (Product product in productList)
            {
                if (first < product.Price && product.Price < last && first < last)
                {
                    product.ViewInfo();
                }
            }
        }
    }
}

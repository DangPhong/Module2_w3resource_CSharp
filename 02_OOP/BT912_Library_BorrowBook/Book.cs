using System;
using System.Collections.Generic;
using System.Text;

namespace BT912_Library_BorrowBook
{
    class Book
    {
        private int amountBook, amountDayBorrow;
        private string typeBook, dayBorrow;
        private float rate;
        string[] arrTypeBook = { "1. Chuyen Nganh \t\t 5", "2. Van Hoc \t\t 3", "3. Tham khao \t\t 4", "Loai khac \t\t 6" };

        public int AmountBook
        {
            get => amountBook; set
            {
                if (amountBook > 0)
                {
                    amountBook = value;
                }
                else
                {
                    Console.WriteLine("so luong sach muon phải >0");
                }
            }
        }
        public int AmountDayBorrow
        {
            get => amountDayBorrow; set
            {
                if (amountDayBorrow > 0 && amountDayBorrow < 30)
                {
                    amountDayBorrow = value;
                }
                else
                {
                    Console.WriteLine("So ngay muon sach phai >0");
                }
            }
        }
        public string TypeBook { get => typeBook; set => typeBook = value; }
        public string DayBorrow { get => dayBorrow; set => dayBorrow = value; }
        public float Rate { get => rate; set => rate = value; }
        public string[] ArrTypeBook { get => arrTypeBook; set => arrTypeBook = value; }


        public float CalculateAmount()
        {
            return (amountBook * (Rate / 100) * AmountDayBorrow * 10);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Chi tiet muon sach: ");
            Console.WriteLine("----------------------");
            Console.WriteLine("So luong: {0}", AmountBook);
            Console.WriteLine("Loai sach: {0}", TypeBook);
            Console.WriteLine("Tong so tien phai tra: {0}", CalculateAmount());
        }
    }
}

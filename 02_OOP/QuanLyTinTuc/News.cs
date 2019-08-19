using System;

namespace QuanLyTinTuc
{
    public class News : INew
    {
        private int id;
        private string title, publicDate, author, content;
        private float averageRate;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Title
        {
            get => title;
            set => title = value;
        }

        public string PublicDate
        {
            get => publicDate;
            set => publicDate = value;
        }

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Content
        {
            get => content;
            set => content = value;
        }

        public float AverageRate
        {
            get => averageRate;
            //set => averageRate = value;
        }

        public News()
        {

        }

        public void Display()
        {
            Console.WriteLine("Tieu de: " + Title);
            Console.WriteLine("Ngay xuat ban" + PublicDate);
            Console.WriteLine("Tac gia: " + Author);
            Console.WriteLine("The loai: " + Content);
            Console.WriteLine("Diem trung binh: " + AverageRate);
        }

        private int[] rateList = new int[3];

        public int[] RateList
        {
            get => rateList;
            set => rateList = value;
        }

        public void Caculate()
        {
            int length = RateList.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += RateList[i];
            }

            averageRate = sum / length;
            Console.WriteLine("Danh gia trung binh: " + averageRate);
        }
    }
}
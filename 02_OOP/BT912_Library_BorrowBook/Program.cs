using System;

namespace BT912_Library_BorrowBook
{

    #region http://giasutinhoc.vn/lap-trinh/lap-trinh-c-sharp/xu-ly-ngoai-le-trong-c-bai-9-2/
    #endregion
    class Program
    {
        public static Student student = new Student();
        public static Book book = new Book();
        public static void InputInfor()
        {
            Console.WriteLine("nhap ten: ");
            student.StudentName = Console.ReadLine();
            Console.WriteLine("nhap tuoi: ");
            student.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gioi tinh (nam/nu): ");
            student.Gender = Console.ReadLine();
            Console.WriteLine("nhap thanh pho: ");
            student.City = Console.ReadLine();
            Console.WriteLine("Danh sach cac loai sach: ");
            for (int i = 0; i < book.ArrTypeBook.Length ; i++)
            {
                Console.WriteLine(book.ArrTypeBook[i]);
            }
        }
        static void Main(string[] args)
        {
            InputInfor();
            //Console.WriteLine("Hello World!");
        }
    }
}

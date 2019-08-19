using System;

namespace QuanLySV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thong tin 2 sv: ");
            SinhVien[] sv = new SinhVien[3];
            for (int i = 1; i < 3; i++)
            {
                Console.Write("Ho ten sv thu "+i+":  ");
                string name = Console.ReadLine();
                Console.Write("Ma sv: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Diem LT: ");
                float lt = float.Parse(Console.ReadLine());
                Console.Write("Diem TH: ");
                float th = float.Parse(Console.ReadLine());
                sv[i] = new SinhVien(id, name, lt, th);
            }

            Console.WriteLine("\tHoTen\tMaSV\tDiemLT\tDiemTH\tDiemTB");
            for (int i = 1; i < 3; i++)
            {
                Console.Write("\t" + sv[i].Name);
                Console.Write("\t" + sv[i].Id);
                Console.Write("\t" + sv[i].PointTheory);
                Console.Write("\t" + sv[i].PointLab);
                Console.Write("\t"+sv[i].getAverageScore());
                Console.WriteLine();
              //  
            }
            
        }
    }
}
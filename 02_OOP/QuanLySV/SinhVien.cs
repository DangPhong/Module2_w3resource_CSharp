using System;

namespace QuanLySV
{
    public class SinhVien
    {
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public float PointTheory
        {
            get => pointTheory;
            set => pointTheory = value;
        }

        public float PointLab
        {
            get => pointLab;
            set => pointLab = value;
        }

        private int id;
        private string name;
        private float pointTheory, pointLab;

        public SinhVien()
        {
        }

        public SinhVien(int id, string name, float pointTheory, float pointLab)
        {
            this.id = id;
            this.name = name;
            this.pointTheory = pointTheory;
            this.pointLab = pointLab;
        }

        public float getAverageScore()
        {
            float dtb = (PointLab + PointTheory) / 2;
         //   Console.WriteLine(dtb);
            return dtb;
        }

        public void display()
        {
            Console.WriteLine("Ho va ten: " + Name);
            Console.WriteLine("Ma SV: " + Id);
            Console.WriteLine("Diem Trung Binh", +getAverageScore());
        }
    }
}
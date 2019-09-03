using System;
using System.Collections.Generic;
using System.Text;

namespace BT912_Library_BorrowBook
{
    class Student
    {
        private int studentID, age;
        private string studentName, gender, city;

        public int StudentID { get => studentID; set => studentID = value; }
        public int Age
        {
            get => age;
            set
            {
                if (age >= 18)
                {
                    age = value;
                }
                else { Console.WriteLine("tuoi phai >18"); }
            }
        }
        public string StudentName
        {
            get => studentName;
            set
            {
                if (6 < studentName.Length && studentName.Length < 40)
                {
                    studentName = value;
                }
                else
                {
                    Console.WriteLine("phai co do dai 6-40 ky tu");
                }
            }
        }
        public string Gender
        {
            get => gender;
            set
            {
                do
                {
                    gender = value;
                } while (gender == "nam" || gender == "nu");
            }
        }
        public string City
        {
            get => city; set
            {
                if (4 < city.Length && city.Length < 40)
                {
                    city = value;
                }
                else
                {
                    Console.WriteLine("phai co do dai 4-40 ky tu");
                }
            }
        }

        public string DisplayInfoStudent()
        {
            return $"Ma SV: {StudentID} \t\t Ten SV: {StudentName} \t\t " +
                $"Tuoi: {Age} \t\t Gioi tinh: {Gender} \t\t Thanh pho: {City}";
        }
    }
}

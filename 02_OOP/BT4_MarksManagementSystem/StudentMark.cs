using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using MarksManagementSystem.Models;

namespace MarksManagementSystem
{
    class StudentMark : IStudentMark
    {
        private string fullname, class1;
        // semester: hoc ki
        private int id, semester;
        private float averageMark;
        private int[] subjectMarkList = new int[5];


        public string Fullname { get => fullname; set => fullname = value; }
        public string Class { get => class1; set => class1 = value; }
        public int Id { get => id; set => id = value; }
        public int Semester { get => semester; set => semester = value; }
        public float AverageMark { get => averageMark; }
        public int[] SubjectMarkList { get => subjectMarkList; set => subjectMarkList = value; }

        public string Display()
        {
            return $"ID: {Id}, Fullname: {Fullname}, Class: {Class}, Semester: {Semester}, AverageRate: {AverageMark}";
        }

        public void AveCal()
        {
            int length = SubjectMarkList.Length;
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                sum += SubjectMarkList[i];
            }
            averageMark = sum / length;
            Console.WriteLine("average marks: {0}", averageMark);
        }

        //public void Insert()
        //{
        //    AveCal();
        //    StudentItem studentItem = new StudentItem()
        //    {
        //        ID = Id,
        //        Fullname = Fullname,
        //        Class = Class,
        //        Semester = Semester,
        //        AverageMark = AverageMark
        //    };
        //    arrStudent.Add(studentItem);
        //}
    }
}

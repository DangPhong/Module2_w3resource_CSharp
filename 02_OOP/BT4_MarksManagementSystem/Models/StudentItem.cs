using System;
using System.Collections.Generic;
using System.Text;

namespace MarksManagementSystem.Models
{
    class StudentItem
    {
        public string Fullname { get; set; }
        public int ID { get; set; }
        public string Class { get; set; }
        public int Semester { get; set; }
        public float AverageMark { get; set; }
    }
}

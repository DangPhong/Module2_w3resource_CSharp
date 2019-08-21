using System;
using System.Collections.Generic;
using System.Text;

namespace BT5_StudentManagementSystem
{
    class Student : IStudent
    {
        private string fullName, dateOfBirth, native, className, phoneNo;
        private int id, mobile;

        public string FullName { get => fullName; set => fullName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Native { get => native; set => native = value; }
        public string ClassName { get => className; set => className = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public int Id { get => id; set => id = value; }
        public int Mobile { get => mobile; set => mobile = value; }

        public string Display()
        {
            return $"ID: {Id}, Fullname: {FullName}, Date of birth {DateOfBirth}," +
                $" Native {Native}, Class {ClassName} , PhoneNo {PhoneNo}, Mobile {Mobile}";
        }
    }
}

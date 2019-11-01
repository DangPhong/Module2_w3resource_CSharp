using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ABCEnglishCenter.Models.Domain.Response
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string LanguageName { get; set; }
        public string LevelName { get; set; }
        [Display(Name ="Gender")]
        public string GenderStr => Gender ? "Nữ" : "Nam";
    }
}

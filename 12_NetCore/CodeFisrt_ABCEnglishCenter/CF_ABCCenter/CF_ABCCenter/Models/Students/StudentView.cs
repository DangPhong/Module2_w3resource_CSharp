using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Students
{
    public class StudentView
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string IMG { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool Sex { get; set; }
        public string Email { get; set; }
        public string LanguageName { get; set; }
        public string LevelName { get; set; }
        [Display(Name = "Sex")]
        public string GenderStr => Sex ? "Fermale" : "Male";
    }
}

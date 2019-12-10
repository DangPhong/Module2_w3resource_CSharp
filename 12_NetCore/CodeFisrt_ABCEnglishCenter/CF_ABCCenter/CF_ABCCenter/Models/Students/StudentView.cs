using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Students
{
    public class StudentView
    {
      
        public int ID { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Image")]
        public string IMG { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool Sex { get; set; }
        public string Email { get; set; }
        [DisplayName("Language")]
        public string LanguageName { get; set; }
        [DisplayName("Level")]
        public string LevelName { get; set; }
        [Display(Name = "Sex")]
        public string GenderStr => Sex ? "Fermale" : "Male";
        public string PhotoPath { get; set; }
    }
}

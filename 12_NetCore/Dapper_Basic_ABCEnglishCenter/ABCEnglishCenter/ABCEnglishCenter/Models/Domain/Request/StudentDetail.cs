using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABCEnglishCenter.Models.Domain.Request
{
    public class StudentDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public string LanguageName { get; set; }
        public string LevelName { get; set; }
        [Display(Name = "Gender")]
        public string GenderStr => Gender ? "Nữ" : "Nam";
    }
}

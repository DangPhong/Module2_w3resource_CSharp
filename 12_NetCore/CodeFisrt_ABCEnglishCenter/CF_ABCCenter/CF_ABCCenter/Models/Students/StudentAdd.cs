using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Students
{
    public class StudentAdd
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string IMG { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool Sex { get; set; }
        public string Email { get; set; }
        public int LanguageId { get; set; }
        public int LevelId { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ABCEnglishCenter.Models.Domain.Request
{
    public class StudentCreate
    {
        [Required(ErrorMessage =("aaaaa"))]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        public string Email { get; set; }
        public int LevelID { get; set; }
        public int LanguageID { get; set; }
    }
}

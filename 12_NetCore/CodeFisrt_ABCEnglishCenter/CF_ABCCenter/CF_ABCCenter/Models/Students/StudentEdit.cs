using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Students
{
    public class StudentEdit
    {
        [Key]
        public int StudentId { get; set; }
        [DisplayName("Full name")]
        [Required(ErrorMessage = "Please enter fullname!!!")]
        [StringLength(maximumLength: 100, ErrorMessage = "from 2 to 100 words", MinimumLength = 2)]
        public string Name { get; set; }
        [DisplayName("Image")]
        public string IMG { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        public bool Sex { get; set; }
        [RegularExpression("^[a-z0-9_\\+-]+(\\.[a-z0-9_\\+-]+)*@[a-z0-9-]+(\\.[a-z0-9]+)*\\.([a-z]{2,4})$", ErrorMessage = "Invalid email format.")]
        [Required(ErrorMessage = "Please enter your e-mail address!!"), StringLength(200)]
        public string Email { get; set; }
        [DisplayName("Language")]
        public int LanguageId { get; set; }
        [DisplayName("Level")]
        public int LevelId { get; set; }
    }
}

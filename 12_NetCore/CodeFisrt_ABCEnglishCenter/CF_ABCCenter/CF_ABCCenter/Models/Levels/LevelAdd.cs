using CF_ABCCenter.Models.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Levels
{

    public class LevelAdd
    {
        [Key]
        public int LevelId { get; set; }
        [DisplayName("Level")]
        [Required(ErrorMessage = "Please enter level!!!")]
        [StringLength(maximumLength: 1, ErrorMessage = "from 1 to 2 words", MinimumLength = 1)]
        public string LevelName { get; set; }

    }
}

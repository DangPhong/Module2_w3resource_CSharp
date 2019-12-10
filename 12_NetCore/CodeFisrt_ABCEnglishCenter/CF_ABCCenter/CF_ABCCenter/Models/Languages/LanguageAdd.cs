using CF_ABCCenter.Models.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Languages
{
    
    public class LanguageAdd
    {
       [Key]
        public int LanguageId { get; set; }
        [DisplayName("Language Name")]
        [Required(ErrorMessage = "Please enter language!!!")]
        [StringLength(maximumLength: 20, ErrorMessage = "from 2 to 20 words", MinimumLength = 2)]
        public string LanguageName { get; set; }
    }
}

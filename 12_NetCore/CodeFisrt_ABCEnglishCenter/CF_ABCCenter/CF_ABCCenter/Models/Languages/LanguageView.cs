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
    
    public class LanguageView
    {
       [Key]
        public int LanguageId { get; set; }
        [DisplayName("Language Name")]
        public string LanguageName { get; set; }
    }
}

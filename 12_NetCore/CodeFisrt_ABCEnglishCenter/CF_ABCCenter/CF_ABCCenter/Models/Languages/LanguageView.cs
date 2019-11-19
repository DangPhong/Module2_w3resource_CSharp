using CF_ABCCenter.Models.Students;
using System;
using System.Collections.Generic;
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
        public string LanguageName { get; set; }
      
    }
}

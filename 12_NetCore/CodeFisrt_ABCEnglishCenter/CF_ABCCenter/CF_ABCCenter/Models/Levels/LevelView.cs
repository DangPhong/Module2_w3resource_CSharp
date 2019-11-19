using CF_ABCCenter.Models.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Levels
{
   
    public class LevelView
    {
      
        public int LevelId { get; set; }
        public string LevelName { get; set; }
       
    }
}

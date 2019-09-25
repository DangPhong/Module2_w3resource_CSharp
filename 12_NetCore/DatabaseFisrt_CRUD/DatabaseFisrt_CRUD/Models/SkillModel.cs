using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DatabaseFisrt_CRUD.Models
{
    public class SkillModel
    {
        [Key]
        public int Value { get; set; }
        public string Name { get; set; }
    }
}

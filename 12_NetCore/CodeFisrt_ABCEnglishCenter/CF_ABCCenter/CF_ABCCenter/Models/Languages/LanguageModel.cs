using CF_ABCCenter.Models.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Languages
{
    [Table("Languages")]
    public class LanguageModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LanguageId { get; set; }
        [Required]
        [StringLength(100)]
        public string LanguageName { get; set; }
        public bool IsDelete { get; set; } = false;
        public virtual ICollection<StudentModel> Students { get; set; }
    }
}

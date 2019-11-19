using CF_ABCCenter.Models.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Levels
{
    [Table("Levels")]
    public class LevelModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LevelId { get; set; }
        [Required]
        [StringLength(100)]
        public string LevelName { get; set; }
        public bool IsDelete { get; set; } = false;
        public virtual ICollection<StudentModel> Students { get; set; }
    }
}

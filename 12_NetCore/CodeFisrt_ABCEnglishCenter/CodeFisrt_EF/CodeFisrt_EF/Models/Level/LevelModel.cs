using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFisrt_EF.Models.Level
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
        public virtual ICollection<LevelModel> Levels { get; set; }
    }
}

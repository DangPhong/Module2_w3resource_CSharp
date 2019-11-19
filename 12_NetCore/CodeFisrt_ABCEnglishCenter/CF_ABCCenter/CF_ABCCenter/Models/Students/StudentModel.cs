﻿using CF_ABCCenter.Models.Languages;
using CF_ABCCenter.Models.Levels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Models.Students
{
    [Table("Students")]
    public class StudentModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        public string IMG { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        public bool Sex { get; set; }
        [Required]
        public string Email { get; set; }
        public int LanguageId { get; set; }
        public int LevelId { get; set; }
        public bool IsDelete { get; set; } = false;
        //public string GenderStr => Gender ? "Nữ" : "Nam";
        [ForeignKey("LanguageId")]
        public virtual LanguageModel Languages { get; set; }
        [ForeignKey("LevelId")]
        public virtual LevelModel Levels { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagementSystem.Models.Domain.Request
{
    public class BookCreate
    {
        public string Avatar { get; set; }
        [Required(ErrorMessage = "Enter Project Name!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter AuthorName!")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Enter Description!")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Enter Year!")]
        [Range(0, 2019, ErrorMessage = "Year has to be between {1} and {2}")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Enter Number!")]
        public int Number { get; set; }
        public int IDCatelory { get; set; }
    }
}

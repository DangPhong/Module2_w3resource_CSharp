using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookManagementSystem.Models.Domain.Response
{
    public class BookGetAll
    {
        [DisplayName("#ID")]
        public int ID { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Number { get; set; }
        [DisplayName("Catelory")]
        public string CateloryName { get; set; }
    }
}

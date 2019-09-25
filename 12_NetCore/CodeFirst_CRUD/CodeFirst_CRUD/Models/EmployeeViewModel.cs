﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CodeFirst_CRUD.Models
{
    public class EmployeeViewModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string Avatar { get; set; }
        public float Salary { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DatabaseFisrt_CRUD.Models;
namespace DatabaseFisrt_CRUD.Context
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }
        public DbSet<tblSkill> tblSkills { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<DatabaseFisrt_CRUD.Models.EmployeeViewModel> EmployeeViewModel { get; set; }
        public DbSet<DatabaseFisrt_CRUD.Models.EmployeeCreateModel> EmployeeCreateModel { get; set; }
        public DbSet<DatabaseFisrt_CRUD.Models.EmployeeEditModel> EmployeeEditModel { get; set; }
    }
}
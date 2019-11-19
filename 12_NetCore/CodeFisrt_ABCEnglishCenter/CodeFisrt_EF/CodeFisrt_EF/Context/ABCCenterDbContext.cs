using CodeFisrt_EF.Models;
using CodeFisrt_EF.Models.Level;
using CodeFisrt_EF.Models.Student;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFisrt_EF.Context
{
    public class ABCCenterDbContext : DbContext
    {
        public ABCCenterDbContext(DbContextOptions<ABCCenterDbContext> options) : base(options)
        {

        }

        public DbSet<LevelModel> Levels { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<LanguageModel> Languages { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<StudentModel>().HasKey(s => new { s.LanguageId, s.LevelId });
        //}
    }
}

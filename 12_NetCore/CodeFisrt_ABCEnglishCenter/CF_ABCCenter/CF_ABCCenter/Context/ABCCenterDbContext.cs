using CF_ABCCenter.Models.Languages;
using CF_ABCCenter.Models.Levels;
using CF_ABCCenter.Models.Students;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CF_ABCCenter.Context
{
    public class ABCCenterDbContext : DbContext
    {
        public ABCCenterDbContext(DbContextOptions<ABCCenterDbContext> options) : base(options)
        {

        }
        public DbSet<LevelModel> Levels { get; set; }
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<LanguageModel> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LevelModel>().HasData(
             new LevelModel()
             {
                 LevelId = 1,
                 LevelName = "A"
             },
             new LevelModel()
             {
                 LevelId = 2,
                 LevelName = "B"
             });
        }

        public DbSet<CF_ABCCenter.Models.Students.StudentView> StudentView { get; set; }

        public DbSet<CF_ABCCenter.Models.Students.StudentDetail> StudentDetail { get; set; }

        public DbSet<CF_ABCCenter.Models.Students.StudentAdd> StudentAdd { get; set; }

        public DbSet<CF_ABCCenter.Models.Students.StudentEdit> StudentEdit { get; set; }
        // nhieu - nhieu 
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<StudentModel>().HasKey(s => new { s.LanguageId, s.LevelId });
        //}
    }
}

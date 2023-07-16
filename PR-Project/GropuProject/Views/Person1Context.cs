using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GropuProject.Views
{
    public class Person1Context : DbContext
    {
        public DbSet<Module> Modules { get; set; }
        public DbSet<StudentModule> StudentModules { get; set; }
        public DbSet<Person1> Products { get; set; }
        private readonly string _path = @"C:\Users\DELL\Downloads\Telegram Desktop\PR-Project\PR-Project\student.db";

        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data source={_path}");

    }
}

using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GropuProject.Views
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        private readonly string _path = @"C:\Users\DELL\Downloads\Telegram Desktop\PR-Project\PR-Project\student.db";

        protected override void
            OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data source={_path}");

    }
}

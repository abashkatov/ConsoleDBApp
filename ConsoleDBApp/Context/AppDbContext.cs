using ConsoleDBApp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleDBApp.Context
{
    class AppDbContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=db.db");
    }
}

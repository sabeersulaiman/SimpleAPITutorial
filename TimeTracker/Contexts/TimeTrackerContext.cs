using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models;

namespace TimeTracker.Contexts
{
    public class TimeTrackerContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public TimeTrackerContext(DbContextOptions<TimeTrackerContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder md)
        {
            md.Entity<User>().ToTable("Users");
        }
    }
}

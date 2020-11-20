using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCommunicationPlatformAPI.Models
{
    public class SContext: DbContext
    {
        public SContext(DbContextOptions<SContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Scourse> Scourses { get; set; }
    }
}

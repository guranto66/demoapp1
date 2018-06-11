using DemoApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DemoApp1.Data
{
    public class DemoApp1Context : DbContext
    {
        public DemoApp1Context(DbContextOptions<DemoApp1Context> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}

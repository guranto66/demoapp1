using DemoApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DemoApp1.Data
{
    public class MasterContext : DbContext
    {
        public MasterContext(DbContextOptions<MasterContext> options) : base(options)
        {
            

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}

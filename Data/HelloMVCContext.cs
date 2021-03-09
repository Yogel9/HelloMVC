using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HelloMVC.Models;

namespace HelloMVC.Data
{
    public class HelloMVCContext : DbContext
    {
        public HelloMVCContext(DbContextOptions<HelloMVCContext> options)
           : base(options)
        {
        }
        public DbSet<Movie> Movie { get; set; }
    }
}

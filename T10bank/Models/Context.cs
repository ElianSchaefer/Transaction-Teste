using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace T10bank.Models
{
    public class Context : DbContext
    {
        public DbSet<Deal> Deals { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}

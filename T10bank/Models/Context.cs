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

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //    optionsBuilder.UseSqlServer("Server=tcp:t10testesrv020801.database.windows.net,1433;Initial Catalog = test020801; Persist Security Info = False; User ID = T10Tester; Password = BancoDoBanco!; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; ");
        // }
    }
}

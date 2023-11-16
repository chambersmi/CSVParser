using CSVParser.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVParser.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<StarModel> Stars {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=stars.db;Mode=ReadWriteCreate");



            //optionsBuilder.UseSqlServer("Server=.;Database=StarDatabaseDB;TrustServerCertificate=True;Trusted_Connection=True;");
            var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
            //optionsBuilder.UseLoggerFactory(loggerFactory);            
        }
    }
}

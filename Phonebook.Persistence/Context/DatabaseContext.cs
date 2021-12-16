using Microsoft.EntityFrameworkCore;
using Phonebook.Application.Interfaces.Contexts;
using Phonebook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Persistence.Context
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string conncetionString = ConfigurationManager.AppSettings.Get("LocalConnectionString");
            //optionsBuilder.UseSqlServer(conncetionString);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-ABNJIE3\MSSQLSERVER2019; Initial Catalog=CleanContactDb; Integrated Security=true;");
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}

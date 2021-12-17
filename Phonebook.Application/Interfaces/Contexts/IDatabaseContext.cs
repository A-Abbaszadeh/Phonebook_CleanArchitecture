using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Phonebook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Application.Interfaces.Contexts
{
    public interface IDatabaseContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public int SaveChanges();
        public EntityEntry Remove(object entity);
    }
}

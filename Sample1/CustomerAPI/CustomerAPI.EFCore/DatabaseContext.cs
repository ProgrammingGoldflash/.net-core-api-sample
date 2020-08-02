using CustomerAPI.Domain.Interfaces;
using CustomerAPI.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerAPI.EFCore
{
    public class DatabaseContext : DbContext, IUnitOfWork
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }

        public DatabaseContext() : base()
        {

        }
        
        public bool Commit()
        {
            return this.SaveChanges() == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CadastralManagemen_app.Models;

namespace CadastralManagemen_app.DAO
{
    public class EFContext: DbContext
    {
        public EFContext() :base("CadastralDB"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<CadastreObjects> cadastreObjects { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Admin> Admins { get; set; }
}
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadastralManagemen_app.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CadastralManagBD1Entities : DbContext
    {
        public CadastralManagBD1Entities()
            : base("name=CadastralManagBD1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdiminTB> AdiminTB { get; set; }
        public virtual DbSet<CadastreObjectsTB> CadastreObjectsTB { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Engineer> Engineer { get; set; }
        public virtual DbSet<RequestTB> RequestTB { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}

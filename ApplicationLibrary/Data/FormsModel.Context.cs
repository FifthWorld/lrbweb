﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApplicationLibrary.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SolaDbContext : DbContext
    {
        public SolaDbContext()
            : base("name=SolaDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Party> Parties { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
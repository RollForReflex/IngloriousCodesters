﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ViewBoost.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class YouBoostDBEntities : DbContext
    {
        public YouBoostDBEntities()
            : base("name=YouBoostDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Card> Cards { get; set; }
        public DbSet<CheckinTransaction> CheckinTransactions { get; set; }
        public DbSet<DonationTransaction> DonationTransactions { get; set; }
        public DbSet<Donator> Donators { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Type> Types { get; set; }
    }
}

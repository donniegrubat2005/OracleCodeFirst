using OracleCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OracleCodeFirst.Context
{
    public class AppContextdb : DbContext
    
    {
        public AppContextdb() : base("name=AppContextdb") { }

        public DbSet<Vendor> Vendors { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Admin".ToUpper());
        }
    }
}
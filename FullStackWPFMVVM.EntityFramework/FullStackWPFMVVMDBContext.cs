using FullStackWPFMVVM.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackWPFMVVM.EntityFramework
{
    public class FullStackWPFMVVMDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }
        public FullStackWPFMVVMDBContext(DbContextOptions options) : base(options){ }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AssetTransaction>().OwnsOne(a => a.Stock);

            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace FullStackWPFMVVM.EntityFramework
{
    public class FullStackWPFMVVMDBContextFactory : IDesignTimeDbContextFactory<FullStackWPFMVVMDBContext>
    {
        public FullStackWPFMVVMDBContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<FullStackWPFMVVMDBContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=FullStackWPFMVVMDB;Trusted_Connection=True;");
            return new FullStackWPFMVVMDBContext(options.Options);
        }
    }
}

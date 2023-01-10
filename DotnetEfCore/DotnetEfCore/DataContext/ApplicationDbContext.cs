using Microsoft.EntityFrameworkCore;
using System;
using System.Security.Policy;

namespace DotnetEfCore.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        // injection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<CategoryEntity> CategoryEntities => Set<CategoryEntity>();
        public DbSet<AbsensiEntity> AbsensiEntities => Set<AbsensiEntity>();
        public DbSet<EmployeeEntity> EmployeeEntities => Set<EmployeeEntity>();
        public DbSet<InventoryEntity> InventoryEntities => Set<InventoryEntity>();
        public DbSet<LoanInventoryEntity> LoanInventoryEntities => Set<LoanInventoryEntity>();
        public DbSet<MailboxEntity> MailboxEntities => Set<MailboxEntity>();
    }
}


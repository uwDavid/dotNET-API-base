using Microsoft.EntityFrameworkCore;
using NetApiBase.Models;

namespace NetApiBase.Data;

public class AppContext : DbContext
{
    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Expense> Expenses { get; set; }

    public AppContext(DbContextOptions<AppContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

    }
}
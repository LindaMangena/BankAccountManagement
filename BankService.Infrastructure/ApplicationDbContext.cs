
using BankService;
using BankService.Domain;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<AccountHolder> AccountHolders { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<Withdrawal> Withdrawals { get; set; }
    public DbSet<AuditLog> AuditLogs { get; set; }
}

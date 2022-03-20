using Microsoft.EntityFrameworkCore;

public class JobBoxContext : DbContext{
    public DbSet<Account>? Accounts { get; set; }
    public DbSet<Address>? Addresses { get; set; }
    public DbSet<Employeer>? Employeers { get; set; }
    public DbSet<Job>? Jobs { get; set; }
    public DbSet<JobSeeker>? JobSeekers { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<City>? Cities { get; set; } 
    public DbSet<District>? Districts{ get; set; }
    public DbSet<Position>? Positions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=JobBox;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
    }


}
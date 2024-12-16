using Microsoft.EntityFrameworkCore;

namespace Core.Entities;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Plog> Plogs { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<Timeline> Timelines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MyPortfolio;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Owner__3213E83FFACDBAFF");
        });

        modelBuilder.Entity<Plog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__plogs__3213E83FE5C809A3");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__projects__3213E83F3A097526");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__skills__3213E83FC45EEDFE");
        });

        modelBuilder.Entity<Timeline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__timeline__3213E83F91020DC3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

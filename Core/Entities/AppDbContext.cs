using System;
using System.Collections.Generic;
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

    public virtual DbSet<Social> Socials { get; set; }

    public virtual DbSet<Timeline> Timelines { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyPortfolio;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Owner__3213E83FFACDBAFF");

            entity.ToTable("Owner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Education).HasColumnType("text");
            entity.Property(e => e.Email).HasColumnType("text");
            entity.Property(e => e.JobTitle).HasColumnType("text");
            entity.Property(e => e.Languages).HasColumnType("text");
            entity.Property(e => e.Location).HasColumnType("text");
            entity.Property(e => e.MainSkills).HasColumnType("text");
            entity.Property(e => e.OfflineCv).HasColumnType("text");
            entity.Property(e => e.OnlineCv).HasColumnType("text");
            entity.Property(e => e.OwnerImage).HasColumnType("text");
            entity.Property(e => e.OwnerName).HasColumnType("text");
        });

        modelBuilder.Entity<Plog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__plogs__3213E83FE5C809A3");

            entity.ToTable("plogs");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Plogimage)
                .HasColumnType("text")
                .HasColumnName("plogimage");
            entity.Property(e => e.Plogname)
                .HasColumnType("text")
                .HasColumnName("plogname");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__projects__3213E83FBF72BD39");

            entity.ToTable("projects");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Projecthosturl)
                .HasColumnType("text")
                .HasColumnName("projecthosturl");
            entity.Property(e => e.Projectimage)
                .HasColumnType("text")
                .HasColumnName("projectimage");
            entity.Property(e => e.Projectname)
                .HasColumnType("text")
                .HasColumnName("projectname");
            entity.Property(e => e.Projectno).HasColumnName("projectno");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__skills__3213E83FC45EEDFE");

            entity.ToTable("skills");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Skillname)
                .HasColumnType("text")
                .HasColumnName("skillname");
            entity.Property(e => e.Skillpercentage).HasColumnName("skillpercentage");
        });

        modelBuilder.Entity<Social>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Social__3214EC07C109E232");

            entity.ToTable("Social");

            entity.Property(e => e.SocialLink).HasMaxLength(155);
        });

        modelBuilder.Entity<Timeline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__timeline__3213E83F91020DC3");

            entity.ToTable("timeline");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Daterange)
                .HasColumnType("text")
                .HasColumnName("daterange");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Subtitle)
                .HasColumnType("text")
                .HasColumnName("subtitle");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

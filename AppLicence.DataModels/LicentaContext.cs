using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AppLicence.DataModels;

public partial class LicentaContext : DbContext
{
    public LicentaContext()
    {
    }

    public LicentaContext(DbContextOptions<LicentaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Achivement> Achivements { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Goal> Goals { get; set; }

    public virtual DbSet<SubGoal> SubGoals { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAchivement> UserAchivements { get; set; }

    public virtual DbSet<UserGoal> UserGoals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-NONPIMP;Initial Catalog=Licenta;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Achivement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("achivements_id_primary");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Descripton).HasColumnName("descripton");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("category_id_primary");

            entity.ToTable("Category");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name).HasMaxLength(255);
        });

        modelBuilder.Entity<Goal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("goal_id_primary");

            entity.ToTable("Goal");

            entity.HasIndex(e => e.GoalCode, "goal_goal_code_unique").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.Description)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.Frequency).HasColumnName("frequency");
            entity.Property(e => e.GoalCode)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("Goal_code");
            entity.Property(e => e.GoalName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Goal_name");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("start_date");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<SubGoal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sub_goal_id_primary");

            entity.ToTable("Sub_goal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("end_date");
            entity.Property(e => e.GoalId).HasColumnName("Goal_ID");
            entity.Property(e => e.Priority).HasColumnName("priority");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_id_primary");

            entity.ToTable("User");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Prenume).HasMaxLength(255);
        });

        modelBuilder.Entity<UserAchivement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_achivements_id_primary");

            entity.ToTable("User_achivements");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AchivementId).HasColumnName("Achivement_ID");
            entity.Property(e => e.UserId).HasColumnName("User_ID");
        });

        modelBuilder.Entity<UserGoal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("user_goal_id_primary");

            entity.ToTable("User_goal");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.GoalId).HasColumnName("Goal_ID");
            entity.Property(e => e.UserId).HasColumnName("user_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

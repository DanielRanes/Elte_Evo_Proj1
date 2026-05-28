using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Bead;

public partial class Bead_Database : DbContext
{
    public Bead_Database()
    {
    }

    public Bead_Database(DbContextOptions<Bead_Database> options)
        : base(options)
    {
    }

    public virtual DbSet<Meresek> Mereseks { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Daniel\\Suli\\EGYETEM\\ELTE\\C#_bead\\database\\Bead_Database.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Meresek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Meresek__3214EC07318C055F");

            entity.ToTable("Meresek");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.MeroType)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.Mero).WithMany(p => p.Mereseks)
                .HasForeignKey(d => d.MeroId)
                .HasConstraintName("FK__Meresek__MeroId__6D0D32F4");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC078BF49626");

            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserType)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

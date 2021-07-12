using System;
using DataEntity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataModelo.Models
{
    public partial class CheilTravelContext : DbContext
    {
        public CheilTravelContext()
        {
        }

        public CheilTravelContext(DbContextOptions<CheilTravelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Calificacion> Calificacions { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Foto> Fotos { get; set; }
        public virtual DbSet<Hotel> Hotels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=22LAP5CG0434ZK7;Initial Catalog=CheilTravel;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Calificacion>(entity =>
            {
                entity.HasKey(e => e.IdCalificacion)
                    .HasName("PK__Califica__40E4A75123DFA17A");

                entity.ToTable("Calificacion");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Calificacions)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__Calificac__IdCli__2B3F6F97");

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.Calificacions)
                    .HasForeignKey(d => d.IdHotel)
                    .HasConstraintName("FK__Calificac__IdHot__2C3393D0");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__Cliente__D594664244B0B0C0");

                entity.ToTable("Cliente");

                entity.Property(e => e.Documento).HasMaxLength(30);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Foto>(entity =>
            {
                entity.HasKey(e => e.IdFoto)
                    .HasName("PK__Foto__007D321DD5AE465E");

                entity.ToTable("Foto");

                entity.HasOne(d => d.IdHotelNavigation)
                    .WithMany(p => p.Fotos)
                    .HasForeignKey(d => d.IdHotel)
                    .HasConstraintName("FK__Foto__IdHotel__286302EC");
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasKey(e => e.IdHotel)
                    .HasName("PK__Hotel__653BCCC4FC20D60A");

                entity.ToTable("Hotel");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

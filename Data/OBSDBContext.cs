using Microsoft.EntityFrameworkCore;
using Obs.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obs.Data
{
    public class OBSDBContext : DbContext
    {
        public DbSet<Ogrenci> Students { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDers> OgrenciDersler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OgrenciDers>()
                .HasKey(od => new { od.DersId, od.OgrenciId });

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ders)
                .WithMany(d => d.OgrenciDersler)
                .HasForeignKey(od => od.DersId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ogrenci)
                .WithMany(o => o.OgrenciDersler)
                .HasForeignKey(od => od.OgrenciId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Ogrenci>()
                .HasOne(o => o.Sinif)
                .WithMany(s => s.Ogrenciler)
                .HasForeignKey(o => o.SinifId)
                .IsRequired();

            //modelBuilder.Entity<Sinif>()
            //    .HasCheckConstraint("CK_Sinif_Kontenjan", "Kontenjan <= 2");

            modelBuilder.Entity<Ders>()
                .Property(d => d.DersKod)
                .IsRequired()
                .HasMaxLength(10);

            modelBuilder.Entity<Ders>()
                .Property(d => d.DersAd)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Ad)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Soyad)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<Ogrenci>()
                .Property(o => o.Numara)
                .IsRequired()
                .HasMaxLength(15);

            modelBuilder.Entity<Sinif>()
                .Property(s => s.SinifAd)
                .IsRequired()
                .HasMaxLength(20);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Obs;Integrated Security=True;TrustServerCertificate=true;");
        }
    }
}

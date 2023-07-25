using Microsoft.EntityFrameworkCore;
using Plak_Dukkani.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plak_Dukkani.Context
{
    public class PlakDukkaniDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Album> Albums { get; set; }

        public DbSet<AdminAlbum> AdminAlbums { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=PlakDukkaniDb;trusted_connection=true");

            optionsBuilder.UseLazyLoadingProxies(useLazyLoadingProxies: true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .HasMany(a => a.AdminAlbums)
                .WithOne()
                .HasForeignKey(aa => aa.AdminId);

            modelBuilder.Entity<Album>()
                .HasMany(a => a.AdminAlbums)
                .WithOne()
                .HasForeignKey(aa => aa.AlbumId);

            modelBuilder.Entity<AdminAlbum>()
                .HasKey(aa => new { aa.AdminId, aa.AlbumId });

            base.OnModelCreating(modelBuilder);
        }


    }
}

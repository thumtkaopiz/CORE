using DATA.Entities;
using Microsoft.EntityFrameworkCore;

namespace DATA.EF
{
    public class BaseContext : DbContext
    {
        // public BaseContext(DbContextOptions options) : base(options)
        // {
        // }

        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=library;user=root;password=Admin@123");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.ToTable("Publisher");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Title).IsRequired();
            //     entity.HasOne(d => d.Publisher)
            // .WithMany(p => p.Books);
            });
        }
    }
}

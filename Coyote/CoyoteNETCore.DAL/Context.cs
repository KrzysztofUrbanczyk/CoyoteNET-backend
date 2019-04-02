using CoyoteNETCore.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CoyoteNETCore.DAL
{
    public class Context : IdentityDbContext
    {
        public virtual DbSet<Thread> Threads { get; set; }
        public virtual DbSet<User> Userss { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("user");


                entity.Property(e => e.Id).ForSqlServerUseSequenceHiLo()
                    .HasColumnName("id");
            });
            modelBuilder.Entity<Thread>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("thread");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ForSqlServerUseSequenceHiLo();

                entity.Property(e => e.PublicId)
                    .HasColumnName("public_id")
                    .HasMaxLength(38)
                    .IsRequired();


                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("timestamp with time zone");

                entity.Property(e => e.Body)
                    .HasColumnName("body");

                entity.Property(e => e.Brief)
                    .HasColumnName("brief");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.HasOne(t => t.Author)
                    .WithMany(u => u.Threads)
                    .HasForeignKey(d => d.AuthorId);
            });
        }
    }
}
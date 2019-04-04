using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HourlyChecker.Models
{
    public partial class HourCheckerContext : DbContext
    {
        public HourCheckerContext()
        {
        }

        public HourCheckerContext(DbContextOptions<HourCheckerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DataTable> DataTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=HourChecker;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<DataTable>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__data_tab__206D9190BFC2DB33");

                entity.ToTable("data_table");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("firstName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hour)
                    .HasColumnName("hour")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("lastName")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Minutes)
                    .HasColumnName("minutes")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phoneNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasColumnName("qualification")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}

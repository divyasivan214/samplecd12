using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace apiForAzure.CTSModel
{
    public partial class collegeContext : DbContext
    {
        public collegeContext()
        {
        }

        public collegeContext(DbContextOptions<collegeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=college;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.StudId)
                    .HasName("PK__Student__09AFA909C00E882D");

                entity.ToTable("Student");

                entity.Property(e => e.StudId)
                    .ValueGeneratedNever()
                    .HasColumnName("Stud_id");

                entity.Property(e => e.Marks).HasColumnName("marks");

                entity.Property(e => e.StudAddr)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Stud_addr");

                entity.Property(e => e.StudName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Stud_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

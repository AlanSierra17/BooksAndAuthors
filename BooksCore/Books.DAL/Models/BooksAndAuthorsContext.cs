using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Books.DAL.Models
{
    public partial class BooksAndAuthorsContext : DbContext
    {
        public BooksAndAuthorsContext()
        {
        }

        public BooksAndAuthorsContext(DbContextOptions<BooksAndAuthorsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Editorial> Editorials { get; set; } = null!;
        public virtual DbSet<Nationality> Nationalities { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server = DESKTOP-OT677EQ\\SQLEXPRESS; Database = BooksAndAuthors; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.IdAuthors);

                entity.Property(e => e.AuthorName).HasMaxLength(50);

                entity.HasOne(d => d.NationalityNavigation)
                    .WithMany(p => p.Authors)
                    .HasForeignKey(d => d.Nationality)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Authors_Nationalities");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.IdBooks);

                entity.Property(e => e.BookName).HasMaxLength(200);

                entity.HasOne(d => d.AuthorNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.Author)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Books_Authors");

                entity.HasOne(d => d.EditorialNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.Editorial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Books_Editorials");
            });

            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.HasKey(e => e.IdEditorials);

                entity.Property(e => e.EditorialName).HasMaxLength(100);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.HasKey(e => e.IdNationalities);

                entity.Property(e => e.Nationality1)
                    .HasMaxLength(100)
                    .HasColumnName("Nationality");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

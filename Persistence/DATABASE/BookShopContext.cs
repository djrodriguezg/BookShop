using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Persistence.DATABASE
{
    public partial class BookShopContext : DbContext
    {
        public BookShopContext()
        {
        }

        public BookShopContext(DbContextOptions<BookShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.IdAuthor);

                entity.ToTable("AUTHOR");

                entity.Property(e => e.IdAuthor).HasColumnName("ID_AUTHOR");

                entity.Property(e => e.DateBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_BIRTH");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Hometown)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HOMETOWN");

                entity.Property(e => e.Lastname1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME1");

                entity.Property(e => e.Lastname2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LASTNAME2");

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME1");

                entity.Property(e => e.Name2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME2");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.Idbook);

                entity.ToTable("BOOK");

                entity.Property(e => e.Idbook).HasColumnName("IDBOOK");

                entity.Property(e => e.Genre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GENRE");

                entity.Property(e => e.Idauthor).HasColumnName("IDAUTHOR");

                entity.Property(e => e.Idpublisher).HasColumnName("IDPUBLISHER");

                entity.Property(e => e.Numberpages).HasColumnName("NUMBERPAGES");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Year).HasColumnName("YEAR");

                entity.HasOne(d => d.IdauthorNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.Idauthor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOOK_AUTHOR");

                entity.HasOne(d => d.IdpublisherNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.Idpublisher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BOOK_PUBLISHER");
            });

            modelBuilder.Entity<Publisher>(entity =>
            {
                entity.HasKey(e => e.IdPublisher);

                entity.ToTable("PUBLISHER");

                entity.Property(e => e.IdPublisher).HasColumnName("ID_PUBLISHER");

                entity.Property(e => e.BooksRegCount).HasColumnName("BOOKS_REG_COUNT");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.MailingAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MAILING_ADDRESS");

                entity.Property(e => e.MaxBooksReg).HasColumnName("MAX_BOOKS_REG");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NAME");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Telephone).HasColumnName("TELEPHONE");
            });

        }
    }
}

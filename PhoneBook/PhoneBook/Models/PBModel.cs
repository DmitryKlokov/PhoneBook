namespace PhoneBook.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PBModel : DbContext
    {
        public PBModel()
            : base("name=PBModel")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
                .Property(e => e.AddressA)
                .IsUnicode(false);

            modelBuilder.Entity<Address>()
                .Property(e => e.DesctiptionAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Email>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Email>()
                .Property(e => e.DescriptionEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Addresses)
                .WithOptional(e => e.Person)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Emails)
                .WithOptional(e => e.Person)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Person>()
                .HasMany(e => e.Phones)
                .WithOptional(e => e.Person)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Phone>()
                .Property(e => e.NumberPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Phone>()
                .Property(e => e.DescriptionPhone)
                .IsUnicode(false);
        }
    }
}

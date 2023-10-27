using AdressBook.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AdressBookData.Entity
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<Person> PERSONs { get; set; }
        public virtual DbSet<Company> COMPANies { get; set; }
        public virtual DbSet<Email> EMAILs { get; set; }
        public virtual DbSet<Location> LOCATIONs { get; set; }
        public virtual DbSet<Phone> PHONEs { get; set; }
        public virtual DbSet<Person_N_Company> PERSON_N_COMPANies { get; set; }
        public virtual DbSet<Person_N_Email> PERSON_N_EMAILs { get; set; }
        public virtual DbSet<Person_N_Location> PERSON_N_LOCATIONs { get; set; }
        public virtual DbSet<Person_N_Phone> PERSON_N_PHONEs { get; set; }
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
                optionsBuilder.UseNpgsql("User ID=postgres;Password=adm1923;Server=localhost;Port=5432;Database=AddressBook;Integrated Security=true;Pooling=true;");
                
            //}
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.Name).HasColumnName("name").HasColumnType("character varying").HasMaxLength(250);
                entity.Property(i => i.SurName).HasColumnName("surname").HasColumnType("character varying").HasMaxLength(250);

            });
            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.Name).HasColumnName("name").HasColumnType("character varying").HasMaxLength(250);
                entity.Property(i => i.Description).HasColumnName("description").HasColumnType("character varying").HasMaxLength(250);
            });
            modelBuilder.Entity<Email>(entity =>
            {
                entity.ToTable("Email");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.EmailAdress).HasColumnName("email").HasColumnType("character varying").HasMaxLength(250);
                entity.Property(i => i.Description).HasColumnName("description").HasColumnType("character varying").HasMaxLength(250);
            });
            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.Address).HasColumnName("email").HasColumnType("character varying").HasMaxLength(250);
                entity.Property(i => i.Description).HasColumnName("description").HasColumnType("character varying").HasMaxLength(250);
            });
            modelBuilder.Entity<Phone>(entity =>
            {
                entity.ToTable("Phone");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.PhoneNumber).HasColumnName("phoneNumber").HasColumnType("character varying").HasMaxLength(250);
                entity.Property(i => i.Description).HasColumnName("description").HasColumnType("character varying").HasMaxLength(250);
            });

            modelBuilder.Entity<Person_N_Company>(entity =>
            {
                entity.ToTable("Person_N_Company");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.IdPerson).HasColumnName("idPerson").HasColumnType("int");
                entity.Property(i => i.IdCompany).HasColumnName("idCompany").HasColumnType("int");
                
                entity.HasOne(i => i.IdPersonNavigation).WithMany(p => p.Person_N_Companies)
                    .HasForeignKey(i => i.IdPerson)
                    .HasConstraintName("FK_PERSON_N_COMPANY_PERSON");

                entity.HasOne(i => i.IdCompanyNavigation).WithMany(p => p.Person_N_Companies)
                    .HasForeignKey(i => i.IdCompany)
                    .HasConstraintName("FK_PERSON_N_COMPANY_COMPANY");
            });
            modelBuilder.Entity<Person_N_Email>(entity =>
            {
                entity.ToTable("Person_N_Email");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.IdPerson).HasColumnName("idPerson").HasColumnType("int");
                entity.Property(i => i.IdEmail).HasColumnName("idEmail").HasColumnType("int");

                entity.HasOne(i => i.IdPersonNavigation).WithMany(p => p.Person_N_Emails)
                    .HasForeignKey(i => i.IdPerson)
                    .HasConstraintName("FK_PERSON_N_EMAIL_PERSON");

                entity.HasOne(i => i.IdEmailNavigation).WithMany(p => p.Person_N_Emails)
                    .HasForeignKey(i => i.IdEmail)
                    .HasConstraintName("FKPERSON_N_EMAIL_EMAIL");
            });
            modelBuilder.Entity<Person_N_Location>(entity =>
            {
                entity.ToTable("Person_N_Location");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.IdPerson).HasColumnName("idPerson").HasColumnType("int");
                entity.Property(i => i.IdLocation).HasColumnName("idLocation").HasColumnType("int");

                entity.HasOne(i => i.IdPersonNavigation).WithMany(p => p.Person_N_Locations)
                    .HasForeignKey(i => i.IdPerson)
                    .HasConstraintName("FK_PERSON_N_LOCATION_PERSON");

                entity.HasOne(i => i.IdLocationNavigation).WithMany(p => p.Person_N_Locations)
                    .HasForeignKey(i => i.IdLocation)
                    .HasConstraintName("FKPERSON_N_LOCATION_LOCATION");
            });
            modelBuilder.Entity<Person_N_Phone>(entity =>
            {
                entity.ToTable("Person_N_Phone");

                entity.Property(i => i.Id).HasColumnName("id").HasColumnType("int").UseIdentityColumn().IsRequired();
                entity.Property(i => i.IdPerson).HasColumnName("idPerson").HasColumnType("int");
                entity.Property(i => i.IdPhone).HasColumnName("idPhone").HasColumnType("int");

                entity.HasOne(i => i.IdPersonNavigation).WithMany(p => p.Person_N_Phones)
                    .HasForeignKey(i => i.IdPerson)
                    .HasConstraintName("FK_PERSON_N_PHONE_PERSON");

                entity.HasOne(i => i.IdPhoneNavigation).WithMany(p => p.Person_N_Phones)
                    .HasForeignKey(i => i.IdPhone)
                    .HasConstraintName("FKPERSON_N_PHONE_PHONE");
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
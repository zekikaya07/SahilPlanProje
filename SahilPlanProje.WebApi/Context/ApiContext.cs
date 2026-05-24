using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using SahilPlanProje.WebApi.Entities;

namespace SahilPlanProje.WebApi.Context
{
    public class ApiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Add-Migration mig3
            //Update-Database
            //optionsBuilder.UseSqlServer(
            //    "Server=KAYA;Database=ApiSahilPlanProje;User Id=sa;Password=1453;TrustServerCertificate=True;"
            //);
            optionsBuilder.UseSqlServer(
                        "Server=94.199.202.242,1433;Database=sahilpla_ApiSahilPlanProje;User Id=zkky;Password=Zk.Ky.0734;TrustServerCertificate=True;"
                    );
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<TahakkukYear> TahakkukYears { get; set; }
        public DbSet<TahakkukInstitution> TahakkukInstitutions { get; set; }
        public DbSet<TahakkukScale> TahakkukScales { get; set; }
        public DbSet<TahakkukFeeSubject> TahakkukFeeSubjects { get; set; }
        public DbSet<TahakkukDepartment> TahakkukDepartments { get; set; }
        public DbSet<TahakkukDirectorate> TahakkukDirectorates { get; set; }
        public DbSet<TahakkukFeeSubSubject> TahakkukFeeSubSubjects { get; set; }
        public DbSet<TahakkukDefinition> TahakkukDefinitions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().ToTable("Cities");

            modelBuilder.Entity<District>().ToTable("Districts");
            modelBuilder.Entity<District>()
                .HasOne(x => x.city)
                .WithMany(x => x.districts)
                .HasForeignKey(x => x.city_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukYear>().ToTable("TahakkukYears");
            modelBuilder.Entity<TahakkukInstitution>().ToTable("TahakkukInstitutions");
            modelBuilder.Entity<TahakkukScale>().ToTable("TahakkukScales");
            modelBuilder.Entity<TahakkukFeeSubject>().ToTable("TahakkukFeeSubjects");
            modelBuilder.Entity<TahakkukDepartment>().ToTable("TahakkukDepartments");

            modelBuilder.Entity<TahakkukFeeSubSubject>().ToTable("TahakkukFeeSubSubjects");
            modelBuilder.Entity<TahakkukFeeSubSubject>()
                .HasOne(x => x.tahakkuk_fee_subject)
                .WithMany()
                .HasForeignKey(x => x.tahakkuk_fee_subject_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>().ToTable("TahakkukDefinitions");

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.city)
                .WithMany()
                .HasForeignKey(x => x.city_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.district)
                .WithMany()
                .HasForeignKey(x => x.district_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.tahakkuk_year)
                .WithMany()
                .HasForeignKey(x => x.tahakkuk_year_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.tahakkuk_institution)
                .WithMany()
                .HasForeignKey(x => x.tahakkuk_institution_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.tahakkuk_fee_subject)
                .WithMany()
                .HasForeignKey(x => x.tahakkuk_fee_subject_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.tahakkuk_fee_sub_subject)
                .WithMany()
                .HasForeignKey(x => x.tahakkuk_fee_sub_subject_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.tahakkuk_scale)
                .WithMany()
                .HasForeignKey(x => x.tahakkuk_scale_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.tahakkuk_department)
                .WithMany()
                .HasForeignKey(x => x.tahakkuk_department_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .HasOne(x => x.tahakkuk_directorate)
                .WithMany()
                .HasForeignKey(x => x.tahakkuk_directorate_id)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TahakkukDefinition>()
                .Property(x => x.price)
                .HasColumnType("decimal(18,2)");
        }
    }
}

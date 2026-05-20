using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using SahilPlanProje.WebApi.Entities;
using SahilPlanProje.WebApi.Migrations;

namespace SahilPlanProje.WebApi.Context
{
    public class ApiContext:DbContext
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
        public DbSet<Feature> Features { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<TahakkukYear> TahakkukYears { get; set; }

        public DbSet<TahakkukInstitution> TahakkukInstitutions { get; set; }

        public DbSet<TahakkukDepartment> TahakkukDepartments { get; set; }

        public DbSet<TahakkukDirectorate> TahakkukDirectorates { get; set; }

        public DbSet<TahakkukScale> TahakkukScales { get; set; }

        public DbSet<TahakkukFeeSubject> TahakkukFeeSubjects { get; set; }

        public DbSet<TahakkukFeeSubSubject> TahakkukFeeSubSubjects { get; set; }

        public DbSet<TahakkukDefinition> TahakkukDefinitions { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<District>()
        //        .HasOne(d => d.city)
        //        .WithMany(c => c.districts)
        //        .HasForeignKey(d => d.city_id);
        //}
    }
}

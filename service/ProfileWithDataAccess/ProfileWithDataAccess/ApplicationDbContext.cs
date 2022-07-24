using Microsoft.EntityFrameworkCore;
using ProfileWithCore.ConfigrationType;
using ProfileWithCore.Model;
using ProfileWithDataAccess.ConfigrationType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithDataAccess
{
 public   class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ProfileExperienceConfigration().Configure(modelBuilder.Entity<ProfileExprience>());
            new TitilesConfiguration().Configure(modelBuilder.Entity<Titiles>());
            new companiesCondiguration().Configure(modelBuilder.Entity<companies>());
            new CitiesConfiguration().Configure(modelBuilder.Entity<Cities>());
            new ProfileConfigration().Configure(modelBuilder.Entity<Profile>());

            //modelBuilder.Entity<Profile>()
            //     .HasMany(b => b.ProfileExprience)
            //     .WithOne();

            //modelBuilder.Entity<ProfileExprience>()
            //    .HasOne(b=>b.Profile)
            //    .WithMany(b=>b.ProfileExprience);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Profile> profiles { get; set; }
        public DbSet<ProfileExprience> ProfileExpriences { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Titiles> Titiles { get; set; }
        public DbSet<companies> Companies { get; set; }
    }
}

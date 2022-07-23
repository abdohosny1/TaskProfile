using Microsoft.EntityFrameworkCore;
using ProfileWithCore.Model;
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

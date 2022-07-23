using Microsoft.EntityFrameworkCore;
using ProfileWithCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithDataAccess.ConfigrationType
{
    public class ProfileExperienceConfigration : IEntityTypeConfiguration<ProfileExprience>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ProfileExprience> builder)
        {

            //builder.HasMany<Profile>(e => e.ProfileExprience)
            //    .WithOne().HasForeignKey(e=>e.ProfileExprience);
            builder.HasOne(e => e.Profile).WithMany()
             .HasForeignKey(e => e.ProfiletId);
        }
    }
}
﻿using Microsoft.EntityFrameworkCore;
using ProfileWithCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithCore.ConfigrationType
{
    class ProfileConfigration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Profile> builder)
        {
            
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            //builder.HasMany<Profile>(e => e.ProfileExprience)
            //    .WithOne().HasForeignKey(e=>e.ProfileExprience);
        }
    }
}

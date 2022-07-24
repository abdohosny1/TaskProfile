using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProfileWithCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileWithDataAccess.ConfigrationType
{
    public class companiesCondiguration : IEntityTypeConfiguration<companies>
    {
        public void Configure(EntityTypeBuilder<companies> builder)
        {
            builder.Property(e => e.Name).IsRequired().HasMaxLength(200);
        }
    }
}

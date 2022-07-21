﻿using Microsoft.EntityFrameworkCore;
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

        public DbSet<Profile> profiles { get; set; }
    }
}

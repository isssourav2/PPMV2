﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMV2.Core.Domain.Entity;
using Microsoft.Extensions.Configuration;
using PPMV2.Core.Helper;

namespace PPMV2.Core.Infrastructure.Repository
{
    public class PPMContext : DbContext
    {
        protected readonly string _ConnectionString;

        public PPMContext()
        {
            
            this._ConnectionString = AppSettings.GetCurrentSettings();
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(this._ConnectionString);
        }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MenuMaster> MenuMasters { get; set; }
        public DbSet<RoleMenuMapping> RoleMenuMappings { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Source> Sources { get; set; }

    }   
}

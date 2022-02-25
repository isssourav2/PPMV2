using Microsoft.EntityFrameworkCore;
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
           // Database.Migrate();
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
        public DbSet<Application> Applications { get; set; }
        
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Source> Sources { get; set; }
        public DbSet<EmailSetting> EmailSettings { get; set; }
        public DbSet<SchedulerSetting> SchedulerSettings { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<RiskCoreImportTemplate> RiskCoreImportTemplates { get; set; }

        public DbSet<FileProcessingTemplates> FileProcessingTemplates { get; set; }
        public DbSet<FileRead> FileReads { get; set; }
        public DbSet<FileProcessingTemplateFormulaField> FileProcessingTemplateFormulaFields { get; set; }
        public DbSet<FrequencyTag> FrequencyTags { get; set; }
        public DbSet<FundScheduler> FundSchedulers { get; set; }

        public DbSet<FilePassword> FilePasswords { get; set; }
        public DbSet<FileFetch> FileFetchs { get; set; }
        public DbSet<FileManipulation> FileManipulations { get; set; }

        public DbSet<FileProcessingTemplateTagMapping> FileProcessingTemplateTagMappings { get; set; }

        public DbSet<FileProcessingTemplateDMSApplication> FileProcessingTemplateDMSApplications { get; set; }
        
            

    }   
}

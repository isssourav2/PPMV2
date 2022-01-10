using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Helper
{
    public class AppSettings
    {        
        public static string GetCurrentSettings()
        {

            var builder = new ConfigurationBuilder().
                          SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);           

            IConfigurationRoot configuration = builder.Build();
            return configuration.GetConnectionString("PPMConnection");
        }
    }
}

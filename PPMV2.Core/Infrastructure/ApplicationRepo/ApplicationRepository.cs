using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using PPMV2.Core.Infrastructure.Repository;
using PPMV2.Core.Infrastructure.RoleRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.ApplicationRepo
{
    public class ApplicationRepository : Repository<Application>, IApplicationRepository
    {
     
    }
}

using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PPMV2.Core.Infrastructure.SchedulerSettingRepo
{
    public interface ISchedulerSettingRepository: IRepository<SchedulerSetting>
    {
    }
}

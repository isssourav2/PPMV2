using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.EmailSettingRepo
{
    public interface IEmailSettingRepository: IRepository<EmailSetting>
    {
    }
}

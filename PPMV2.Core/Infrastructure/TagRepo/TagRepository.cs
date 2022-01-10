using PPMV2.Core.Infrastructure.Repository;
using PPMV2.Core.Infrastructure.TagRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPMV2.Core.Domain.Entity;

namespace PPMV2.Core.Infrastructure.TagRepo
{
    public class TagRepository :  Repository<Tag>,ITagRepository
    {
       
    }
}

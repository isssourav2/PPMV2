﻿using PPMV2.Core.Domain.Entity;
using PPMV2.Core.Infrastructure.Repository;
using PPMV2.Core.Infrastructure.RoleRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPMV2.Core.Infrastructure.UserRepo
{
    public class UserRepository: Repository<User>,IUserRepository
    {
        
    }
}

﻿using Color_Media.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Media.Service.Implements
{
    public class UserRightService : BaseService<UserRight>, IUserRightService
    {
        public UserRightService(thnd_qlsx_phimContext context) : base(context)
        {
        }
    }
}

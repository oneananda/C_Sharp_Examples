﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moq_Implementation.Interface
{
    public interface IUserService
    {
        bool IsUserLoggedIn(int userId);
    }
}

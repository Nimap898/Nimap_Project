﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication5.Models;

namespace WebApplication5.Service
{
    internal interface IUserService
    {
        User Authenticate (string username, string password);
    }
}

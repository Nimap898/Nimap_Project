﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class User
    {
        [Key] 
        public int UserId { get; set; }
        
        public string username {  get; set; }
        
        public string password { get; set; }
    }
}
﻿using Microsoft.AspNetCore.Identity;
namespace BLL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
    
    }
}

using System;
using Microsoft.AspNetCore.Identity;

namespace UniversityManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string StudentNumber { get; set; }
    }
}

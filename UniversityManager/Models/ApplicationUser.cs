using System;
using Microsoft.AspNetCore.Identity;

namespace UniversityManager.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string StudentNumber { get; set; }

        public double OverallScore { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Egn { get; set; }
    }
}

using System;
using AutoMapper;
using UniversityManager.Models;
using UniversityManager.ViewModels;

namespace UniversityManager.Data.Profiles
{
    public class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<ApplicationUser, ApplicationUserViewModel>();
        }
    }
}

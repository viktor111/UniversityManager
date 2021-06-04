using System;
using AutoMapper;
using UniversityManager.Models;
using UniversityManager.ViewModels;
using UniversityManager.ViewModels.Student;

namespace UniversityManager.Data.Profiles
{
    public class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<ApplicationUser, StudentViewModel>();
        }
    }
}

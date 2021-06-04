using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using UniversityManager.Data.Repositories;
using UniversityManager.Models;
using UniversityManager.ViewModels;
using UniversityManager.ViewModels.Student;

namespace UniversityManager.Controllers
{
    public class StudentController : Controller
    {
        IRepository<ApplicationUser> _studentRepository;
        IMapper _mapper;

        public StudentController
            (
                IRepository<ApplicationUser> studentRepository,
                IMapper mapper
            )
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var studentDetails = await _studentRepository.Get(id);
            var viewModel = _mapper.Map<StudentViewModel>(studentDetails);

            return View(viewModel);
        }
    }
}
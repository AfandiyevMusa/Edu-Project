using Edu.Models;
using Edu.DAL;
using Edu.ViewModels;
using Edu.Services;
using Edu.Services.Interfaces;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Edu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICoursesService _coursesService;

        public HomeController(ICoursesService coursesService)
        {
            _coursesService = coursesService;
        }

        public async Task<IActionResult> Index()
        {
            List<Course> courses = await _coursesService.GetAllAsync();

            HomeVM model = new()
            {
                Courses = courses
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
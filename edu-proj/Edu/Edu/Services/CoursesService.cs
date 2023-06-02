using Edu.DAL;
using Edu.Models;
using Edu.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Edu.Services
{
    public class CoursesService : ICoursesService
	{
        private readonly AppDbContext _context;

        public CoursesService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetAllAsync()
        {
            return await _context.Courses.Include(m => m.CourseImgs).Where(m => !m.SoftDelete).ToListAsync();
        }
    }
}


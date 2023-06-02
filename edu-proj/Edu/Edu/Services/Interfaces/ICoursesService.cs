using System;
using Edu.Models;
namespace Edu.Services.Interfaces
{
	public interface ICoursesService
	{
        Task<List<Course>> GetAllAsync();
    }
}


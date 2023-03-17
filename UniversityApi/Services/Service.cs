using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using UniversityApi.Data;
using UniversityApi.Models;

namespace UniversityApi.Services
{
    public class Service
    {
        private readonly SchoolContext _context;
        public Service (SchoolContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetStudentsByEmail(string emailAdress)
        {
            var studentsResult = _context.Students.Where(student => student.Email == emailAdress);

            return studentsResult;
        }

    }
}

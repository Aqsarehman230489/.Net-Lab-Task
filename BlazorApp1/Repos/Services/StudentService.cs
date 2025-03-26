using BlazorApp1.Repos.IServices;
using DAL;
using Entities;

namespace BlazorApp1.Repos.Services
{
    public class StudentService : IStudentService
    {
        public List<StudentModel> GetStudentsinfo()
        {
              return StudentDAL.Get();
        }
           
        
    }
}


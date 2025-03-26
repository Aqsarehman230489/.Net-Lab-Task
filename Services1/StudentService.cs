using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services1
{
    public class StudentService : IStudentService
    {
        public void Delete(string id)
        {
            StudentDAL.DeleteStudents(id);
        }

        public List<StudentModel> Get()
        {
           
            return StudentDAL.GetStudents();
        }  
    }
}


using Entities;

namespace Services1
{
        public interface IStudentService
        {
            List<StudentModel> Get();
            void Delete(string id);

    }
}
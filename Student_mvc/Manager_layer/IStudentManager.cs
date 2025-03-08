using DataAccess.DBModel;
using Manager_layer.Dto_s;

namespace Manager_layer
{
    public interface IStudentManager
    {
        Student Create(CreateStudentDto create);

        Student UpdateStudent(int id, CreateStudentDto entity);

        bool Delete(int id);

        IEnumerable<Student> GetAll();

        public Student GetById(int id);

        public bool PermenantDelete(int id);

        public bool RestoreStudent(int id);
    }
}

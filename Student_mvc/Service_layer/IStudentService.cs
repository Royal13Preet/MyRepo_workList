using DataAccess.DBModel;
using Manager_layer.Dto_s;

namespace Service_layer
{
    public interface IStudentService
    {
        Student Create(CreateStudentDto create);

        Student Update(int id, CreateStudentDto entity);

        bool Delete(int id);

        public bool PermanentDelete(int id);

        IEnumerable<Student> GetAll();

        public Student GetById(int id);

        public bool Restore(int id);



    }
}

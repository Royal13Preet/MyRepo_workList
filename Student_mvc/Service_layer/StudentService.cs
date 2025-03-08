using DataAccess.DBModel;
using Manager_layer;
using Manager_layer.Dto_s;

namespace Service_layer
{
    public class StudentService : IStudentService
    {
        private readonly IStudentManager _manager;

        public StudentService(IStudentManager manager)
        {
            _manager = manager;
        }

        public Student Create(CreateStudentDto create)
        {
            return _manager.Create(create);
        }

        public bool PermanentDelete(int id)
        {
            return _manager.PermenantDelete(id);
        }

        public bool Delete(int id)
        {
            return _manager.Delete(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _manager.GetAll();
        }

        public Student GetById(int id)
        {
            return _manager.GetById(id);
        }

        public Student Update(int id, CreateStudentDto entity)
        {
            return _manager.UpdateStudent(id, entity);
        }


        public bool Restore(int id)
        {
            return _manager.RestoreStudent(id);
        }


    }
}

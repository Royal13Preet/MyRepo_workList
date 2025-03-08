using AutoMapper;
using DataAccess.DBModel;
using DataAccess.Repos;
using Manager_layer.Dto_s;

namespace Manager_layer
{
    public class StudentManager : IStudentManager
    {
        private readonly IStudentRepo _studentRepo;
        private readonly IMapper _mapper;

        public StudentManager(IStudentRepo studentRepo, IMapper mapper)
        {
            _mapper = mapper;
            _studentRepo = studentRepo;
        }

        public Student Create(CreateStudentDto create)
        {
            var student = _mapper.Map<Student>(create);
            return _studentRepo.Create(student);
        }

        public bool Delete(int id)
        {

            return _studentRepo.Delete(id);
        }

        public bool PermenantDelete(int id)
        {
            return _studentRepo.PermanentDelete(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _studentRepo.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentRepo.GetById(id);
        }

        public Student UpdateStudent(int id, CreateStudentDto create)
        {
            var getId = _studentRepo.GetById(id);
            var map = _mapper.Map(create, getId);
            return _studentRepo.Update(map);
        }

        public bool RestoreStudent(int id)
        {
            var student = _studentRepo.GetById(id);
            if (student != null)
            {
                student.IsActive = true; // Mark as active
                _studentRepo.Update(student);
                return true;
            }
            return false;
        }
    }
}











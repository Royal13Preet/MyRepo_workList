using DataAccess.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos
{


    public interface IStudentRepo 
    {

        Student Create(Student student);

        Student Update(Student student);

        bool Delete(int id);

        public IEnumerable<Student> GetAll();

       

        Student GetById(int id);

        public bool PermanentDelete(int id);
    }
}

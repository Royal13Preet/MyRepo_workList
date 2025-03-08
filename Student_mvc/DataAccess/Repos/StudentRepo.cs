using DataAccess.DBModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repos
{
    public class StudentRepo : IStudentRepo
    {
        private readonly AppDbContext _context;


        public StudentRepo(AppDbContext context)
        {
            _context = context;

        }
        public Student Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public bool PermanentDelete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null) 
            {
                _context.Remove(student);
                _context.SaveChanges();
                return true;

            }
            return false;
            
        }

        public bool Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                student.IsActive = false; // Mark as inactive instead of removing
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        
        public Student Update(Student student)
        {
            try
            {
                _context.Update(student);
                _context.SaveChanges();
                return student;

            }
            catch (Exception ex)
            {
                throw new Exception("Error while updating the student data", ex);
            }
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }
        public Student GetById(int id)
        {
            var ent = _context.Students.Find(id);
            if (ent != null)
            {
                return ent;
            }
            return null!;
        }

       
    }
}

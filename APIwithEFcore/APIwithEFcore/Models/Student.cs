using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIwithEFcore.Models
{
    public class Student
    {

        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public string StudentAddress { get; set; }

        public string StudentEmail { get; set; }
       
        public DateTime StudebtDoB { get; set; }
        public string StudentGender { get; set; }

        [ForeignKey("courseId")]

        public int courseId;
        public Course Course { get; set; }  


    }
}

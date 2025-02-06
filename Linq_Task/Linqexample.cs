using System;

public class Class1
{     
    public static void Main(string[] args)
        {
            List<Student> s = new List<Student>
        {
            new Student { StudentID = 1, StudentName = "preet", Age = 23 },
            new Student { StudentID = 2, StudentName = "Khushi", Age = 22 },
            new Student { StudentID = 3, StudentName = "Navee", Age = 24 },
            new Student {StudentID = 4, StudentName = "Sid", Age=19 },
            new Student {StudentID = 5 , StudentName = "Manju", Age = 20 },
            new Student {StudentID = 5 , StudentName = "Manju", Age = 20 }
        };

            //foreach (var student in s) 
            //{ 
            //    if(student.Age > 20)
            //    {
            //        Console.WriteLine(student.StudentName);
            //    }
            //}

            var result = from student in s
                         where student.Age > 20 && student.Age < 24
                         select student;
            Console.WriteLine("StudentId\tStudentID\tStudentage\t");

            var result1 = s.Select(s => s.StudentName).Distinct();
            foreach (var student in result1)
            {
                Console.WriteLine(student);
            }
        
    }

}

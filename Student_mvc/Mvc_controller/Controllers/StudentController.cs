using Manager_layer.Dto_s;
using Microsoft.AspNetCore.Mvc;
using Service_layer;

namespace Mvc_controller.Controllers
{
    public class StudentController : Controller
    {

        private readonly IWebHostEnvironment _webHostEnvironment;


        private readonly IStudentService _studentService;

        public StudentController(IWebHostEnvironment webHostEnvironment, IStudentService studentService)
        {
            _studentService = studentService;
            _webHostEnvironment = webHostEnvironment;
        }

        //public IActionResult GetAll()
        //{
        //    var students = _studentService.GetAll();
        //    return View(students);
        //}

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateStudentDto model)
        {
            if (ModelState.IsValid)
            {

                if (model.ProfileImageFile != null)
                {
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                    Directory.CreateDirectory(uploadsFolder); // Ensure the folder exists

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.ProfileImageFile.CopyTo(fileStream);
                    }

                    model.ProfilePicture = "/uploads/" + uniqueFileName; // Save relative path
                }

                _studentService.Create(model);
                TempData["SuccessMessage"] = "The student was added successfully!";
                return RedirectToAction("GetAll");

            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var student = _studentService.GetById(id);
            if (student == null)
            {
                return NotFound();
              
            }
            return View(student);
        }
        [HttpPost]
        public IActionResult Edit(int id, CreateStudentDto studentDto)
        {
            if (ModelState.IsValid)
            {
                // Check if a new profile image is uploaded
                if (studentDto.ProfileImageFile != null)
                {
                    // Check if the student already has a profile picture to delete
                    if (!string.IsNullOrEmpty(studentDto.ProfilePicture))
                    {
                        // Delete the old image if it exists
                        var oldFilePath = Path.Combine(_webHostEnvironment.WebRootPath, studentDto.ProfilePicture.TrimStart('/'));
                        if (System.IO.File.Exists(oldFilePath))
                        {
                            System.IO.File.Delete(oldFilePath); // Delete the old file
                        }
                    }

                    // Save the new profile image
                    string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                    Directory.CreateDirectory(uploadsFolder); // Ensure the folder exists

                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + studentDto.ProfileImageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        studentDto.ProfileImageFile.CopyTo(fileStream);

                    }

                    studentDto.ProfilePicture = "/uploads/" + uniqueFileName; // Save relative path
                }

                // Update the student record
                var updatedStudent = _studentService.Update(id, studentDto);

                TempData["UpdatedMessage"] = "This student is updated successfully!";
                return RedirectToAction(nameof(GetAll));
            }

            return View(studentDto);
        }

        public IActionResult GetAll(string name = "",int page = 1,int pageSize = 2)
        {
            var students = _studentService.GetAll();

            if (!string.IsNullOrEmpty(name))
            {
                students = students.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            }
            int totalStudents = students.Count();

            var pagedStudents = students.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalStudents / pageSize);
            
            return View(pagedStudents);
        }
       
        //[HttpPost]
        //public IActionResult Edit(int id, CreateStudentDto studentDto)
        //{
        //    if (ModelState.IsValid)
        //    {


        //        var update = _studentService.Update(id, studentDto);
        //        TempData["UpdatedMessage"] = "This student is updated succesfully";
        //        return RedirectToAction(nameof(GetAll));

        //    }
        //    return View(studentDto);
        //}

        public IActionResult PermanentDelete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PermanentDelete(int id)
        {
            var student = _studentService.GetById(id);
            if (student != null)
            {
                // Check if the student has a profile picture to delete
                if (!string.IsNullOrEmpty(student.ProfilePicture))
                {
                    // Get the full file path of the image
                    var filePath = Path.Combine(_webHostEnvironment.WebRootPath, student.ProfilePicture.TrimStart('/'));

                    // Check if the file exists, and if so, delete it
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath); // Delete the profile image
                    }
                }

                // Perform the permanent delete of the student record
                _studentService.PermanentDelete(id);
                TempData["DeleteMessage"] = "The student was deleted successfully, and the profile picture was removed!";
            }
            else
            {
                TempData["DeleteMessage"] = "Student not found!";
            }
            return RedirectToAction(nameof(GetAll));
        }

        //[HttpPost]
        //public IActionResult PermanentDelete(int id)
        //{
        //    _studentService.PermanentDelete(id);
        //    TempData["DeleteMessage"] = "The student was deleted successfully!";
        //    return RedirectToAction(nameof(GetAll));
        //}

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction(nameof(GetAll));
        }

        public IActionResult GetInactiveStudents()
        {
            var inactiveStudents = _studentService.GetAll().Where(s => !s.IsActive);
            return View(inactiveStudents);
        }

        [HttpPost]
        public IActionResult Restore(int id)
        {
            _studentService.Restore(id);
            return RedirectToAction(nameof(GetAll));
        }

    }
}


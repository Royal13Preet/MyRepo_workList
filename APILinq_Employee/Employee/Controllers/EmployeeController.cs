using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeController(IEmployeeRepo employeeRepo) 
        { 
            _employeeRepo = employeeRepo;
        }


        [HttpPost("Create-Employee")]
        public IActionResult Create(Employee employee) 
        {
            var emp = _employeeRepo.CreateEmployee(employee);
            return Ok(emp);
        }
        [HttpGet("it-department")]
        public IActionResult GetITdepartment()
        {
            var itEmployees = _employeeRepo.FindAllEmpDesc("IT");

            if (itEmployees == null || !itEmployees.Any())
            {
                return NotFound("No employees found in the IT department.");
            }

            return Ok(itEmployees);
        }

        [HttpGet("Average-Salary")]
        public IActionResult AverageSalary(string department)
        {
            var averageSalary = _employeeRepo.AverageSalary(department);
            if(averageSalary == 0.0)
            {
                return NotFound($"No Employees found  in the {department} department");
            }
            return Ok(averageSalary);
        }

        [HttpGet("group-by-department")]
        public IActionResult GetTotalSalaryByDepartment()
        {
            var result = _employeeRepo.GroupByDepartment();

            if (!result.Any())
            {
                return NotFound("No employee data found.");
            }
            return Ok(result);
        }

        [HttpGet("Highest-salary")]
        public IActionResult GetHighSalary()
        {
            var result = _employeeRepo.HighestSalaryEmp();
            return Ok(result);
        }

        [HttpGet("LessSalary")]
        public IActionResult GetLessSalary(Double Salary)
        {
            var sal = _employeeRepo.LessEarning(Salary);
            return Ok(sal);
        }

        [HttpGet("Get-departmnet-salary-ascending")]
        public IActionResult GetdepartSlary()
        {
            var dep = _employeeRepo.DepartSalaryAsc("Finance");
            return Ok(dep);
        }

    }
}

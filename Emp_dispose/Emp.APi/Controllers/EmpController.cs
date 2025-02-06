using Emp.DataAcess.Model;
using Emp.Service.Logger;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Emp.APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpController : ControllerBase
    {
       
            private static List<Employee> employees = new List<Employee>();
            private readonly IMemoryCache _cache;

            public EmpController(IMemoryCache cache)
            {
                
                _cache = cache;
                _cache.Dispose();
            }

            [HttpPost]
            public IActionResult AddEmployee([FromBody] Employee employee)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                employee.Id = employees.Count + 1;
                employees.Add(employee);
                return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
            }

            [HttpGet("{id}")]
            public IActionResult GetEmployeeById(int id)
            {
                if (_cache.TryGetValue(id, out Employee cachedEmployee))
                {
                    return Ok(cachedEmployee);
                }

                var employee = employees.FirstOrDefault(e => e.Id == id);
                if (employee == null) return NotFound();

                // Cache the result
                _cache.Set(id, employee, TimeSpan.FromMinutes(10));

                return Ok(employee);
            }

            [HttpPut("{id}")]
            [ServiceFilter(typeof(AdminRolefilter))]
            public IActionResult UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
            {
                var employee = employees.FirstOrDefault(e => e.Id == id);
                if (employee == null) return NotFound();

                employee.Name = updatedEmployee.Name;
                employee.Department = updatedEmployee.Department;
                employee.Role = updatedEmployee.Role;
                employee.Email = updatedEmployee.Email;
                employee.Salary = updatedEmployee.Salary;

                return NoContent();
            }

            [HttpDelete("{id}")]
            [ServiceFilter(typeof(AdminRolefilter))]
            public IActionResult DeleteEmployee(int id)
            {
                var employee = employees.FirstOrDefault(e => e.Id == id);
                if (employee == null) return NotFound();

                employees.Remove(employee);
                return NoContent();
            }
        }

    }

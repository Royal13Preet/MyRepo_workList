using Employee.Models.Dtos;

namespace Employee
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly EmployeeDBContext _dbContext;

        public EmployeeRepo(EmployeeDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateEmployee(Employee employee)
        {
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
            return true;
        }

        //Find all employees in the "IT" department and order them by their salary in descending order.

        public List<Employee> FindAllEmpDesc(String department)
        {
            var result = _dbContext.Employees
                .Where(x => x.Department == department)
                .OrderByDescending(x => x.Salary)
                .ToList();
            return result;
        }

        //Calculate the average salary of all employees in the "HR" department.
        public double AverageSalary(string department)
        {
            var averageSalary = _dbContext.Employees
                .Where(x => x.Department == department)
                .Average(x => x.Salary);

            return averageSalary;
        }
        //Group employees by their department and display the total salary paid to each department

        public IEnumerable<DepartmentSalarydto> GroupByDepartment()
        {
            var result = _dbContext.Employees
                .GroupBy(e => e.Department)
                .Select(group => new DepartmentSalarydto
                {
                    Department = group.Key,
                    TotalSalary = group.Sum(e => e.Salary)
                })
                .ToList();

            return result;
        }

        //Find the employee with the highest salary across all departments.

        public double HighestSalaryEmp()
        {
            var result = _dbContext.Employees.Max(e => e.Salary);
            return result;
        }

        //Check if there is any employee earning less than 50,000.

        public IEnumerable<Employee> LessEarning(double salary)
        {
            var result = _dbContext.Employees.Where(x => x.Salary <= salary).ToList();
            return result;
        }

        //Find all employees in the "Finance" department and order them by their salary in ascending order.
        public IEnumerable<Employee> DepartSalaryAsc(string department)
        {
            var res = _dbContext.Employees.Where(e => e.Department == department)
                .OrderBy(e => e.Salary);
            return res;
        }
    }
}

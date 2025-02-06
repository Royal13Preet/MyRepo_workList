using Employee.Models.Dtos;

namespace Employee
{
    public interface IEmployeeRepo
    {
        public bool CreateEmployee(Employee employee);

        public List<Employee> FindAllEmpDesc(String department);
        public double AverageSalary(string department);

        public IEnumerable<DepartmentSalarydto> GroupByDepartment();

        public double HighestSalaryEmp();

        public IEnumerable<Employee> LessEarning(double salary);

        public IEnumerable<Employee> DepartSalaryAsc(string department);

    }
}

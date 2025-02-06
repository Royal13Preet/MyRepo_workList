using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models.Dtos
{
    public class DepartmentSalarydto
    {
        public string Department { get; set; } = null!;
        public double TotalSalary { get; set; }
    }
}

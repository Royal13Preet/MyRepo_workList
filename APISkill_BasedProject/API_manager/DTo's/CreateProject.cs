using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_manager.DTo_s
{
    public class CreateProject

    {

        public string ProjectName { get; set; }

        public string? Description { get; set; }

        // Foreign Key to User (CreatedBy)
        public int CreatedBy { get; set; }
    }
}

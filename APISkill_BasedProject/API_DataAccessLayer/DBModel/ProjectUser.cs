using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DataAccessLayer.DBModel
{
    public class ProjectUser
    {
        public int UserId { get; set; }
        public User User { get; set; } 

        public int ProjectId { get; set; }
        public Project Project { get; set; } 
    }
}

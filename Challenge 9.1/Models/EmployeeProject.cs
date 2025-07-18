using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_9._1
{
    public class EmployeeProject
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int ProjectId { get; set; }
        public Project? Project { get; set; }
        // Additional properties can be added if needed, such as role or hours worked on the project
    }
}

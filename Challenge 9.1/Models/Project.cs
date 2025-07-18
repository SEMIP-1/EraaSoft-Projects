using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_9._1
{
    public class Project
    {
        //Id, Name, NOH
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int NumberOfHours { get; set; }
        public List<Employee>? Employees { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}

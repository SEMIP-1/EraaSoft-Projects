namespace Challenge_9._1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }
        public int Age { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public List<Project>? Projects { get; set; }
    }
}
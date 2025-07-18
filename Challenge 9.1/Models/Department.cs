namespace Challenge_9._1
{ 
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Employee>? Employees { get; set; }
        public List<Project>? Projects { get; set; }
    }
}
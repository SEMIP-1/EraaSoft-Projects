using System;
public class Person
{
	protected string? Name { get; set; }
    protected int? Age { get; set; }
    protected string? Address { get; set; }
    protected string? Nationality { get; set; }

    public Person( string Name,int Age, string Address, string Nationality)
    {
        this.Name = Name;
		this.Age = Age;
		this.Address = Address;
		this.Nationality = Nationality;
    }
}
public class Employee : Person
{
	public string? JobTitle { get; set; }
	public decimal? Salary { get; set; }
	public string? Rank { get; set; }

	public Employee(string Name, int Age, string Address, string Nationality,
					string? JobTitle, decimal? Salary, string? Rank) : base
					(Name, Age, Address, Nationality)
	{
		this.JobTitle = JobTitle;
		this.Salary = Salary;
		this.Rank = Rank;
	}
}
public class Student : Person
{
	public string? Major { get; set; }
	public double? GPA { get; set; }
	public int? Study_level { get; set; }

	public Student(string Name, int Age, string Address, string Nationality,
				   string? Major, double? GPA, int? Study_level) : base
				   (Name, Age, Address, Nationality)
	{
			this.Major = Major;
			this.GPA = GPA;
			this.Study_level = Study_level;
	}
}


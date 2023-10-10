namespace Lab10SchoolChasAcademyDataBase.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? PersonNumber { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Class { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();


}






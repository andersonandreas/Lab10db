namespace Lab10SchoolChasAcademyDataBase.Models;

public partial class Employee
{

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} | {this.EmployeeRole}";
    }

}

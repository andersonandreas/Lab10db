using Lab10SchoolChasAcademyDataBase.Data;
using Lab10SchoolChasAcademyDataBase.Models;

namespace Lab10SchoolChasAcademyDataBase
{
    public class EmpManager
    {

        private readonly SchoolChasAcademyDbContext _context;
        private readonly string line = "-------------------------------------------";

        public EmpManager(SchoolChasAcademyDbContext dbContext)
        {
            _context = dbContext;
        }

        // we need to add error checking here so the u
        public void CreateEmployee()
        {
            Console.WriteLine("Enter firstname: ");
            string fName = Console.ReadLine()!;
            Console.WriteLine("Enter lastname: ");
            string lName = Console.ReadLine()!;
            Console.WriteLine("Enter your role: ");
            string role = Console.ReadLine()!;

            AddEmployee(fName, lName, role);
            Console.WriteLine("Employee added");

        }
        public void AddEmployee(string firstName, string lastName, string empRole)
        {
            try
            {
                var employee = new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    EmployeeRole = empRole
                };

                _context.Employees.Add(employee);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }

        }

        // i know this should be in a like show class for just printing. = single responsibliy principle for each class
        public void ShowEmployee()
        {
            Console.WriteLine("\nEmployees in school:");
            Console.WriteLine(line);

            var emp = _context.Employees
            .Select(emp => emp);

            Console.WriteLine(string.Join(Environment.NewLine, emp));
            Console.WriteLine(line);
        }

    }
}

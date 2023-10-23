using Lab10SchoolChasAcademyDataBase.Models;

namespace Lab10SchoolChasAcademyDataBase
{
    public class EmpManager
    {

        private readonly SchoolChasAcademyDbContext _context;

        public EmpManager(SchoolChasAcademyDbContext dbContext)
        {
            _context = dbContext;
        }

        public void CreateEmp()
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
                var newEmp = new Employee
                {
                    FirstName = firstName,
                    LastName = lastName,
                    EmployeeRole = empRole
                };

                _context.Employees.Add(newEmp);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }

        }

        // i know this should be in a like show class for just printing. = single responsibliy principle for each class
        public void ShowEmp()
        {
            Console.WriteLine("\nEmployees in school:");
            Console.WriteLine("-------------------------------------------");
            foreach (var emp in _context.Employees)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("-------------------------------------------");
        }

    }
}

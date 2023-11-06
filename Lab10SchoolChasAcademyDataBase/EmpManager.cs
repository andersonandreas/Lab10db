using Lab10SchoolChasAcademyDataBase.Data;
using Lab10SchoolChasAcademyDataBase.Models;
using Lab10SchoolChasAcademyDataBase.Validator;

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


        public void PrintConsoleAddEmployee()
        {
            string[] employee = new string[3];

            employee[0] = CheckUserInput.ValidateInput();
            employee[1] = CheckUserInput.ValidLastName();
            employee[2] = CheckUserInput.EmployeeRole();

            AddEmployee(employee);
            Console.WriteLine($"The new employee {employee[0]} {employee[1]} is added. Welcome.\n");

        }


        private void AddEmployee(string[] newEmployee)
        {
            try
            {
                var employee = new Employee
                {
                    FirstName = newEmployee[0],
                    LastName = newEmployee[1],
                    EmployeeRole = newEmployee[2]
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

using Lab10SchoolChasAcademyDataBase.Models;

namespace Lab10SchoolChasAcademyDataBase
{
    internal class StudentsHelperFunctions
    {
        private readonly SchoolChasAcademyDbContext _context;

        public StudentsHelperFunctions(SchoolChasAcademyDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<Student> SortByFirstName()
        {

            try
            {
                return _context.Students.OrderBy(a => a.FirstName).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }
        }

        public List<Student> SortByLastName()
        {

            try
            {
                return _context.Students.OrderBy(a => a.LastName).ToList();

            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
                return null;
            }

        }

        public List<Student> searchByClassName(string className)
        {
            try
            {
                return _context.Students.Where(s => s.Class == className).ToList();

            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
                return null;
            }
        }

        public void ShowAllClasses()
        {
            int count = 1;

            foreach (var c in _context.Students)
            {
                Console.WriteLine($"{count}: {c.Class}");
                count++;
            }
        }

        public void DisplayResults(List<Student> students)
        {

            try
            {

                if (students == null)
                {
                    Console.WriteLine("No students to show");
                }

                Console.WriteLine("---- Students ----\n");

                foreach (var stud in students!)
                {
                    Console.WriteLine($"{stud.FirstName} {stud.LastName}");

                }
                Console.WriteLine();
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }

        }
    }

}



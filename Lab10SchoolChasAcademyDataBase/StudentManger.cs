using Lab10SchoolChasAcademyDataBase.Models;

namespace Lab10SchoolChasAcademyDataBase
{
    public class StudentManger
    {
        private readonly SchoolChasAcademyDbContext _context;

        public StudentManger(SchoolChasAcademyDbContext dbContext)
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
                Console.WriteLine($"\nSearching for the stundents in class ({className})....");
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
            Console.WriteLine("-------------------------------------------");

            foreach (var c in _context.Students)
            {
                Console.WriteLine($"{count}: {c.Class}");
                count++;
            }
            Console.WriteLine("-------------------------------------------");
        }

        public void DisplayResults(List<Student> students)
        {

            try
            {

                if (students == null)
                {
                    Console.WriteLine("No students to show");
                }


                Console.WriteLine("-------------------------------------------");

                foreach (var stud in students!)
                {
                    Console.WriteLine($"{stud.FirstName} {stud.LastName}");

                }
                Console.WriteLine("-------------------------------------------");
            }
            catch (Exception e)
            {

                Console.WriteLine($"Error: {e.Message}");
            }

        }

        public void InSameClass()
        {

            ShowAllClasses();
            // need to fix this
            Console.WriteLine("Type the class name to Get back the students in that class.");
            DisplayResults(searchByClassName(Console.ReadLine()));


        }


    }
}


using Lab10SchoolChasAcademyDataBase.Data;
using Lab10SchoolChasAcademyDataBase.Models;

namespace Lab10SchoolChasAcademyDataBase
{
    public class StudentManger
    {
        private readonly SchoolChasAcademyDbContext _context;
        private readonly string line = "-------------------------------------------";

        public StudentManger(SchoolChasAcademyDbContext dbContext)
        {
            _context = dbContext;
        }

        public List<Student> SortByFirstName() =>
            _context.Students.OrderBy(a => a.FirstName).ToList();


        public List<Student> SortByLastName() =>
            _context.Students.OrderBy(a => a.LastName).ToList();


        public List<Student> SearchByClassName(string className)
        {
            Console.WriteLine($"\nSearching for the stundents in class ({className}).");
            return _context.Students.Where(s => s.Class == className).ToList();
        }

        public void ShowSelectedUserChoice(List<Student> studentsList)
        {

            if (studentsList == null)
            {
                Console.WriteLine("No students to show");
                return;
            }

            Console.WriteLine();
            Console.WriteLine(line);

            var students = studentsList
                .Select(s => $"{s.FirstName} {s.LastName}");

            Console.WriteLine
                (string.Join(Environment.NewLine, students));

            Console.WriteLine(line);
        }

        public void ShowAllClasses()
        {
            Console.WriteLine(line);

            var printAllToConsole = _context.Students.ToList()
                .Select((s, Index) => $"{Index + 1}: {s.Class}");

            Console.WriteLine(
                string.Join(Environment.NewLine, printAllToConsole));

            Console.WriteLine(line);
        }

        public void SearchInSpecificClass()
        {

            ShowAllClasses();
            // need to fix this
            Console.WriteLine("Type the class name to Get back the students in that class.");
            ShowSelectedUserChoice(SearchByClassName(Console.ReadLine()));


        }


    }
}


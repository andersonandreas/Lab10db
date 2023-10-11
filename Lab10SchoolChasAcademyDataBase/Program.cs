using Lab10SchoolChasAcademyDataBase.Models;





namespace Lab10SchoolChasAcademyDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolChasAcademyDbContext();

            var studentHelpers = new StudentsHelperFunctions(context);

            Console.WriteLine("Press the number");
            Console.WriteLine("1: sort by firstname, 2: sort by lastname, 3: show by class name, 4: add employee");
            string userInput = Console.ReadLine()!;

            Console.Clear();



            switch (Convert.ToInt32(userInput))
            {
                case 1:
                    studentHelpers.DisplayResults(studentHelpers.SortByFirstName());
                    break;
                case 2:
                    studentHelpers.DisplayResults(studentHelpers.SortByLastName());
                    break;
                case 3:
                    Console.WriteLine("Here are all the clases, search by the class name to get the students in that class");
                    studentHelpers.ShowAllClasses();
                    string input = Console.ReadLine()!;
                    studentHelpers.DisplayResults(studentHelpers.searchByClassName(input));
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("No input..");
                    break;

            }









        }
    }
}
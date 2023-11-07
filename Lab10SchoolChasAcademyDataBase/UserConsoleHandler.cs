namespace Lab10SchoolChasAcademyDataBase
{
    public class UserConsoleHandler
    {
        private readonly StudentHandler _studentManger;
        private readonly EmployeeHandler _empManager;

        public UserConsoleHandler(StudentHandler studentManger, EmployeeHandler empManager)
        {
            _studentManger = studentManger;
            _empManager = empManager;
        }


        public void Run()
        {
            int userChoice;

            do
            {
                userChoice = Choice();

                switch (userChoice)
                {
                    case 1:
                        _studentManger.ShowSelectedUserChoice(_studentManger.SortByFirstName());
                        break;
                    case 2:
                        _studentManger.ShowSelectedUserChoice(_studentManger.SortByLastName());
                        break;
                    case 3:
                        _studentManger.SearchInSpecificClass();
                        break;
                    case 4:
                        _empManager.PrintConsoleAddEmployee();
                        break;
                    case 5:
                        _empManager.ShowEmployee();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Enter a number between 1 and 5.");
                        break;
                }

                Console.WriteLine("Press any key to continue or ESC to exit.");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }


        private static int Choice()
        {
            int choice;

            do
            {
                Console.Clear();
                Console.Write("Enter 1 to Sort by firstname. " +
                    "\nEnter 2 to Sort by lastname. " +
                    "\nEnter 3 to Show by class name. " +
                    "\nEnter 4 to Add an employee." +
                    "\nEnter 5 to Show all employees.\n");

            } while (!int.TryParse(Console.ReadLine(), out choice));

            return choice;
        }



    }
}
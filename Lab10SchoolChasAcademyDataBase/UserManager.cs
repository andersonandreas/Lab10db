namespace Lab10SchoolChasAcademyDataBase
{
    public class UserManager
    {
        private readonly StudentManger _studentManger;
        private readonly EmpManager _empManager;


        public UserManager(StudentManger studentManger, EmpManager empManager)
        {
            _studentManger = studentManger;
            _empManager = empManager;

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

        public void PrintResultFromChoice()
        {
            int userChoice;

            do
            {
                userChoice = Choice();

                switch (userChoice)
                {
                    case 1:
                        // fixa en egen klass för utskrift
                        _studentManger.DisplayResults(_studentManger.SortByFirstName());
                        break;
                    case 2:
                        _studentManger.DisplayResults(_studentManger.SortByLastName());
                        break;
                    case 3:
                        _studentManger.InSameClass();
                        break;
                    case 4:
                        _empManager.CreateEmp();
                        break;
                    case 5:
                        _empManager.ShowEmp();
                        break;
                    default:
                        Console.WriteLine("Invalid Input. Enter a number between 1 and 5.");
                        break;
                }

                Console.WriteLine("Press any key to continue or N to exit.");

            } while (Console.ReadKey().Key != ConsoleKey.N);
        }

    }
}
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
                Console.Write("Type 1 to Sort by firstname. \nType 2 to Sort by lastname. \nType 3 to Show by class name. \nType 4 to Add an employee.\nType 5 to Show all employees.\n");

            } while (!int.TryParse(Console.ReadLine(), out choice));


            return choice;
        }


        public void PrintResultFromChoice()
        {
            var userChoice = Choice();

            switch (userChoice)
            {
                case 1:
                    // fix a own class for printing
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

            }

            var continueSearhing = ContinueSearching();

            if (continueSearhing)
            {
                PrintResultFromChoice();

            }

            return;
        }


        private static bool ContinueSearching()
        {

            string? input;

            do
            {
                Console.Write("Want to do so more searching? y/n: ");
                input = Console.ReadLine()?.Trim();

                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }

                continue;


            } while (true);

        }

    }
}
using Lab10SchoolChasAcademyDataBase.Models;

namespace Lab10SchoolChasAcademyDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolChasAcademyDbContext())
            {
                var student = new StudentManger(context);
                var emp = new EmpManager(context);

                bool continueApp = true;


                while (continueApp)
                {
                    Console.Clear();
                    Console.Write("Type 1 to Sort by firstname. \nType 2 to Sort by lastname. \nType 3 to Show by class name. \nType 4 to Add an employee.\nType 5 to Show all employees.\n");
                    string userInput = Console.ReadLine()!;

                    if (int.TryParse(userInput, out int input))
                    {

                        switch (input)
                        {
                            case 1:
                                student.DisplayResults(student.SortByFirstName());
                                break;
                            case 2:
                                student.DisplayResults(student.SortByLastName());
                                break;
                            case 3:
                                Console.WriteLine("Type the class name to Get back the students in that class.");
                                student.ShowAllClasses();
                                student.DisplayResults(student.searchByClassName(Console.ReadLine()!));
                                break;
                            case 4:
                                emp.CreateEmp();
                                break;
                            case 5:
                                emp.ShowEmp();
                                break;
                            default:
                                Console.WriteLine("No input..");
                                break;

                        }

                    }
                    else
                    {
                        Console.WriteLine("No valid input..");
                    }

                    Console.Write("Want to do so more searching? y/n: ");
                    string userChoice = Console.ReadLine();
                    if (userChoice?.Trim().ToLower() != "y")
                    {
                        continueApp = false;

                    }


                }




            }



        }


    }
}
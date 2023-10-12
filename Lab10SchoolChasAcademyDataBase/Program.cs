using Lab10SchoolChasAcademyDataBase.Models;

namespace Lab10SchoolChasAcademyDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolChasAcademyDbContext())
            {
                var studentHelpers = new StudentsHelperFunctions(context);

                bool continueApp = true;


                while (continueApp)
                {
                    Console.Clear();
                    Console.WriteLine("Enter the number for the that thing to do below: ");
                    Console.Write("1: sort by firstname \n2: sort by lastname \n3: show by class name \n4: add employee\n5: show employees in school\n");
                    string userInput = Console.ReadLine()!;


                    if (int.TryParse(userInput, out int input))
                    {

                        switch (input)
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
                                studentHelpers.DisplayResults(studentHelpers.searchByClassName(Console.ReadLine()!));
                                break;
                            case 4:
                                CreateEmp();
                                break;
                            case 5:
                                ShowEmp();
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

                    Console.Write("want to do so more searching? y/n: ");
                    string userChoice = Console.ReadLine();
                    if (userChoice?.Trim().ToLower() != "y")
                    {
                        continueApp = false;

                    }


                }

                void CreateEmp()
                {
                    Console.WriteLine("Enter firstname: ");
                    string fName = Console.ReadLine()!;
                    Console.WriteLine("Enter lastname: ");
                    string lName = Console.ReadLine()!;
                    Console.WriteLine("Enter your role: ");
                    string role = Console.ReadLine()!;

                    studentHelpers.AddEmployee(fName, lName, role);
                    Console.WriteLine("Employee added");


                }

                void ShowEmp()
                {
                    Console.WriteLine("\nEmployees in school:");
                    Console.WriteLine("-------------------------------------------");
                    foreach (var emp in context.Employees)
                    {
                        Console.WriteLine(emp);
                    }
                    Console.WriteLine("-------------------------------------------");
                }
            }



        }


    }
}
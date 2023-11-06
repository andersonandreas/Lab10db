using Lab10SchoolChasAcademyDataBase.Data;

namespace Lab10SchoolChasAcademyDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolChasAcademyDbContext())
            {

                try
                {
                    var student = new StudentHandler(context);
                    var employee = new EmployeeHandler(context);

                    var user = new UserHandler(student, employee);
                    user.Run();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong and the application is closing. " + ex.Message);
                }


            }



        }


    }

}
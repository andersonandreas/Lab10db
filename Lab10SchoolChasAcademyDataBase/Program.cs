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

                var user = new UserManager(student, emp);
                user.PrintResultFromChoice();





            }

        }

    }


}

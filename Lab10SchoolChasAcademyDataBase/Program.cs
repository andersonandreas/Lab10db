﻿using Lab10SchoolChasAcademyDataBase.Data;

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
                    var student = new StudentManger(context);
                    var emp = new EmpManager(context);

                    var user = new UserManager(student, emp);
                    user.PrintResultFromChoice();
                    Console.ReadKey();

                }
                catch (Exception ex)
                {

                    Console.WriteLine("Something went wrong and the application is closing. " + ex.Message);
                }

            }

        }

    }


}

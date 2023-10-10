using Lab10SchoolChasAcademyDataBase.Models;





namespace Lab10SchoolChasAcademyDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new SchoolChasAcademyDbContext();

            var allStudents = db.Students.ToList();

            foreach (var stud in allStudents)
            {
                Console.WriteLine(stud);
            }

            //        public int EmployeeId { get; set; }

            //public string? FirstName { get; set; }

            //public string? LastName { get; set; }

            //public string? EmployeeRole { get; set; }


            void addEmployee(string firstName, string lastName, string role)
            {




            }





            //var sortingS = db.Students.Where(s => s.StudentId > 5)
            //    .Select(i => new { i.PersonNumber, i.FirstName, i.LastName })
            //    .ToList();

            //foreach (var s in sortingS)
            //{
            //    Console.WriteLine($"{s.PersonNumber} {s.FirstName} {s.LastName}");
            //}


            //var allClasses = db.Students.Select(s => s.Class).ToList();

            //int count = 1;

            //foreach (var c in allClasses)
            //{
            //    Console.WriteLine($"{count}: {c}");
            //    count++;
            //}

            //Console.WriteLine();
            //Console.Write("Input the number for the class to get back all the students for that class:  ");

            //GetClassStudents(Convert.ToInt32(Console.ReadLine()));

            //void GetClassStudents(int classNum)
            //{
            //    if (classNum == 1)
            //    {
            //        var sortSClass = db.Students.Where(s => s.Class == "Fullstack .NET").ToList();
            //        Console.WriteLine();

            //        foreach (var stud in sortSClass)
            //        {
            //            Console.WriteLine(stud);
            //        }

            //    }



            //}



            ////string classInfo = "Fullstack .NET";

            ////var sortSClass = db.Students.Where(s => s.Class == classInfo).ToList();

            ////foreach (var stud in sortSClass)
            ////{
            ////    Console.WriteLine(stud);
            ////}






        }
    }
}
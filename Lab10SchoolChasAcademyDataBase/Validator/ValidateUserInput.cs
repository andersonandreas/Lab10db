using System.Text.RegularExpressions;

namespace Lab10SchoolChasAcademyDataBase.Validator
{
    public static class ValidateUserInput
    {

        public static string FirstName() =>
            ValidateInput("firstName", 2, 35);
        public static string LastName() =>
           ValidateInput("lastName", 2, 35);

        public static string EmployeeRole() =>
            ValidateInput("role", 2, 50);


        private static string ValidateInput(string promtUser, int minLength, int maxLength)
        {
            bool valid = false;
            string? input = string.Empty;

            while (!valid)
            {
                Console.Write($"Enter {promtUser}: ");

                input = Console.ReadLine().Trim();
                input = Regex.Replace(input, @"\s+", " ");

                if (!string.IsNullOrEmpty(input) && input.Length >= minLength && input.Length < maxLength && isAChar(input))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine($"This is not a valid {promtUser}: {input}");
                }

            }

            return input;
        }



        public static string InClassSearch()
        {
            string input = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            input = Regex.Replace(input, @"\s+", " ");
            return input;
        }


        // checking if the input is only letters with help of regular expression
        private static bool isAChar(string input) =>
            Regex.IsMatch(input, @"^[a-zA-Z\s]+$");


    }
}




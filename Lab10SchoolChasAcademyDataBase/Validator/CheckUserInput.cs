using System.Text.RegularExpressions;

namespace Lab10SchoolChasAcademyDataBase.Validator
{
    public static class CheckUserInput
    {

        public static string ValidateInput(string promtUser, int minLength, int maxLength)
        {
            bool valid = false;
            string? firstName = string.Empty;

            while (!valid)
            {
                Console.Write($"{promtUser}: ");
                string? input = Console.ReadLine()?.Trim();

                if (!string.IsNullOrEmpty(input) && input.Length >= minLength && input.Length < maxLength && isAChar(input))
                {
                    valid = true;
                    firstName = input;
                }
                else
                {
                    Console.WriteLine($"This is not a valid {promtUser}: {input}");
                }

            }

            return firstName;
        }


        public static string FirstName() =>
            ValidateInput("firstName", 2, 35);
        public static string LastName() =>
           ValidateInput("lastName", 2, 35);

        public static string EmployeeRole() =>
            ValidateInput("role", 2, 50);



        // checking if the input is only letters with help of regular expression
        private static bool isAChar(string input) =>
            Regex.IsMatch(input, @"^[a-zA-Z]+$");



    }
}




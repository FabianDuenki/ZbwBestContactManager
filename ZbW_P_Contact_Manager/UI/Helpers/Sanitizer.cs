using System.Net.Mail;
using System.Text.RegularExpressions;

namespace UI.Helpers
{
    class Sanitizer
    {
        /// <summary>
        /// Safely converts a string to integer
        /// </summary>
        /// <param name="input">String containing only numbers</param>
        /// <returns>The number representaton of the input</returns>
        public static int StringToInt(string input)
        {
            return input.Length > 0 && input.All(char.IsDigit) ? 
                Convert.ToInt32(input) : 
                0;
        }

        /// <summary>
        /// String containing only a single char
        /// </summary>
        /// <param name="input"></param>
        /// <returns>The char representation of the input</returns>
        public static char StringToChar(string input)
        {
            return input.Length > 0 ? input.First() : '\0';
        }

        /// <summary>
        /// Whether the email is a valid address
        /// </summary>
        /// <param name="email"></param>
        /// <returns>True or False depending on the assertion result</returns>
        public static bool IsEmailValid(string email)
        {
            return email.Length > 0 ? new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Match(email).Success : false;
        }
    }
}

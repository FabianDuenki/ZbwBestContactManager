using System.Collections;

namespace ZbW_P_Contact_Manager.Controller
{
    class AuthController
    {
        /// <summary>
        /// Fake table of users to log into the application
        /// </summary>
        private readonly Hashtable hashtable = new()
        {
            { "root", "admin" }
        };

        /// <summary>
        /// Checks whether a user exists within the "fake" internal storage
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="password">Password of the user</param>
        /// <returns>Whether the user exists</returns>
        public bool IsUserValid(string username, string password)
        {
            return hashtable.Contains(username) && hashtable[username] as string == password;
        }
    }
}

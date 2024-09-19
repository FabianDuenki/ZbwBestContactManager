using Model;

namespace ZbW_P_Contact_Manager.Controller
{
    /// <summary>
    /// Static class to manage the authentication of the user
    /// </summary>
    public static class AuthController
    {
        /// <summary>
        /// Fake table of users to log into the application
        /// </summary>
        private static readonly List<User> _users = new()
        {
            new ("fabian", "admin"),
            new ("jana", "admin"),
            new ("gianluca", "admin"),
            new ("pedro", "admin")
        };

        /// <summary>
        /// Current logged in user
        /// </summary>
        private static User? _user;

        /// <summary>
        /// Property to set user information only once
        /// </summary>
        public static User? User
        {
            get { return _user; }
            set
            {
                if (_user == null) _user = value;
            }
        }

        /// <summary>
        /// Checks whether a user exists within the "fake" internal storage
        /// </summary>
        /// <param name="username">Username of the user</param>
        /// <param name="password">Password of the user</param>
        /// <returns>Whether the user exists</returns>
        public static bool IsUserValid(string username, string password)
        {
            _user = _users.Find(user => user.GetFullName() == username && user.IsPasswordCorrect(password));
            return _user != null;
        }
    }
}

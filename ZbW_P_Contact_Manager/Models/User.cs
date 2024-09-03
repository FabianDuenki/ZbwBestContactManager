namespace Model
{
    class User(string username, string password)
    {
        /// <summary>
        /// Checks whether the password matches that of the instance
        /// </summary>
        /// <param name="input">password to match against</param>
        /// <returns>boolean representing whether it matches or not</returns>
        public bool IsPasswordCorrect(string input)
        {
            return input == password;
        }

        /// <summary>
        /// Gets the full name of the user
        /// </summary>
        /// <returns>The full name</returns>
        public string GetFullName()
        {
            return username;
        }
    }
}

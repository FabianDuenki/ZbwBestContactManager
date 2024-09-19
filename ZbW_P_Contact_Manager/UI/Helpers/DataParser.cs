namespace UI.Helpers
{
    /// <summary>
    /// DataParser class for parsing data
    /// </summary>
    public class DataParser
    {
        /// <summary>
        /// Converts a string to an int only if conversion is possible
        /// </summary>
        /// <param name="input"></param>
        /// <returns>int representation of the string or 0 if none</returns>
        public static int StringToSafeInt(string input)
        {
            if (input.Length <= 0 || !input.All(char.IsDigit)) return 0;
            return int.Parse(input);
        }
    }
}

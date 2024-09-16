namespace UI.Localization
{
    /// <summary>
    /// Error codes for system messages
    /// </summary>
    public enum Error
    {
        ModelMismatch = 0
    }

    /// <summary>
    /// System messages for error codes
    /// </summary>
    public class SystemMessage
    {
        public static string GetMessage(Error error)
        {
            return error switch
            {
                Error.ModelMismatch or _ => "Error: Models do not match!"
            };
        }
    }
}

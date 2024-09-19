namespace UI.Localization
{
    /// <summary>
    /// Error codes for system messages
    /// </summary>
    public enum Error
    {
        ModelMismatch = 0,
        ModelFileMissing = 1,
        Generic = 2,
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
                Error.ModelMismatch => "Error: Models do not match!",
                Error.ModelFileMissing => "Error: No models exist for this type!",
                Error.Generic or _ => "An unknown error occurred!"
            };
        }
    }
}

namespace UI.Localization
{
    public enum Error
    {
        ModelMismatch = 0
    }

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

namespace UI.AdministrationTools.Classes
{
    /// <summary>
    /// Class for creating a form
    /// </summary>
    public class CreateForm : Form
    {
        /// <summary>
        /// List of all required controls
        /// </summary>
        private readonly List<Control> _requiredControls = new();

        /// <summary>
        /// Model of the created object
        /// </summary>
        public object? model;

        /// <summary>
        /// Adds the unique control name to the list of required controls
        /// </summary>
        /// <param name="name">name of the control</param>
        /// <param name="type">type of the control</param>
        public void AddRequiredControls(Control[] controls)
        {
            foreach (Control control in controls)
            {
                _requiredControls.Add(control);
            }
        }

        /// <summary>
        /// Checks the validity of the form
        /// </summary>
        /// <returns>Whether the required controls of the form are valid</returns>
        public bool IsFormValid()
        {
            foreach (Control control in _requiredControls)
            {
                if (
                    control is CheckBox && !(control as CheckBox)!.Checked ||
                    control is not CheckBox && control.Text.Length <= 0
                ) return false;

            }
            return true;
        }
    }
}

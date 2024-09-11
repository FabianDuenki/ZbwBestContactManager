namespace External
{
    /// <summary>
    /// Static class to manage the file handling
    /// </summary>
    public static class FileHandler
    {
        /// <summary>
        /// Opens a file picker dialog and returns the selected file path
        /// </summary>
        /// <returns>FilePath</returns>
        public static string GetFilePathFromPicker()
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = "C:\\",
                Filter = "Text|*.csv|All|*.*",
                FilterIndex = 0,
                RestoreDirectory = true
            };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
        }

        /// <summary>
        /// Gets the text from a file path
        /// </summary>
        /// <param name="path"></param>
        /// <returns>FileText</returns>
        public static string GetTextFromFilePath(string path)
        {
            return path.Length > 0 ? File.ReadAllText(path) : string.Empty;
        }
    }
}

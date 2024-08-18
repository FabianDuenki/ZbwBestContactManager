namespace External
{
    public static class FileHandler
    {
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

        public static string GetTextFromFilePath(string path)
        {
            return path.Length > 0 ? File.ReadAllText(path) : string.Empty;
        }
    }
}

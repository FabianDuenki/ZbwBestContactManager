namespace External
{
    public static class FileHandler
    {
        public static string GetFilePathFromPicker()
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                InitialDirectory = "C:\\",
                Filter = "Text|*.txt|All|*.*",
                FilterIndex = 0,
                RestoreDirectory = true
            };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : string.Empty;
        }
    }
}

using External;
using Model.Operation;
using System.Text;

namespace Services
{
    public class Exporter<T>(T? instance) where T : class
    {
        public enum ExportType
        {
            CSV
        }

        private T? Instance { get; set; } = instance;

        public ExportStatus Export(ExportType type)
        {
            if (Instance is null) return ExportStatus.Error;
            string result = GetFormattedInstanceData(type);
            string fileName = $"{new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()}.{type.ToString().ToLower()}";
            string filePath = Path.Combine(SystemFolders.GetPath(SystemFolders.Folder.Downloads), fileName);
            CreateFile(result, filePath);
            return ExportStatus.Success;
        }

        private string GetFormattedInstanceData(ExportType type)
        {
            return type switch
            {
                ExportType.CSV or _ => string.Join("\n", Instance!.GetType()
                    .GetProperties()
                    .Select(propertyInfo => $"{propertyInfo.Name},{propertyInfo.GetValue(Instance)}")),
            };
        }

        public FileStatus CreateFile(string content, string path)
        {
            try
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(content);
                    fileStream.Write(info, 0, info.Length);
                }

                return FileStatus.Success;
            } 
            catch { return FileStatus.Error; }
        }

        public FileStatus DeleteFile(string path)
        {
            try
            {
                File.Delete(path);
                return FileStatus.Success;
            }
            catch { return FileStatus.Error; }
        }
    }
}

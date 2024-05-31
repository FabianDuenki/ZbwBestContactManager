using External;
using Model.Operation;
using System.Text;

namespace Services
{
    public class Exporter<T> where T : class
    {
        private T[]? Instances { get; set; }
        private T? Instance { get; set; }

        public enum ExportType
        {
            CSV
        }

        public Exporter(T? instance)
        {
            Instance = instance;
        }

        public Exporter(T[]? instances)
        {
            Instances = instances;
        }

        public ExportStatus Export(ExportType type)
        {
            if (Instances is not null) return MultipleExport(type, Instances);
            if (Instance is not null) return SingleExport(type, Instance);
            return ExportStatus.Error;
        }

        private ExportStatus SingleExport(ExportType type, T instance)
        {
            return SaveFileByType(type, string.Join(",", instance.GetType()
                .GetProperties()
                .Select(propertyInfo => propertyInfo.Name)) + $"\n{GetFormattedData(type, instance)}");
        }

        private ExportStatus MultipleExport(ExportType type, T[] instances)
        {
            return SaveFileByType(type, GetFormattedHeaders(type, instances.First()) + "\n" + string.Join("\n", instances
                .Select(instance => GetFormattedData(type, instance))));
        }

        private string GetFormattedData(ExportType type, T instance)
        {
            return type switch
            {
                ExportType.CSV or _ => string.Join(",", instance.GetType()
                    .GetProperties()
                    .Select(propertyInfo => propertyInfo.GetValue(instance))),
            };
        }

        private string GetFormattedHeaders(ExportType type, T instance)
        {
            return type switch
            {
                ExportType.CSV or _ => string.Join(",", instance.GetType().GetProperties().Select(propertyInfo => propertyInfo.Name))
            };
        }

        private ExportStatus SaveFileByType(ExportType type, string content)
        {
            string fileName = $"{new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()}.{type.ToString().ToLower()}";
            string filePath = Path.Combine(SystemFolders.GetPath(SystemFolders.Folder.Downloads), fileName);
            return CreateFile(content, filePath) == FileStatus.Success ? ExportStatus.Success : ExportStatus.Error;
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

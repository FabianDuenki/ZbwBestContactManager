using External;
using Model.Operation;
using System.Text;

namespace Controller
{
    public class CSVController<T> where T : class
    {
        private T[]? Instances { get; set; }
        private T? Instance { get; set; }

        public enum Format
        {
            CSV
        }

        public CSVController(T? instance)
        {
            Instance = instance;
        }

        public CSVController(T[]? instances)
        {
            Instances = instances;
        }

        public FormatStatus Export(Format type)
        {
            if (Instances is not null) return MultipleExport(type, Instances);
            if (Instance is not null) return SingleExport(type, Instance);
            return FormatStatus.Error;
        }

        public FormatStatus Import(Format type, string content)
        {
            return FormatStatus.Error;
        }

        public FormatStatus MultipleImport(Format type, string content)
        {
            return FormatStatus.Error;
        }

        private FormatStatus SingleExport(Format type, T instance)
        {
            return SaveFileByType(type, string.Join(",", instance.GetType()
                .GetProperties()
                .Select(propertyInfo => propertyInfo.Name)) + $"\n{GetFormattedData(type, instance)}");
        }

        private FormatStatus MultipleExport(Format type, T[] instances)
        {
            return SaveFileByType(type, GetFormattedHeaders(type, instances.First()) + "\n" + string.Join("\n", instances
                .Select(instance => GetFormattedData(type, instance))));
        }

        private string GetFormattedData(Format type, T instance)
        {
            return type switch
            {
                Format.CSV or _ => string.Join(",", instance.GetType()
                    .GetProperties()
                    .Select(propertyInfo => propertyInfo.GetValue(instance))),
            };
        }

        private string GetFormattedHeaders(Format type, T instance)
        {
            return type switch
            {
                Format.CSV or _ => string.Join(",", instance.GetType().GetProperties().Select(propertyInfo => propertyInfo.Name))
            };
        }

        private FormatStatus SaveFileByType(Format type, string content)
        {
            string fileName = $"{new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()}.{type.ToString().ToLower()}";
            string filePath = Path.Combine(SystemFolders.GetPath(SystemFolders.Folder.Downloads), fileName);
            return CreateFile(content, filePath) == FileStatus.Success ? FormatStatus.Success : FormatStatus.Error;
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

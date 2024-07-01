using External;
using Microsoft.VisualBasic.ApplicationServices;
using Model.Detail;
using Model.Operation;
using Model.Typing;
using System.Reflection;
using System.Text;

namespace Controller
{
    public class CSVController : ModelController
    {
        public object[]? Instances { get; set; }
        public object? Instance { get; set; }

        public CSVController() { }

        public CSVController(object instance)
        {
            Instance = instance;
        }

        public CSVController(object[] instances)
        {
            Instances = instances;
        }

        public FormatStatus Export(FileFormat type)
        {
            if (Instances != null) return MultipleExport(type, Instances);
            if (Instance != null) return SingleExport(type, Instance);
            return FormatStatus.Error;
        }

        public object[] Import(FileFormat type, ModelType model, string csvString)
        {
            string[] lines = csvString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string[] header = lines.First().Split(',', StringSplitOptions.None);
            string[] content = lines.Skip(1).ToArray();
            return content.Select(line => ImportModel(model, header, line.Split(','))).ToArray();
        }

        private object ImportModel(ModelType modelType, string[] header, string[] values)
        {
            object model = GetModelByType(modelType);
            PropertyInfo[] properties = model.GetType().GetProperties();
            Array.ForEach(properties, property => property.SetValue(model, ConvertStringToType(values[Array.IndexOf(header, property.Name)], property.PropertyType)));
            return model;
        }

        private object? ConvertStringToType(string value, Type type)
        {
            if (value.Length <= 0) return null;

            Type? nullableType = Nullable.GetUnderlyingType(type);

            if (nullableType == typeof(int))
            {
                return int.Parse(value);
            }
            else if (nullableType == typeof(bool))
            {
                return bool.Parse(value);
            }
            else if (nullableType == typeof(char))
            {
                return char.Parse(value);
            }
            else if (nullableType == typeof(Guid))
            {
                return Guid.Parse(value);
            } 
            else if (nullableType == typeof(System.DateTime))
            {
                return DateTime.Parse(value);
            }

            return value;
        }

        private FormatStatus SingleExport(FileFormat type, object instance)
        {
            return SaveFileByType(type, string.Join(",", instance.GetType()
                .GetProperties()
                .Select(propertyInfo => propertyInfo.Name)) + $"\n{GetFormattedData(type, instance)}");
        }

        private FormatStatus MultipleExport(FileFormat type, object[] instances)
        {
            return SaveFileByType(type, GetFormattedHeaders(type, instances.First()) + "\n" + string.Join("\n", instances
                .Select(instance => GetFormattedData(type, instance))));
        }

        private string GetFormattedData(FileFormat type, object instance)
        {
            return type switch
            {
                FileFormat.CSV or _ => string.Join(",", instance.GetType()
                    .GetProperties()
                    .Select(propertyInfo => propertyInfo.GetValue(instance))),
            };
        }

        private string GetFormattedHeaders(FileFormat type, object instance)
        {
            return type switch
            {
                FileFormat.CSV or _ => string.Join(",", instance.GetType().GetProperties().Select(propertyInfo => propertyInfo.Name))
            };
        }

        private FormatStatus SaveFileByType(FileFormat type, string content)
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



        public bool AddUser(ModelType modelType, object user)
        {
            string csvUser = ConvertUserToCsvString(user);
            string filePath = GetPathByModelType(modelType);

            if (!Path.Exists(filePath))
            {
                CreateFile(filePath, user);
            }
            File.AppendAllText(filePath, Environment.NewLine);
            File.AppendAllText(filePath, csvUser);

            return true;

        }
        public string GetPathByModelType(ModelType modelType)
        {
            string fileName = $"{modelType.ToString()}.csv";
            return $"{Environment.CurrentDirectory}\\{fileName}";
        }
        public string ConvertUserToCsvString(object user)
        {
            string csvString = null;
            foreach(PropertyInfo property in user.GetType().GetProperties())
            {
                csvString += $"{property.GetValue(user)},";
            }
            return csvString;
        }
        public bool CreateFile(string filePath, object user)
        {
            string csvHeader = null;

            foreach (PropertyInfo property in user.GetType().GetProperties())
            {
                csvHeader += $"{property.Name},";
            }

            File.AppendAllText(filePath, csvHeader);

            return true;
        }

        public List<UserDetails> ReadUsers(ModelType modelType)
        {
            string filePath = GetPathByModelType(modelType);
            List<UserDetails> users = new List<UserDetails>();

            if (!Path.Exists(filePath))
            {
                return new List<UserDetails>();
            }
            string[] csvLines = File.ReadAllLines(filePath);

            users = ConvertCsvStringToUsers(modelType, csvLines);


            return users;
        }
        public List<UserDetails> ConvertCsvStringToUsers(ModelType modelType, string[] csvLines)
        {
            List<UserDetails> users = new List<UserDetails>();

            string[] csvHeader = (csvLines.First()).Split(',');
            string[] csvUsers = csvLines.Skip(0).ToArray();

            foreach (string csvUser in csvUsers)
            {
                UserDetails user = new UserDetails();
                string[] csvUserValues = csvUser.Split(',');

                foreach(string property in csvHeader)
                {
                    user
                    .GetType()
                    .GetProperty(property)
                    .SetValue(user, csvUserValues[Array.IndexOf(csvHeader, property)]);
                }
                users.Add(user);
            }
            return users;
        }
        public bool UpdateUser(ModelType modelType, UserDetails oldUser, UserDetails newUser)
        {
            string filePath = GetPathByModelType(modelType);

            return false;
        }
        public bool DeleteUser(ModelType modelType, UserDetails user)
        {
            string filePath = GetPathByModelType(modelType);

            return false;
        }
    }
}

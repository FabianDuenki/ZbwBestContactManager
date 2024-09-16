using External;
using Model;
using Model.Typing;
using System.Reflection;

namespace Controller
{
    /// <summary>
    /// CSVController is responsible for handling data and exporting/importing CSV files.
    /// </summary>
    public class CSVController : ModelController
    {
        /// <summary>
        /// Instances is an array of objects that will be exported.
        /// </summary>
        public object[]? Instances { get; set; }

        /// <summary>
        /// Instance is a single object that will be exported.
        /// </summary>
        public object? Instance { get; set; }

        /// <summary>
        /// CSVController constructor.
        /// </summary>
        public CSVController() { }

        /// <summary>
        /// CSVController constructor with an instance.
        /// </summary>
        /// <param name="instance"></param>
        public CSVController(object instance)
        {
            Instance = instance;
        }

        /// <summary>
        /// CSVController constructor with an array of instances.
        /// </summary>
        /// <param name="instances"></param>
        public CSVController(object[] instances)
        {
            Instances = instances;
        }

        /// <summary>
        /// Export data to a file.
        /// </summary>
        /// <param name="type"></param>
        public void Export(FileFormat type)
        {
            if (Instances != null) MultipleExport(type, Instances);
            if (Instance != null) SingleExport(type, Instance);
        }

        /// <summary>
        /// Import data from a file.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="csvString"></param>
        /// <returns>Object</returns>
        public object[] Import(ModelType model, string csvString)
        {
            string[] header = GetFileHeader(csvString);
            string[] lines = csvString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
            string[] content = lines.Skip(1).ToArray();
            return content.Select(line => ImportModel(model, header, line.Split(','))).ToArray();
        }

        /// <summary>
        /// This method imports a model.
        /// </summary>
        /// <param name="modelType"></param>
        /// <param name="header"></param>
        /// <param name="values"></param>
        /// <returns>Object</returns>
        private object ImportModel(ModelType modelType, string[] header, string[] values)
        {
            object model = GetModelByType(modelType);
            PropertyInfo[] properties = model.GetType().GetProperties();
            Array.ForEach(properties, property => property.SetValue(model, ConvertStringToType(values[Array.IndexOf(header, property.Name)], property.PropertyType)));
            return model;
        }

        /// <summary>
        /// Get the file header from a CSV string.
        /// </summary>
        /// <param name="csvString"></param>
        /// <returns>The CSV string</returns>
        private string[] GetFileHeader(string csvString)
        {
            return csvString.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None)
                .First()
                .Split(',', StringSplitOptions.None);
        }

        /// <summary>
        /// Check if two headers are equal.
        /// </summary>
        /// <param name="header1"></param>
        /// <param name="header2"></param>
        /// <returns>Boolean if header is equal</returns>
        public bool IsHeaderEqual(string header1, string header2)
        {
            return GetFileHeader(header1)
                .All(field => GetFileHeader(header2)
                .Contains(field));
        }

        /// <summary>
        /// Convert a string to a type.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="type"></param>
        /// <returns>The converted type</returns>
        private object? ConvertStringToType(string value, Type type)
        {
            if (value.Length <= 0) return null;

            if (type == typeof(int?))
            {
                return int.Parse(value);
            }
            else if (type == typeof(bool?))
            {
                return bool.Parse(value);
            }
            else if (type == typeof(char))
            {
                return char.Parse(value);
            }
            else if (type == typeof(Guid) || type == typeof(Guid?))
            {
                return Guid.Parse(value);
            }
            else if (type == typeof(DateTime?))
            {
                return DateTime.Parse(value);
            }

            return value;
        }

        /// <summary>
        /// Single export method.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="instance"></param>
        private void SingleExport(FileFormat type, object instance)
        {
            SaveFileByType(type, string.Join(",", instance.GetType()
                .GetProperties()
                .Select(propertyInfo => propertyInfo.Name)) + $"\n{GetFormattedData(type, instance)}");
        }

        /// <summary>
        /// Multiple export method.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="instances"></param>
        private void MultipleExport(FileFormat type, object[] instances)
        {
            SaveFileByType(type, GetFormattedHeaders(type, instances.First()) + "\n" + string.Join("\n", instances
                .Select(instance => GetFormattedData(type, instance))));
        }

        /// <summary>
        /// Get formatted data.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="instance"></param>
        /// <returns>Formatted data as string</returns>
        private string GetFormattedData(FileFormat type, object instance)
        {
            return type switch
            {
                FileFormat.CSV or _ => string.Join(",", instance.GetType()
                    .GetProperties()
                    .Select(propertyInfo => propertyInfo.GetValue(instance))),
            };
        }

        /// <summary>
        /// Get formatted headers.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="instance"></param>
        /// <returns>Formatted headers as string</returns>
        private string GetFormattedHeaders(FileFormat type, object instance)
        {
            return type switch
            {
                FileFormat.CSV or _ => string.Join(",", instance.GetType().GetProperties().Select(propertyInfo => propertyInfo.Name))
            };
        }

        /// <summary>
        /// Save file by type.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content"></param>
        private void SaveFileByType(FileFormat type, string content)
        {
            string fileName = $"{new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()}.{type.ToString().ToLower()}";
            string filePath = Path.Combine(SystemFolders.GetPath(SystemFolders.Folder.Downloads), fileName);
            CreateFile(filePath, content);
        }

        /// <summary>
        /// Get model by type.
        /// </summary>
        /// <param name="userType"></param>
        /// <returns>Model</returns>
        public string GetPathByModelType(Type userType)
        {
            string fileName = $"{userType.Name}.csv";
            return $"{Environment.CurrentDirectory}\\{fileName}";
        }

        /// <summary>
        /// Creates a file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="csvHeader"></param>
        public void CreateFile(string filePath, string csvHeader)
        {
            File.AppendAllText(filePath, csvHeader);
        }

        /// <summary>
        /// Adds a line to a file.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="line"></param>
        public void AddLine(string filePath, string line)
        {
            File.AppendAllText(filePath, Environment.NewLine);
            File.AppendAllText(filePath, line);
        }

        /// <summary>
        /// Deletes a file.
        /// </summary>
        /// <param name="path"></param>
        public void DeleteFile(string path)
        {
            File.Delete(path);
        }

        /// <summary>
        /// Adds a user to the CSV file.
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(Person user)
        {
            string filePath = GetPathByModelType(user.GetType());

            if (!Path.Exists(filePath))
            {
                CreateFile(filePath, user.ToCsvHeader());
            }
            AddLine(filePath, user.ToCsvString());
        }

        /// <summary>
        /// Adds a note to the CSV file.
        /// </summary>
        /// <param name="note"></param>
        public void AddNote(Note note)
        {
            string filePath = GetPathByModelType(note.GetType());

            if (!Path.Exists(filePath))
            {
                CreateFile(filePath, note.ToCsvHeader());
            }
            AddLine(filePath, note.ToCsvString());
        }

        /// <summary>
        /// Reads users from the CSV file.
        /// </summary>
        /// <param name="user"></param>
        /// <returns>List of people</returns>
        public List<Person> ReadUsers(Person user)
        {
            string filePath = GetPathByModelType(user.GetType());
            List<Person> userList = new();

            if (!Path.Exists(filePath)) return userList;

            string[] csvUsers = File.ReadAllLines(filePath);

            foreach (string csvUser in csvUsers)
            {
                if (csvUser == user.ToCsvHeader() || string.IsNullOrEmpty(csvUser)) continue;
                userList.Add(user.FromCsvString(csvUser));
            }
            return userList;
        }

        /// <summary>
        /// Reads notes from the CSV file.
        /// </summary>
        /// <returns></returns>
        public List<Note> ReadNotes()
        {
            Note note = new Note();
            string filePath = GetPathByModelType(note.GetType());
            List<Note> noteList = new();

            if (!Path.Exists(filePath)) return noteList;

            string[] csvNotes = File.ReadAllLines(filePath);

            foreach (string csvNote in csvNotes)
            {
                if (csvNote == note.ToCsvHeader()) continue;
                noteList.Add(note.FromCsvString(csvNote));
            }
            return noteList;
        }

        /// <summary>
        /// Updates a user in the CSV file.
        /// </summary>
        /// <param name="newUser"></param>
        public void UpdateUser(Person newUser)
        {
            string filePath = GetPathByModelType(newUser.GetType());
            List<Person> users = ReadUsers(newUser);

            File.Delete(filePath);

            foreach (Person user in users)
            {
                if (user.Id == newUser.Id) AddUser(newUser);
                else AddUser(user);
            }
        }

        /// <summary>
        /// Updates a note in the CSV file.
        /// </summary>
        /// <param name="newNote"></param>
        public void UpdateNote(Note newNote)
        {
            string filePath = GetPathByModelType(newNote.GetType());
            List<Note> notes = ReadNotes();

            File.Delete(filePath);

            foreach (Note note in notes)
            {
                if (note.Id == newNote.Id)
                {
                    note.Comment = newNote.Comment;
                }
                AddNote(note);
            }
        }

        /// <summary>
        /// Deletes a user from the CSV file.
        /// </summary>
        /// <param name="deletionUser"></param>
        public void DeleteUser(Person deletionUser)
        {
            string filePath = GetPathByModelType(deletionUser.GetType());
            List<Person> users = ReadUsers(deletionUser);

            File.Delete(filePath);

            foreach (Person user in users)
            {
                if (user.Id != deletionUser.Id) AddUser(user);
            }
        }

        /// <summary>
        /// Deletes a note from the CSV file.
        /// </summary>
        /// <param name="deletionNote"></param>
        public void DeleteNote(Note deletionNote)
        {
            string filePath = GetPathByModelType(deletionNote.GetType());
            List<Note> notes = ReadNotes();

            File.Delete(filePath);

            foreach (Note note in notes)
            {
                if (note.Id != deletionNote.Id) AddNote(note);
            }
        }
    }
}

using External;
using Microsoft.VisualBasic.ApplicationServices;
using Model;
using Model.Detail;
using Model.Operation;
using Model.Typing;
using System.Collections;
using System.Reflection;
using System.Text;
using ZbW_P_Contact_Manager;

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

        public void Export(FileFormat type)
        {
            if (Instances != null) MultipleExport(type, Instances);
            if (Instance != null) SingleExport(type, Instance);
        }

        public object[] Import(ModelType model, string csvString)
        {
            string[] header = GetFileHeader(csvString);
            string[] lines = csvString.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
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

        private string[] GetFileHeader(string csvString)
        {
            return csvString.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None)
                .First()
                .Split(',', StringSplitOptions.None);
        }

        public bool IsHeaderEqual(string header1, string header2)
        {
            return GetFileHeader(header1)
                .All(field => GetFileHeader(header2)
                .Contains(field));
        }

        private object? ConvertStringToType(string value, Type type)
        {
            if (value.Length <= 0) return null;

            if (type == typeof(int))
            {
                return int.Parse(value);
            }
            else if (type == typeof(bool))
            {
                return bool.Parse(value);
            }
            else if (type == typeof(char))
            {
                return char.Parse(value);
            }
            else if (type == typeof(Guid))
            {
                return Guid.Parse(value);
            } 
            else if (type == typeof(System.DateTime))
            {
                return DateTime.Parse(value);
            }

            return value;
        }

        private void SingleExport(FileFormat type, object instance)
        {
            SaveFileByType(type, string.Join(",", instance.GetType()
                .GetProperties()
                .Select(propertyInfo => propertyInfo.Name)) + $"\n{GetFormattedData(type, instance)}");
        }

        private void MultipleExport(FileFormat type, object[] instances)
        {
            SaveFileByType(type, GetFormattedHeaders(type, instances.First()) + "\n" + string.Join("\n", instances
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

        private void SaveFileByType(FileFormat type, string content)
        {
            string fileName = $"{new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds()}.{type.ToString().ToLower()}";
            string filePath = Path.Combine(SystemFolders.GetPath(SystemFolders.Folder.Downloads), fileName);
            CreateFile(filePath, content);
        }
        public string GetPathByModelType(Type userType)
        {
            string fileName = $"{userType.Name}.csv";
            return $"{Environment.CurrentDirectory}\\{fileName}";
        }
        public void CreateFile(string filePath, string csvHeader)
        {
            File.AppendAllText(filePath, csvHeader);
        }
        public void AddLine(string filePath, string line)
        {
            File.AppendAllText(filePath, Environment.NewLine);
            File.AppendAllText(filePath, line);
        }
        public void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public void AddUser(Person user)
        {
            string filePath = GetPathByModelType(user.GetType());

            if (!Path.Exists(filePath))
            {
                CreateFile(filePath, user.ToCsvHeader());
            }
            AddLine(filePath, user.ToCsvString());
        }

        public void AddNote(Note note)
        {
            string filePath = GetPathByModelType(note.GetType());

            if (!Path.Exists(filePath))
            {
                CreateFile(filePath, note.ToCsvHeader());
            }
            AddLine(filePath, note.ToCsvString());
        }
        public List<Person> ReadUsers(Person user)
        {
            string filePath = GetPathByModelType(user.GetType());
            List<Person> userList = new();
            string[] csvUsers = File.ReadAllLines(filePath);

            if (!Path.Exists(filePath)) return userList;

            foreach (string csvUser in csvUsers)
            {
                if(csvUser == user.ToCsvHeader() || string.IsNullOrEmpty(csvUser)) continue;
                userList.Add(user.FromCsvString(csvUser));
            }
            return userList;
        }
        public List<Note> ReadNotes()
        {
            Note note = new Note();
            string filePath = GetPathByModelType(note.GetType());
            List<Note> noteList = new();
            string[] csvNotes = File.ReadAllLines(filePath);

            if (!Path.Exists(filePath)) return noteList;

            foreach (string csvNote in csvNotes)
            {
                if (csvNote == note.ToCsvHeader()) continue;
                noteList.Add(note.FromCsvString(csvNote));
            }
            return noteList;
        }
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
                    note.UpdatedBy = newNote.UpdatedBy;
                    note.UpdatedAt = newNote.UpdatedAt;
                }
                AddNote(note);
            }
        }
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

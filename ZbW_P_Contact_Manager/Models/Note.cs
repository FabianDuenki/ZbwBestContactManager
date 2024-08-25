using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace Model
{
    public class Note
    {
        public Guid Id { get; set; }

        public string? Comment { get; set; }

        public Guid PersonId { get; set; }

        public DateTime? CreatedAt { get; set; }
               
        public string? CreatedBy { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string? UpdatedBy { get; set; }

        public object GetInstanceFromHashtable(Hashtable hashtable)
        {
            object instance = Activator.CreateInstance(GetType())!;
            foreach (DictionaryEntry entry in hashtable)
            {
                PropertyInfo property = instance.GetType().GetProperty(entry.Key.ToString()!)!;
                object convertedValue = TypeDescriptor.GetConverter(property.PropertyType).ConvertFrom(entry.Value!)!;
                property.SetValue(instance, convertedValue);
            }
            return instance;
        }
        public string ToCsvHeader()
        {
            return
                "Id," +
                "Comment," +
                "PersonId," +
                "CreatedAt," +
                "CreatedBy," +
                "UpdatedAt," +
                "UpdatedBy";
        }
        public string ToCsvString()
        {
            return
                $"{this.Id.ToString()}," +
                $"{this.Comment}," +
                $"{this.PersonId.ToString()}," +
                $"{this.CreatedAt.ToString()}," +
                $"{this.CreatedBy}," +
                $"{this.UpdatedAt.ToString()}," +
                $"{this.UpdatedBy}";
        }
        public Note FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');

            Note note = new Note
            {
                Id = Guid.Parse(propertyValues[0]),
                Comment = propertyValues[1],
                PersonId = Guid.Parse(propertyValues[2]),
                CreatedAt = DateTime.Parse(propertyValues[3]),
                CreatedBy = propertyValues[4],
                UpdatedAt = DateTime.Parse(propertyValues[5]),
                UpdatedBy = propertyValues[6]
            };
            return note;
        }
    }
}

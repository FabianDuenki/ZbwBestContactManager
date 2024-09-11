using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace Model
{

    /// <summary>
    /// Note class to store notes for a person
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Note Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Comment of the note
        /// </summary>
        public string? Comment { get; set; }

        /// <summary>
        /// Person Id the note is related to
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Creation date of the note
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Created by user
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Gets an instance of the Note class from a Hashtable
        /// </summary>
        /// <param name="hashtable"></param>
        /// <returns>Object</returns>
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

        /// <summary>
        /// Transforms the Note object to a CSV string
        /// </summary>
        /// <returns>Csv string</returns>
        public string ToCsvHeader()
        {
            return
                "Id," +
                "Comment," +
                "PersonId," +
                "CreatedAt," +
                "CreatedBy";
        }

        /// <summary>
        /// Transforms the Note object to a CSV string
        /// </summary>
        /// <returns>Csv string</returns>
        public string ToCsvString()
        {
            return
                $"{this.Id.ToString()}," +
                $"{this.Comment}," +
                $"{this.PersonId.ToString()}," +
                $"{this.CreatedAt.ToString()}," +
                $"{this.CreatedBy}";
        }

        /// <summary>
        /// Transforms a CSV string to a Note object
        /// </summary>
        /// <param name="csvString"></param>
        /// <returns>Note object</returns>
        public Note FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');

            Note note = new Note
            {
                Id = Guid.Parse(propertyValues[0]),
                Comment = propertyValues[1],
                PersonId = Guid.Parse(propertyValues[2]),
                CreatedAt = DateTime.Parse(propertyValues[3]),
                CreatedBy = propertyValues[4]
            };
            return note;
        }
    }
}

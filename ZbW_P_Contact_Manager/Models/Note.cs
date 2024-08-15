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
    }
}

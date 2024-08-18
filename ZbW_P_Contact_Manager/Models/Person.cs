using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace Model
{
    public class Person
    {
        public Guid Id { get; set; }
        public string? Salutation { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Title { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public string? PhoneNumberPrivate { get; set; }
        public string? PhoneNumberMobile { get; set; }
        public string? PhoneNumberBusiness { get; set; }
        public string? Email { get; set; }
        public bool? Status { get; set; }
        public string? Nationality { get; set; }
        public string? Street { get; set; }
        public string? StreetNumber { get; set; }
        public int? ZipCode { get; set; }
        public string? Place { get; set; }

        /// <summary>
        /// Converts a Hashtable to an object containing the same keys and values
        /// </summary>
        /// <param name="hashtable">Hashtable containing model information</param>
        /// <returns>A new object with the properties set</returns>
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
        public virtual string ToCsvString()
        {
            return
                $"{this.Id.ToString()}," +
                $"{this.Salutation}," +
                $"{this.FirstName}," +
                $"{this.LastName}," +
                $"{this.DateOfBirth.ToString()}," +
                $"{this.Gender}," +
                $"{this.Title}," +
                $"{this.SocialSecurityNumber}," +
                $"{this.PhoneNumberPrivate}," +
                $"{this.PhoneNumberMobile}," +
                $"{this.PhoneNumberBusiness}," +
                $"{this.Email}," +
                $"{this.Status.ToString()}," +
                $"{this.Nationality}," +
                $"{this.Street}," +
                $"{this.StreetNumber}," +
                $"{this.ZipCode}," +
                $"{this.Place}";
        }
        public virtual string ToCsvHeader()
        {
            return
                "Id," +
                "Salutation," +
                "FirstName," +
                "LastName," +
                "DateOfBirth," +
                "Gender," +
                "Title," +
                "SocialSecurityNumber," +
                "PhoneNumberPrivate," +
                "PhoneNumberMobile," +
                "PhoneNumberBusiness," +
                "Email," +
                "Status," +
                "Nationality," +
                "Street," +
                "StreetNumber," +
                "ZipCode," +
                "Place";
        }
    }
}

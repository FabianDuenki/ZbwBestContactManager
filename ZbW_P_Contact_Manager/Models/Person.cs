using System.Collections;
using System.ComponentModel;
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
        public bool Contains(Person other)
        {
            if (other.Id != Guid.Empty && other.Id != this.Id) return false;
            if (other.Salutation != null && other.Salutation != this.Salutation) return false;
            if (other.FirstName != null && other.FirstName != this.FirstName) return false;
            if (other.LastName != null && other.LastName != this.LastName) return false;
            if (other.DateOfBirth != null && other.DateOfBirth != this.DateOfBirth) return false;
            if (other.Gender != null && other.Gender != this.Gender) return false;
            if (other.Title != null && other.Title != this.Title) return false;
            if (other.SocialSecurityNumber != null && other.SocialSecurityNumber != this.SocialSecurityNumber) return false;
            if (other.PhoneNumberPrivate != null && other.PhoneNumberPrivate != this.PhoneNumberPrivate) return false;
            if (other.PhoneNumberMobile != null && other.PhoneNumberMobile != this.PhoneNumberMobile) return false;
            if (other.PhoneNumberBusiness != null && other.PhoneNumberBusiness != this.PhoneNumberBusiness) return false;
            if (other.Email != null && other.Email != this.Email) return false;
            if (other.Status != null && other.Status != this.Status) return false;
            if (other.Nationality != null && other.Nationality != this.Nationality) return false;
            if (other.Street != null && other.Street != this.Street) return false;
            if (other.StreetNumber != null && other.StreetNumber != this.StreetNumber) return false;
            if (other.ZipCode != null && other.ZipCode != this.ZipCode) return false;
            if (other.Place != null && other.Place != this.Place) return false;
            return true;
        }
        public virtual Person FromCsvString(string csvString)
        {
            string[] propertyValues = csvString.Split(',');
            Person user = new Person();

            user.Id = Guid.Parse(propertyValues[0]);
            user.Salutation = propertyValues[1];
            user.FirstName = propertyValues[2];
            user.LastName = propertyValues[3];
            if (!String.IsNullOrEmpty(propertyValues[4])) user.DateOfBirth = DateTime.Parse(propertyValues[4]);
            user.Gender = propertyValues[5];
            user.Title = propertyValues[6];
            user.SocialSecurityNumber = propertyValues[7];
            user.PhoneNumberPrivate = propertyValues[8];
            user.PhoneNumberMobile = propertyValues[9];
            user.PhoneNumberBusiness = propertyValues[10];
            user.Email = propertyValues[11];
            user.Status = bool.Parse(propertyValues[12]);
            user.Nationality = propertyValues[13];
            user.Street = propertyValues[14];
            user.StreetNumber = propertyValues[15];
            user.ZipCode = int.Parse(propertyValues[16]);
            user.Place = propertyValues[17];

            return user;
        }
    }
}

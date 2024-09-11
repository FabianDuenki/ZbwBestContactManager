using System.Collections;
using System.ComponentModel;
using System.Reflection;

namespace Model
{
    /// <summary>
    /// Represents a person with all its properties
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Unique identifier of the person
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Salutation
        /// </summary>
        public string? Salutation { get; set; }

        /// <summary>
        /// First name
        /// </summary>
        public string? FirstName { get; set; }

        /// <summary>
        /// Last name
        /// </summary>
        public string? LastName { get; set; }

        /// <summary>
        /// Date of birth
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Social security number
        /// </summary>
        public string? SocialSecurityNumber { get; set; }

        /// <summary>
        /// Phone number private
        /// </summary>
        public string? PhoneNumberPrivate { get; set; }

        /// <summary>
        /// Phone number mobile
        /// </summary>
        public string? PhoneNumberMobile { get; set; }

        /// <summary>
        /// Phone number business
        /// </summary>
        public string? PhoneNumberBusiness { get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Status of the person
        /// </summary>
        public bool? Status { get; set; }

        /// <summary>
        /// Nationality
        /// </summary>
        public string? Nationality { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        public string? Street { get; set; }

        /// <summary>
        /// Street number
        /// </summary>
        public string? StreetNumber { get; set; }

        /// <summary>
        /// Zip code
        /// </summary>
        public int? ZipCode { get; set; }

        /// <summary>
        /// Place
        /// </summary>
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

        /// <summary>
        /// Converts to a Csv strin
        /// </summary>
        /// <returns>Csv Strin</returns>
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

        /// <summary>
        /// Converts to a Csv header
        /// </summary>
        /// <returns>Csv header</returns>
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

        /// <summary>
        /// Checks if the person contains the other person
        /// </summary>
        /// <param name="other"></param>
        /// <returns>Boolean</returns>
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

        /// <summary>
        /// Creates a person from a csv string
        /// </summary>
        /// <param name="csvString"></param>
        /// <returns>Person object</returns>
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

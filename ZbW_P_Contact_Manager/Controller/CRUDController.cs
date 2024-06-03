using Model;
using Services;
using Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using System.Reflection.Metadata;
using External;
using Microsoft.VisualBasic.FileIO;

namespace Controller
{
    internal class CRUDController
    {
        public static Person CreatePerson(PersonDetails person)
        {
            var exporter = new Exporter<Person>(new Person(person));
            string fileName = person.GetType().Name + ".csv";

            if (string.IsNullOrEmpty(person.Salutation))
            {
                throw new ArgumentException($"'{nameof(person.Salutation)}' cannot be null or empty.", nameof(person.Salutation));
            }

            if (string.IsNullOrEmpty(person.FirstName))
            {
                throw new ArgumentException($"'{nameof(person.FirstName)}' cannot be null or empty.", nameof(person.FirstName));
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                throw new ArgumentException($"'{nameof(person.LastName)}' cannot be null or empty.", nameof(person.LastName));
            }

            if (string.IsNullOrEmpty(person.Gender))
            {
                throw new ArgumentException($"'{nameof(person.Gender)}' cannot be null or empty.", nameof(person.Gender));
            }

            if (!File.Exists(fileName))
            {
                File.WriteAllText(fileName, CreateCsvHeader());
            }
            File.AppendAllText(fileName, PersonToString(person));
            return new Person(person);
        }
        public static Person ReadPerson(PersonDetails person)
        {
            return new Person(person);
        }
        public static Person UpdatePerson(PersonDetails person)
        {
            return new Person(person);
        }
        public static bool DeletePerson(PersonDetails person)
        {
            
            return true;
        }
        private static string CreateCsvHeader()
        {
            return 
                "\"Salutation\"," +
                "\"FirstName\"," +
                "\"LastName\"," +
                "\"DateOfBirth\"," +
                "\"Gender\"," +
                "\"Title\"," +
                "\"SocialSecurityNumber\"," +
                "\"PhoneNumberPrivate\"," +
                "\"PhoneNumberMobile\"," +
                "\"PhoneNumberBusiness\"," +
                "\"Email\"," +
                "\"Status\"," +
                "\"Nationality\"," +
                "\"Street\"," +
                "\"StreetNumber\"," +
                "\"ZipCode\"," +
                "\"Place\"," + Environment.NewLine;
        }
        private static string PersonToString(PersonDetails person)
        {
            return
                person.Salutation + "," +
                person.FirstName + "," +
                person.LastName + "," +
                person.DateOfBirth + "," +
                person.Gender + "," +
                person.Title + "," +
                person.SocialSecurityNumber + "," +
                person.PhoneNumberPrivate + "," +
                person.PhoneNumberMobile + "," +
                person.PhoneNumberBusiness + "," +
                person.Email + "," +
                person.Status + "," +
                person.Nationality + "," +
                person.Street + "," +
                person.StreetNumber + "," +
                person.ZipCode + "," +
                person.Place + Environment.NewLine;
        }
    }
}

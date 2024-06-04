using Model;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using External;
using Microsoft.VisualBasic.FileIO;

namespace Controller
{
    internal class CRUDController
    {
        public static Person CreatePerson(Person person)
        {
            var exporter = new Exporter<Person>(person);
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
                File.WriteAllText(fileName, CsvHeader());
            }

            AppendFile(fileName, person);

            return person;
        }
        public static Person ReadPerson(Person person)
        {
            return person;
        }
        public static Person UpdatePerson(Person person)
        {
            return person;
        }
        public static bool DeletePerson(Person person)
        {
            if(person.FirstName == null || person.LastName == null)
            {
                throw new ArgumentException("Please Enter the lastname and firstname of the person to be deleted");
            }

            string fileName = person.GetType().Name + ".csv";

            string[] fileContent = File.ReadAllLines(fileName);

            foreach(string line in fileContent)
            {
                if (line.Contains(person.FirstName) && line.Contains(person.LastName))
                {
                    fileContent = fileContent.Where(val => val != line).ToArray();
                    File.WriteAllLines(fileName, fileContent);
                    return true;
                }
            }
            return true;
        }
        private static void AppendFile(string fileName, Person person)
        {
            try
            {
                File.AppendAllText(fileName, PersonToCsvString(person));
            }
            catch (IOException)
            {
                Console.WriteLine("ALTER, schlüss das fucking file im Excel");
                Thread.Sleep(500);
                AppendFile(fileName, person);
            }
            return;
        }
        private static string CsvHeader()
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
        private static string PersonToCsvString(Person person)
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

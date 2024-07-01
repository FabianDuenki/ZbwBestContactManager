using Microsoft.VisualBasic.ApplicationServices;
using Model;
using Model.Detail;
using Model.Typing;
using System.Reflection;

namespace Controller
{
    internal class CRUDController : ModelController
    {
        public static object CreateUserObject(ModelType modelType, UserDetails userDetails)
        {
            // user is a new object of type modelType.
            object user = GetModelByType(modelType);
            // modelProperties is an array of each property of user.
            PropertyInfo[] modelProperties = user.GetType().GetProperties();
            // userProperties is an array of each property of userDetails that is not null.
            PropertyInfo[] userProperties = userDetails.GetType().GetProperties().Where(property => property.GetValue(userDetails) != null).ToArray();
            // For each property in userProperties, set the value of the property in user to the value of the property in userDetails.
            foreach (PropertyInfo userProperty in userProperties)
            {
                user
                    .GetType()
                    .GetProperty(userProperty.Name)!
                    .SetValue(user, userProperty
                        .GetValue(userDetails)
                    );
            }
            return user;
        }
        public bool Create(ModelType modelType, UserDetails userDetails)
        {
            userDetails.Id = Guid.NewGuid();
            object user = CreateUserObject(modelType, userDetails);
            CSVController csvController = new CSVController();

            // expecting csvController.AddUser to return true if the user was successfully created.
            // the function should iterate through the properties of the user object and write them to a csv file and handle the file creation if it does not exist.
            return csvController.AddUser(modelType, user);
        }

        public List<UserDetails> Read(ModelType modelType, Guid userId)
        {
            // I'm not happy with the types used, as we always work with "UserDetails" objects, instead of our models
            List<UserDetails> allUsers = this.Read(modelType);
            List<UserDetails> users = new List<UserDetails>();

            foreach (var user in allUsers)
            {
                if(user.Id == userId)
                {
                    users.Add(user);
                }
            }
            return users;
        }
        public List<UserDetails> Read(ModelType modelType)
        {
            CSVController csvController = new CSVController();

            // expecting csvController.ReadUser to return a list of users of type in modelType as UserDetails objects.
            return csvController.ReadUsers(modelType);
        }
        public bool Update(ModelType modelType, Guid userId, UserDetails updatedUserProperties)
        {
            updatedUserProperties.Id = userId;
            UserDetails user = this.Read(modelType, userId).First();
            CSVController csvController = new CSVController();

            // expecting csvController.UpdateUser to return true if the user was successfully updated from user to updatedUserProperties.
            return csvController.UpdateUser(modelType, user, updatedUserProperties);
        }
        public bool Delete(ModelType modelType, Guid userid)
        {
            UserDetails user = this.Read(modelType, userid).First();
            CSVController csvController = new CSVController();

            // expecting csvController.DeleteUser to return true if the user was successfully deleted.
            return csvController.DeleteUser(modelType, user);
        }























        public static Person CreatePerson(Person person)
        {
            string fileName = GetFileName(person);

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

            if (!File.Exists(fileName) || File.ReadAllText(fileName) == "")
            {
                File.WriteAllText(fileName, CsvHeader(person));
            }

            File.AppendAllText(fileName, PersonToCsvString(person) + Environment.NewLine);

            return person;
        }
        public static Person ReadPerson(Person person)
        {
            IsPersonValid(person);
            string fileName = GetFileName(person);
            string[] fileContent = File.ReadAllLines(fileName);
            foreach (string line in fileContent)
            {
                if (line.Contains(person.FirstName) && line.Contains(person.LastName))
                {
                    return LineToPerson(line);
                }
            }
            throw new ArgumentException("Person not found");
        }
        public static bool UpdatePerson(Person personOld, Person personNew)
        {
            IsPersonValid(personNew);
            string fileName = GetFileName(personOld);
            string[] fileContent = File.ReadAllLines(fileName);

            for(int i = 0;i < fileContent.Length; i++)
            {
                if (fileContent[i].Contains(personOld.FirstName) && fileContent[i].Contains(personOld.LastName))
                {
                    fileContent[i] = PersonToCsvString(personNew);
                    File.WriteAllLines(fileName, fileContent);
                    return true;
                }
            }
            return false;
        }
        public static bool DeletePerson(Person person)
        {
            IsPersonValid(person);
            string fileName = GetFileName(person);
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
        private static string GetFileName(Person person)
        {
            return person.GetType().Name + ".csv";
        }
        private static string CsvHeader(Person person)
        {
            return
                string.Join(",", person.GetType()
                .GetProperties()
                .Select(propertyInfo => $"\"{propertyInfo.Name}\"")) +
                Environment.NewLine;
        }
        private static string PersonToCsvString(Person person)
        {
            return
                string.Join(",", person.GetType()
                    .GetProperties()
                    .Select(propertyInfo => $"\"{propertyInfo.GetValue(person)}\""));
        }
        private static Person LineToPerson(string line)
        {
            Person person = new Person();
            List<string> personData = new List<string>();
            int i = 0;
            foreach (string property in line.Split(','))
            {
                personData.Add(property.Trim('"'));
            }
            person.Id = Guid.NewGuid();
            person.Salutation = personData[0];
            person.FirstName = personData[1];
            person.LastName = personData[2];
            person.DateOfBirth = Convert.ToDateTime(personData[3]);
            person.Gender = personData[4];
            person.Title = personData[5];
            person.SocialSecurityNumber = personData[6];
            person.PhoneNumberPrivate = personData[7];
            person.PhoneNumberMobile = personData[8];
            person.PhoneNumberBusiness = personData[9];
            person.Email = personData[10];
            if (personData[11] == "True")
                person.Status = true;
            else
                person.Status = false;
            person.Nationality = personData[12];
            person.Street = personData[13];
            person.StreetNumber = personData[14];
            if(personData[15] == "")
                person.ZipCode = 0;
            else 
                person.ZipCode = Convert.ToInt32(personData[15]);
            person.Place = personData[16];

            return person;
        }
        private static void IsPersonValid(Person person)
        {
            if(string.IsNullOrEmpty(person.FirstName) 
            || string.IsNullOrEmpty(person.LastName))
            {
                throw new ArgumentException("Please Enter the lastname and firstname of the person to be deleted");
            }
            return;
        }
    }
}

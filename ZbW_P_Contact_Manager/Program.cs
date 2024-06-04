using Controller;
using Model;
namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string salutation = "Herr";
            string firstName = "Max";
            string lastName = "Muster";
            DateTime dateOfBirth = new DateTime(1990, 1, 1);

            var person1 = new Person
            {
                Salutation = salutation,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Gender = "Male"
            };

            salutation = "Frau";
            firstName = "Knorke";
            lastName = "Gastraffi";
            dateOfBirth = new DateTime(1969, 1, 1);

            var person2 = new Person
            {
                Salutation = salutation,
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Gender = "Female"
            };

            CRUDController.CreatePerson(person1);
            CRUDController.CreatePerson(person2);
            //CRUDController.DeletePerson(person1);
            //CRUDController.DeletePerson(person2);
            try
            {
                Person person3 = CRUDController.ReadPerson(new Person
                {
                    FirstName = "Aladdin",
                    LastName = "Meier"
                });
                Console.WriteLine($"First Name {person3.FirstName} and Last Name {person3.LastName} of Searched Person");
                Console.WriteLine($"oh yeah and {person3.Salutation} {person3.LastName}'s Gender is {person3.Gender}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("the Person was not Found");
            }
            Console.ReadLine();
        }
    }
}
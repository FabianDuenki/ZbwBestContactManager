using Model;
using Model.Detail;
using Model.Typing;
using System.Reflection;

namespace Controller
{
    internal class CRUDController : ModelController
    {
        CSVController _csvController;

        public CRUDController()
        {
            _csvController = new CSVController();
        }
        public void Create(Person user)
        {
            // check if mandatory fields are filled
            _csvController.AddUser(user);
        }
        public void Create(Note note)
        {
           _csvController.AddNote(note);
        }

        public List<Person> Read(Person searchUser)
        {
            List<Person> allUsers = this.Read(searchUser.GetType().Name);

            List<Person> foundUsers = new List<Person>();

            foreach (Person user in allUsers)
            {
                if (user.Contains(searchUser))
                {
                    foundUsers.Add(user);
                }
            }
            return foundUsers;
        }
        public List<Person> Read(string userType)
        {
            switch(userType)            {
                case "Employee":
                    return _csvController.ReadUsers(new Employee());
                case "Customer":
                    return _csvController.ReadUsers(new Customer());
                case "Trainee":
                    return _csvController.ReadUsers(new Trainee());
                default:
                    return new List<Person>();
            }
        }
        public List<Note> Read(Guid personId)
        {
            return _csvController.ReadNotes(personId);
        }
        public void Update(Person oldUser, Person newUser)
        {
            newUser.Id = oldUser.Id;

            _csvController.UpdateUser(newUser);
        }
        public void Delete(Person user)
        {
            _csvController.DeleteUser(user);
        }
    }
}

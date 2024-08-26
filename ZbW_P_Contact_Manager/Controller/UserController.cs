using Model;
using Model.Detail;
using Model.Typing;
using System.Reflection;

namespace Controller
{
    internal class UserController : ModelController
    {
        CSVController _csvController;

        public UserController()
        {
            _csvController = new CSVController();
        }
        public void Create(Person user)
        {
            _csvController.AddUser(user);
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

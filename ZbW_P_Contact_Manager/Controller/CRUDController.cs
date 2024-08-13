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
        public bool Create(Person user)
        {
            // check if mandatory fields are filled
            return _csvController.AddUser(user);
        }

        public List<Person> Read(Person searchUser)
        {
            List<Person> allUsers = this.Read(searchUser);

            List<Person> users = new List<Person>();

            foreach (Person user in allUsers)
            {
                if(user.Contains(searchUser))
                {
                    users.Add(user);
                }
            }
            return users;
        }
        public List<Person> Read(Type userType)
        {
            return _csvController.ReadUsers(userType);
        }
        public bool Update(Person oldUser, Person newUser)
        {
            newUser.Id = oldUser.Id;

            return _csvController.UpdateUser(oldUser, newUser);
        }
        public bool Delete(Person user)
        {
            return _csvController.DeleteUser(user);
        }
    }
}

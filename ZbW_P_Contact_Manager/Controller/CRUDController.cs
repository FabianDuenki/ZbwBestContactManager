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
            List<Person> allUsers = this.Read(searchUser.GetType());

            List<Person> users = new List<Person>();

            //foreach (Person user in allUsers)
            //{
            //    if (user.Contains(searchUser))
            //    {
            //        users.Add(user);
            //    }
            //}
            return users;
        }
        public List<Person> Read(Type userType)
        {
            return _csvController.ReadUsers(userType);
        }
        public List<Note> Read(Guid personId)
        {
            return _csvController.ReadNotes(personId);
        }
        public void Update(Person oldUser, Person newUser)
        {
            newUser.Id = oldUser.Id;

            // check if mandatory fields are filled

            _csvController.UpdateUser(newUser);
        }
        public void Delete(Person user)
        {
            _csvController.DeleteUser(user);
        }
    }
}

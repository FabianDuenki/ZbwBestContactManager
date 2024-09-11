using Model;
using Model.Typing;

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
            user.Id = Guid.NewGuid();
            if (user.GetType() == typeof(Trainee))
            {
                Trainee trainee = (Trainee)user;
                trainee.EmployeeNumber = Guid.NewGuid();
                _csvController.AddUser(trainee);
                return;
            }
            if (user.GetType() == typeof(Employee))
            {
                Employee employee = (Employee)user;
                employee.EmployeeNumber = Guid.NewGuid();
                _csvController.AddUser(employee);
                return;
            }
            _csvController.AddUser(user);
        }

        public List<Person> Read(Person searchUser)
        {
            List<Person> allUsers = _csvController.ReadUsers(searchUser);

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
        public List<Person> Read(ModelType userType)
        {
            return _csvController.ReadUsers(GetModelByType(userType));
        }
        public void Update(Person oldUser, Person newUser)
        {
            newUser.Id = oldUser.Id;
            if (newUser.GetType() == typeof(Trainee))
            {
                Trainee newTrainee = (Trainee)newUser;
                Trainee oldTrainee = (Trainee)oldUser;
                newTrainee.EmployeeNumber = oldTrainee.EmployeeNumber;
                _csvController.UpdateUser(newTrainee);
                return;
            }
            if (newUser.GetType() == typeof(Employee))
            {
                Employee newEmployee = (Employee)newUser;
                Employee oldEmployee = (Employee)oldUser;
                newEmployee.EmployeeNumber = oldEmployee.EmployeeNumber;
                _csvController.UpdateUser(newEmployee);
                return;
            }
            _csvController.UpdateUser(newUser);
        }
        public void Delete(Person user)
        {
            _csvController.DeleteUser(user);
        }
    }
}

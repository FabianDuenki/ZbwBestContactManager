using Model.Detail;
using Model.Typing;
using System.Reflection;

namespace Controller
{
    internal class CRUDController : ModelController
    {
        CSVController _csvController;
        ModelType _modelType;

        public CRUDController(ModelType modelType)
        {
            _csvController = new CSVController();
            _modelType = modelType;
        }
        public object CreateUserObject(UserDetails userDetails)
        {
            // user is a new object of type modelType.
            object user = GetModelByType(_modelType);
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
        public bool Create(UserDetails userDetails)
        {
            userDetails.Id = Guid.NewGuid();
            object user = CreateUserObject(userDetails);

            return _csvController.AddUser(_modelType, user);
        }

        public List<dynamic> Read(Guid userId)
        {
            List<dynamic> allUsers = this.Read();
            List<dynamic> users = new List<dynamic>();

            foreach (var user in allUsers)
            {
                if(user.Id == userId)
                {
                    users.Add(user);
                }
            }
            return users;
        }
        public List<dynamic> Read()
        {

            return _csvController.ReadUsers(_modelType);
        }
        public bool Update(Guid userId, UserDetails updatedUserProperties)
        {
            updatedUserProperties.Id = userId;

            object currentUser = Read(userId).First();
            object updatedUser = CreateUserObject(updatedUserProperties);

            foreach(PropertyInfo property in updatedUser.GetType().GetProperties())
            {
                if (property.GetValue(updatedUser) == null)
                {
                    updatedUser
                    .GetType()
                    .GetProperty(property.Name)!
                    .SetValue(updatedUser, property
                        .GetValue(currentUser));
                }
            }

            return _csvController.UpdateUser(_modelType, userId, updatedUser);
        }
        public bool Delete(Guid userId)
        {
            return _csvController.DeleteUser(_modelType, userId);
        }
    }
}

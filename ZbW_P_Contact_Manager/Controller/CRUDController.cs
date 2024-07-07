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

            return csvController.AddUser(modelType, user);
        }

        public List<dynamic> Read(ModelType modelType, Guid userId)
        {
            List<dynamic> allUsers = this.Read(modelType);
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
        public List<dynamic> Read(ModelType modelType)
        {
            CSVController csvController = new CSVController();

            return csvController.ReadUsers(modelType);
        }
        public bool Update(ModelType modelType, Guid userId, UserDetails updatedUserProperties)
        {
            updatedUserProperties.Id = userId;

            object currentUser = Read(modelType, userId).First();
            object updatedUser = CreateUserObject(modelType, updatedUserProperties);

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
            CSVController csvController = new CSVController();

            return csvController.UpdateUser(modelType, userId, updatedUser);
        }
        public bool Delete(ModelType modelType, Guid userId)
        {
            CSVController csvController = new CSVController();

            return csvController.DeleteUser(modelType, userId);
        }
    }
}

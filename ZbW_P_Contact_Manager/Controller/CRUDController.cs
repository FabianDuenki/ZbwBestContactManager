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
    }
}

using Model;
using Model.Typing;

namespace Controller
{
    /// <summary>
    /// Class to manage the models
    /// </summary>
    public class ModelController
    {
        /// <summary>
        /// Get the model by the type.
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns>Modeltype</returns>
        public static Person GetModelByType(ModelType modelType)
        {
            return modelType switch
            {
                ModelType.Person => new Person(),
                ModelType.Employee => new Employee(),
                ModelType.Trainee => new Trainee(),
                ModelType.Customer or _ => new Customer(),
            };
        }
    }
}

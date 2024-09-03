using Model;
using Model.Typing;

namespace Controller
{
    public class ModelController
    {
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

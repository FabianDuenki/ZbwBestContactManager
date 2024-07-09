using Model;
using Model.Typing;

namespace Controller
{
    public class ModelController
    {
        public static object GetModelByType(ModelType modelType)
        {
            return modelType switch
            {
                ModelType.Person => new Person(),
                ModelType.Employee => new Employee(),
                ModelType.Trainee => new Trainee(),
                ModelType.Note => new Note(),
                ModelType.Customer or _ => new Customer(),
            };
        }
    }
}

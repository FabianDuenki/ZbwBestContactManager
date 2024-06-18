using Interface;

namespace Model
{
    public class Trainee : Employee, ITrainee
    {
        public int? TraineeYears { get; set; }
        public int? ActualTraineeYear { get; set; }
    }
}

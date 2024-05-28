using Interface;

namespace Model
{
    public class Trainee(ITrainee trainee) : ITrainee
    {
        public int TraineeYears { get; set; } = trainee.TraineeYears;
        public int ActualTraineeYear { get; set; } = trainee.ActualTraineeYear;
    }
}

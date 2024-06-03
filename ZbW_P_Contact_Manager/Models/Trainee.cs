using Struct;

namespace Model
{
    public class Trainee(TraineeDetails trainee)
    {
        public int TraineeYears { get; set; } = trainee.TraineeYears;
        public int ActualTraineeYear { get; set; } = trainee.ActualTraineeYear;
    }
}

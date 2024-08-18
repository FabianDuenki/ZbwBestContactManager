namespace Model
{
    public class Trainee : Employee
    {
        public int? TraineeYears { get; set; }
        public int? ActualTraineeYear { get; set; }
        public override string ToCsvString()
        {
            return base.ToCsvString() +
                "," +
                $"{this.TraineeYears.ToString()}," +
                $"{this.ActualTraineeYear.ToString()}";
        }
        public override string ToCsvHeader()
        {
            return base.ToCsvHeader() +
                "," +
                "TraineeYears," +
                "ActualTraineeYear";
        }
    }
}

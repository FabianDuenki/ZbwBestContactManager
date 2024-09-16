namespace ZbW_P_Contact_Manager.Models
{
    /// <summary>
    /// Data for the dashboard
    /// </summary>
    public class DashboardData
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="activeCustomerCount"></param>
        /// <param name="passiveCustomerCount"></param>
        /// <param name="employeeCount"></param>
        /// <param name="traineeCount"></param>
        /// <param name="customerTypeStatistics"></param>
        /// <param name="age"></param>
        public DashboardData(int activeCustomerCount, int passiveCustomerCount, int employeeCount, int traineeCount, Dictionary<string, int> customerTypeStatistics, List<int> age)
        {
            ActiveCustomerCount = activeCustomerCount;
            PassiveCustomerCount = passiveCustomerCount;
            EmployeeCount = employeeCount;
            TraineeCount = traineeCount;
            CustomerTypeStatistics = customerTypeStatistics;
            Age = age;
        }

        /// <summary>
        /// Employee count
        /// </summary>
        public int EmployeeCount { get; init; }

        /// <summary>
        /// Trainee count
        /// </summary>
        public int TraineeCount { get; init; }

        /// <summary>
        /// Active customer count
        /// </summary>
        public int ActiveCustomerCount { get; init; }

        /// <summary>
        /// Passive customer count
        /// </summary>
        public int PassiveCustomerCount { get; init; }

        /// <summary>
        /// Age
        /// </summary>
        public List<int> Age { get; init; }

        /// <summary>
        /// Customer type statistics
        /// </summary>
        public Dictionary<string, int> CustomerTypeStatistics { get; set; }
    }
}

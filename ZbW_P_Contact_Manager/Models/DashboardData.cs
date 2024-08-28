namespace ZbW_P_Contact_Manager.Models
{
    public class DashboardData
    {
        public DashboardData(int activeCustomerCount, int passiveCustomerCount, int employeeCount, int traineeCount, Dictionary<string, int> customerTypeStatistics, List<int> age)
        {
            ActiveCustomerCount = activeCustomerCount;
            PassiveCustomerCount = passiveCustomerCount;
            EmployeeCount = employeeCount;
            TraineeCount = traineeCount;
            CustomerTypeStatistics = customerTypeStatistics;
            Age = age;
        }

        public int EmployeeCount { get; init; }

        public int TraineeCount { get; init; }

        public int ActiveCustomerCount { get; init; }

        public int PassiveCustomerCount { get; init; }

        public List<int> Age { get; init; }

        public Dictionary<string, int> CustomerTypeStatistics { get; set; }
    }
}

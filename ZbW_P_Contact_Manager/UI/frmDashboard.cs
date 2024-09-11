using Controller;
using Model;
using Model.Typing;
using ScottPlot;
using ScottPlot.Palettes;
using ZbW_P_Contact_Manager.Models;

namespace ZbW_P_Contact_Manager.UI
{
    /// <summary>
    /// Form for the dashboard.
    /// </summary>
    public partial class FrmDashboard : Form
    {
        DashboardData _dashboardData;

        /// <summary>
        /// Default constructor dashboard.
        /// </summary>
        public FrmDashboard()
        {
            InitializeComponent();

            var userController = new UserController();

            var customerList = userController.Read(ModelType.Customer);
            var employeeList = userController.Read(ModelType.Employee);
            var traineeList = userController.Read(ModelType.Trainee);

            var people = customerList.Concat(employeeList).Concat(traineeList).ToList();

            var residence = new Dictionary<string, int>();
            var agePeople = new List<int>();

            var activeCustomerCount = 0;
            var passiveCustomerCount = 0;
            var employeeCount = 0;
            var traineeCount = 0;

            foreach (var person in people)
            {
                int age = (int)((DateTime.Now - person.DateOfBirth.Value).TotalDays / 365.242199);
                agePeople.Add(age);

                if (residence.ContainsKey(person.Place))
                {
                    residence[person.Place] += 1;
                }
                else
                {
                    residence.Add(person.Place, 1);
                }

                if (person is Customer cust)
                {
                    if (cust.Status == true)
                    {
                        activeCustomerCount++;
                    }
                    else
                    {
                        passiveCustomerCount++;
                    }
                }
                else if (person is Trainee trainee)
                {
                    traineeCount++;
                }
                else if (person is Employee employee)
                {
                    employeeCount++;
                }
            }

            _dashboardData = new DashboardData(activeCustomerCount, passiveCustomerCount, employeeCount, traineeCount, residence, agePeople);

            InitFormsPlotCustomerCount();
            InitFormsPlotPersonTypes();
            InitFormsPlotResidence();
            InitFormsPlotAge();
        }

        /// <summary>
        /// Initializes the forms plot for the customer count.
        /// </summary>
        private void InitFormsPlotCustomerCount()
        {
            FormsPlotCustomerCount.Plot.Clear();

            var plot = FormsPlotCustomerCount.Plot;

            Penumbra palette = new();

            Bar[] bars =
            {
                new() { Position = 1, ValueBase = 0, Value = _dashboardData.ActiveCustomerCount, FillColor = palette.GetColor(0) },
                new() { Position = 2, ValueBase = 0, Value = _dashboardData.PassiveCustomerCount, FillColor = palette.GetColor(2) },
            };

            plot.Add.Bars(bars);

            Tick[] ticks =
            {
                new(1, $"Aktiv ({_dashboardData.ActiveCustomerCount})"),
                new(2, $"Passiv ({_dashboardData.PassiveCustomerCount})"),
            };

            SetColorsForPlot(plot);
            SetFormsPlotSettings(plot, ticks);

            FormsPlotCustomerCount.Refresh();
        }

        /// <summary>
        /// Initializes the forms plot for the person types.
        /// </summary>
        private void InitFormsPlotPersonTypes()
        {
            FormsPlotPersonTypes.Plot.Clear();
            var plot = FormsPlotPersonTypes.Plot;

            var customerCount = _dashboardData.ActiveCustomerCount + _dashboardData.PassiveCustomerCount;
            var employeeCount = _dashboardData.EmployeeCount;
            var traineeCount = _dashboardData.TraineeCount;

            Category10 palette = new Category10();

            Bar[] bars =
            {
                new() { Position = 1, ValueBase = 0, Value = customerCount, FillColor = palette.GetColor(1) },
                new() { Position = 2, ValueBase = 0, Value = employeeCount, FillColor = palette.GetColor(3) },
                new() { Position = 3, ValueBase = 0, Value = traineeCount, FillColor = palette.GetColor(4) },
            };

            plot.Add.Bars(bars);

            Tick[] ticks =
            {
                new(1, $"Kunden ({customerCount})"),
                new(2, $"Mitarbeiter ({employeeCount})"),
                new(3, $"Lernende ({traineeCount})"),
            };

            SetColorsForPlot(plot);
            SetFormsPlotSettings(plot, ticks);

            FormsPlotPersonTypes.Refresh();
        }

        /// <summary>
        /// Initializes the forms plot for the residence.
        /// </summary>
        private void InitFormsPlotResidence()
        {
            FormsPlotResidence.Plot.Clear();
            var plot = FormsPlotResidence.Plot;

            var cityValues = _dashboardData.CustomerTypeStatistics.Values.Select(v => (double)v).ToArray();
            var cityKeys = _dashboardData.CustomerTypeStatistics.Keys.ToArray();

            Penumbra palette = new Penumbra();
            List<PieSlice> slices = new();
            var color = 2;

            for (int i = 0; i < cityKeys.Length; i++)
            {
                slices.Add(new PieSlice() { Value = cityValues[i], FillColor = palette.GetColor(color), Label = $"{cityKeys[i]} ({cityValues[i]})" });
                color++;
            }

            var pie = plot.Add.Pie(slices);
            pie.ExplodeFraction = .1;

            plot.ShowLegend();

            SetColorsForPlot(plot);
            plot.HideAxesAndGrid();

            FormsPlotResidence.Refresh();
        }

        /// <summary>
        /// Initializes the forms plot for the age.
        /// </summary>
        private void InitFormsPlotAge()
        {
            double[] dataX = new double[_dashboardData.Age.Count()];
            var count = 1;

            for (int i = 0; i < _dashboardData.Age.Count(); i++)
            {
                dataX[i] = count++;
            }

            var numbPeople = _dashboardData.Age.Count();

            int[] x = _dashboardData.Age.ToArray();
            double[] y = x.Select(i => (double)i).ToArray();

            var plot = FormsPlotAge.Plot;
            plot.Add.Scatter(dataX, y);

            Tick[] ticks = { };

            for (int i = 0; i < numbPeople; i++)
            {
                ticks = ticks.Append(new Tick(i + 1, x[i].ToString())).ToArray();
            }

            if (x.Length > 0)
            {
                LblAverage.Text = "Durchschnitt: " + Queryable.Average(x.AsQueryable()).ToString();
            }

            SetColorsForPlot(plot);
            SetFormsPlotSettings(plot, ticks);

            FormsPlotAge.Refresh();
        }

        /// <summary>
        /// Sets the colors for the plot.
        /// </summary>
        /// <param name="plot"></param>
        private void SetColorsForPlot(Plot plot)
        {
            // change figure colors
            plot.FigureBackground.Color = ScottPlot.Color.FromHex("#252a40");
            plot.DataBackground.Color = ScottPlot.Color.FromHex("#252a40");

            // change axis and grid colors
            plot.Axes.Color(ScottPlot.Color.FromHex("#d7d7d7"));
            plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#404040");

            // change legend colors
            plot.Legend.BackgroundColor = ScottPlot.Color.FromHex("#404040");
            plot.Legend.FontColor = ScottPlot.Color.FromHex("#d7d7d7");
            plot.Legend.OutlineColor = ScottPlot.Color.FromHex("#d7d7d7");
        }

        /// <summary>
        /// Sets the forms plot settings.
        /// </summary>
        /// <param name="plot"></param>
        /// <param name="ticks"></param>
        private void SetFormsPlotSettings(Plot plot, Tick[] ticks)
        {
            plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            plot.Axes.Bottom.MajorTickStyle.Length = 0;
            plot.HideGrid();

            plot.Axes.Margins(bottom: 0);
        }
    }
}

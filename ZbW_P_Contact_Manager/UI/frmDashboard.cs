using ScottPlot;
using ScottPlot.Palettes;
using ZbW_P_Contact_Manager.Models;

namespace ZbW_P_Contact_Manager.UI
{
    public partial class FrmDashboard : Form
    {
        DashboardData _dashboardData;

        public FrmDashboard()
        {
            InitializeComponent();

            // TODO: get data from csv controller
            var residence = new Dictionary<string, int>()
            {
                { "Bern", 57 },
                { "Basel", 100 },
                { "Lausanne", 34 },
            };

            var age = new List<int>() { 32, 45, 76, 34, 28, 26 };

            _dashboardData = new DashboardData(10, 20, 30, 40, residence, age);

            InitFormsPlotCustomerCount();
            InitFormsPlotPersonTypes();
            InitFormsPlotResidence();
            InitFormsPlotAge();
        }

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

        private void InitFormsPlotResidence()
        {
            FormsPlotResidence.Plot.Clear();
            var plot = FormsPlotResidence.Plot;

            var cityValues = _dashboardData.CustomerTypeStatistics.Values.Select(v => (double)v).ToArray();
            var cityKeys = _dashboardData.CustomerTypeStatistics.Keys.ToArray();

            Penumbra palette = new Penumbra();

            List<PieSlice> slices = new()
            {
                new PieSlice() { Value = cityValues[0], FillColor = palette.GetColor(2), Label = $"{cityKeys[0]} ({cityValues[0]})" },
                new PieSlice() { Value = cityValues[1], FillColor = palette.GetColor(3), Label = $"{cityKeys[1]} ({cityValues[1]})" },
                new PieSlice() { Value = cityValues[2], FillColor = palette.GetColor(4), Label = $"{cityKeys[2]} ({cityValues[2]})" },
            };

            var pie = plot.Add.Pie(slices);
            pie.ExplodeFraction = .1;

            plot.ShowLegend();

            SetColorsForPlot(plot);
            plot.HideAxesAndGrid();

            FormsPlotResidence.Refresh();
        }

        private void InitFormsPlotAge()
        {
            // dataX change to count people
            double[] dataX = { 1, 2, 3, 4, 5, 6 };

            int[] x = _dashboardData.Age.ToArray();
            double[] y = x.Select(i => (double)i).ToArray();

            var plot = FormsPlotAge.Plot;
            plot.Add.Scatter(dataX, y);

            Tick[] ticks =
            {
                new(1, $"({x[0]})"),
                new(2, $"({x[1]})"),
                new(3, $"({x[2]})"),
                new(4, $"({x[3]})"),
                new(5, $"({x[4]})"),
                new(6, $"({x[5]})")
            };

            LblAverage.Text = "Durchschnitt: " + Queryable.Average(x.AsQueryable()).ToString();

            SetColorsForPlot(plot);
            SetFormsPlotSettings(plot, ticks);

            FormsPlotAge.Refresh();
        }

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

        private void SetFormsPlotSettings(Plot plot, Tick[] ticks)
        {
            plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            plot.Axes.Bottom.MajorTickStyle.Length = 0;
            plot.HideGrid();

            plot.Axes.Margins(bottom: 0);
        }
    }
}

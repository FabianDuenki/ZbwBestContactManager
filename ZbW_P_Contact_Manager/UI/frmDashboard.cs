using ScottPlot;
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
            _dashboardData = new DashboardData(10, 20, 30, 40, new Dictionary<string, int>());

            InitFormsPlotCustomerCount();
        }

        private void InitFormsPlotCustomerCount()
        {
            FormsPlotCustomerCount.Plot.Clear();

            var plot = FormsPlotCustomerCount.Plot;

            ScottPlot.Palettes.Category10 palette = new();

            Bar[] bars =
            {
                new() { Position = 1, ValueBase = 0, Value = _dashboardData.ActiveCustomerCount, FillColor = palette.GetColor(0) },
                new() { Position = 2, ValueBase = 0, Value = _dashboardData.PassiveCustomerCount, FillColor = palette.GetColor(2) },
            };

            plot.Add.Bars(bars);

            Tick[] ticks =
            {
                new(1, "Aktiv"),
                new(2, "Passiv"),
            };

            plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            plot.Axes.Bottom.MajorTickStyle.Length = 0;
            plot.HideGrid();

            // tell the plot to autoscale with no padding beneath the bars
            plot.Axes.Margins(bottom: 0);
            
            FormsPlotCustomerCount.Refresh();
        }

        private void InitFormsPlotPersonTypes(DashboardData dashboardData)
        {

        }

    }
}

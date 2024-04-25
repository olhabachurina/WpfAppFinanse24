using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Series;
namespace WpfAppFinanse.Views
{
    /// <summary>
    /// Interaction logic for AnalysisWindow.xaml
    /// </summary>
    public partial class AnalysisWindow : Window
    {
        public PlotModel PieChartModel { get; private set; }
        public AnalysisWindow()
        {
            InitializeComponent();
            this.Icon = BitmapFrame.Create(Application.GetResourceStream(new Uri("pack://application:,,,/Image/growth.png")).Stream);
            this.DataContext = this;
            CreatePieChart();
        }

        private void CreatePieChart()
        {
            var model = new PlotModel { Title = "Расходы по категориям" };

            var pieSeries = new PieSeries
            {
                StrokeThickness = 2.0,
                InsideLabelPosition = 0.5,
                AngleSpan = 360,
                StartAngle = 0
            };

            // Добавление данных в круговую диаграмму. Значения должны быть динамическими, в данном примере они статические.
            pieSeries.Slices.Add(new PieSlice("Категория 1", 10) { IsExploded = true });
            pieSeries.Slices.Add(new PieSlice("Категория 2", 20) { IsExploded = true });
            // Добавьте больше срезов как необходимо...

            model.Series.Add(pieSeries);
            PieChartModel = model;
        }
    

        private void OnMonthlyDynamicsClick(object sender, RoutedEventArgs e)
        {
            var model = new PlotModel { Title = "Месячная динамика" };
            model.Series.Add(new LineSeries { /* Добавьте данные здесь */ });
            Plot.Model = model;
            Plot.Visibility = Visibility.Visible;
        }

        private void OnExpensesByCategoryClick(object sender, RoutedEventArgs e)
        {
            var model = new PlotModel { Title = "Расходы по категориям" };
            model.Series.Add(new PieSeries { /* Добавьте данные здесь */ });
            Plot.Model = model;
            Plot.Visibility = Visibility.Visible;
        }

        private void OnIncomeExpensesByMonthClick(object sender, RoutedEventArgs e)
        {
            var model = new PlotModel { Title = "Доходы/Расходы по месяцам" };
            //model.Series.Add(new ColumnSeries { /* Добавьте данные здесь */ });
            Plot.Model = model;
            Plot.Visibility = Visibility.Visible;
        }
    }
}

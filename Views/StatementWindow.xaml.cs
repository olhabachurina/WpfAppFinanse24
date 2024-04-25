using MaterialDesignThemes.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using WpfAppFinanse.Themes;
using WpfAppFinanse.ViewModels;

namespace WpfAppFinanse.Views
{
    /// <summary>
    /// Interaction logic for StatmentWindow.xaml
    /// </summary>
    public partial class StatementWindow : Window
    {
        public Snackbar MainSnackbar { get; set; }
        public StatementWindow()
        {
            InitializeComponent();
            UpdateTheme((Application.Current as App).IsLightTheme);
            this.Icon = BitmapFrame.Create(Application.GetResourceStream(new Uri("pack://application:,,,/WpfAppFinanse;component/Image/statement.png")).Stream);
            var viewModel = new StatementViewModel();
            DataContext = viewModel;
            Loaded += async (_, __) => await viewModel.InitializeAsync();  
        }
        private async void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            currencyListBox.Items.Clear();
            using (var client = new HttpClient())
            {
                try
                {
                    string json = await client.GetStringAsync("https://api.privatbank.ua/p24api/pubinfo?json&exchange&coursid=5");
                    List<CurrencyRate> rates = JsonConvert.DeserializeObject<List<CurrencyRate>>(json);
                    foreach (var rate in rates)
                    {
                        currencyListBox.Items.Add($"Валюта: {rate.Ccy}, Курс покупки: {rate.Buy}грн, Курс продажи: {rate.Sale}грн");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
                }
            }
        }




        private void UpdateTheme(bool isLightTheme)
        {
            ThemeManager.ApplyTheme(isLightTheme ? "Light" : "Dark");
        }

       
    }
}

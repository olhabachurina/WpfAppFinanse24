using MaterialDesignThemes.Wpf;
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
using WpfAppFinanse.Data;
using WpfAppFinanse.Themes;
using WpfAppFinanse.ViewModels;

namespace WpfAppFinanse.Views
{
    /// <summary>
    /// Interaction logic for DataEntryWindow.xaml
    /// </summary>
    public partial class DataEntryWindow : Window
    {
        public Snackbar MainSnackbar { get; set; }
        public DataEntryWindow()
        {
            InitializeComponent();
            UpdateTheme((Application.Current as App).IsLightTheme);
            this.Icon = BitmapFrame.Create(Application.GetResourceStream(new Uri("pack://application:,,,/WpfAppFinanse;component/Image/data.png")).Stream);

            var viewModel = new DataEntryViewModel();
            DataContext = viewModel;
            Loaded += async (_, __) => await viewModel.InitializeAsync();
        }

        private void UpdateTheme(bool isLightTheme)
        {
            ThemeManager.ApplyTheme(isLightTheme ? "Light" : "Dark");
        }
        //private void ShowMessageToUser()
        //{
        //    MainSnackbar?.MessageQueue?.Enqueue("Сообщение для пользователя");
        //}
        //private void ClosePopup_Click(object sender, RoutedEventArgs e)
        //{
            
        //    var viewModel = (DataEntryViewModel)DataContext;
           
        //}

    }
}




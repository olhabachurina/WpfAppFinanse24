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
using WpfAppFinanse.ViewModels;

namespace WpfAppFinanse.Views
{
    /// <summary>
    /// Interaction logic for CorrectionWindow.xaml
    /// </summary>
    public partial class CorrectionWindow : Window
    {
        public Snackbar MainSnackbar { get; set; }
        public CorrectionWindow()
        {
            InitializeComponent();
            this.Icon = BitmapFrame.Create(Application.GetResourceStream(new Uri("pack://application:,,,/Image/Correction.ico")).Stream);

            // Предполагается, что ViewModel инициализируется с контекстом базы данных
            var dbContext = new FinanceDbContext();  // Замените на реальный контекст
            var viewModel = new CorrectionViewModel(dbContext);
            DataContext = viewModel;
            Loaded += async (_, __) => await viewModel.InitializeAsync();
        }
    }
}
    

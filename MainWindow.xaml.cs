using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using MaterialDesignThemes.Wpf;
using WpfAppFinanse;
using WpfAppFinanse.Themes;
using WpfAppFinanse.ViewModels;
using WpfAppFinanse.Views;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;
namespace WpfAppFinanse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty ThemeTextProperty = DependencyProperty.Register(
   "ThemeText", typeof(string), typeof(MainWindow), new PropertyMetadata(default(string)));
       
        public string ThemeText
        {
            get => (string)GetValue(ThemeTextProperty);
            set => SetValue(ThemeTextProperty, value);
        }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DataEntryViewModel(); 
            UpdateThemeText((Application.Current as App).IsLightTheme);
            this.Closing += MainWindow_Closing;
            this.Icon = BitmapFrame.Create(Application.GetResourceStream(new Uri("pack://application:,,,/WpfAppFinanse;component/Image/image1.png")).Stream);
            if (DataContext is DataEntryViewModel viewModel)
            {
               
            }
        }
        private async void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var viewModel = this.DataContext as DataEntryViewModel;
            if (viewModel != null)
            {
                await viewModel.SaveChangesAsync();
            }
        }
        private void ThemeToggle_Checked(object sender, RoutedEventArgs e)
        {
         
            ChangeTheme("Dark");
            UpdateThemeText(false); 
        }
        private void UpdateThemeText(bool isLightTheme)
        {
            ThemeText = isLightTheme ? "Светлая тема" : "Темная тема";
        }
        private void ThemeToggle_Unchecked(object sender, RoutedEventArgs e)
        {
            ChangeTheme("Light");
            UpdateThemeText(true);
        }
        private void UpdateButtonStyles(ResourceDictionary themeDict)
        {
            var buttons = FindVisualChildren<Button>(this); 
            foreach (var button in buttons)
            {
              
                button.Foreground = (SolidColorBrush)themeDict["PrimaryForeground"];
                button.Background = (SolidColorBrush)themeDict["PrimaryBackground"];
            }
        }

       
        private static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        private void ChangeTheme(string theme)
        {
            try
            {
                
                string themeFileName = theme == "Dark" ? "DarkTheme.xaml" : "LightTheme.xaml";
                string themePath = $"/Themes/{themeFileName}"; 
                var themeUri = new Uri(themePath, UriKind.Relative);

               
                ResourceDictionary themeDict = Application.LoadComponent(themeUri) as ResourceDictionary;

                
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(themeDict);

                
                UpdateButtonStyles(themeDict);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Ошибка при смене темы: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void OpenDataEntryWindow(object sender, RoutedEventArgs e)
        {
            DataEntryWindow entryWindow = new DataEntryWindow();
            entryWindow.Show();
            MainSnackbar.MessageQueue?.Enqueue("Открыто окно ввода данных");
        }
        private void OpenStatementWindow_Click(object sender, RoutedEventArgs e)
        { 
            StatementWindow statementWindow = new StatementWindow();
            statementWindow.Show(); 
        }
        private void OpenCorrectionWindow_Click(object sender, RoutedEventArgs e)
        {
            CorrectionWindow correctionWindow = new CorrectionWindow();
            correctionWindow.Show(); 
        }
        private void OpenAnalysisWindow_Click(object sender, RoutedEventArgs e)
        {
            AnalysisWindow analysisWindow = new AnalysisWindow();
            analysisWindow.Show(); 
        }
        private void UpdateButtonStyles()
        {
            foreach (Window window in Application.Current.Windows)
            {
                var buttons = FindVisualChildren<Button>(window);
                foreach (var button in buttons)
                {
                    button.Foreground = (SolidColorBrush)Application.Current.Resources["PrimaryForeground"];
                    button.Background = (SolidColorBrush)Application.Current.Resources["PrimaryBackground"];
                }
            }
        }
        
    }
}
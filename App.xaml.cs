using Serilog;
using System.Configuration;
using System.Data;
using System.Windows;
using Serilog;
using WpfAppFinanse.ViewModels;
namespace WpfAppFinanse
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public bool IsLightTheme { get; internal set; }
        public void ChangeTheme(string theme)
        {
            var themeUri = theme == "Light" ? "Themes/LightTheme.xaml" : "Themes/DarkTheme.xaml";
            var uri = new Uri(themeUri, UriKind.Relative);
            var themeDict = new ResourceDictionary { Source = uri };
            Resources.MergedDictionaries[0] = themeDict;
            IsLightTheme = theme == "Light";
        }
        public App()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("logs\\myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();

            Log.Information("Application Starting Up");
           
        }
        
    }
}



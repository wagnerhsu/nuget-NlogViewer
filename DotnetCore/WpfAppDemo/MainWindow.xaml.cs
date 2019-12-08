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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Extensions.Logging;
using NLog;
using ILogger = NLog.ILogger;

namespace WpfAppDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ILogger<MainWindow> Logger;
        public MainWindow(ILogger<MainWindow> logger)
        {
            Logger = logger;
            InitializeComponent();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            if (button == null) return;

            if (button.Name == nameof(btnTest))
            {
                Logger.LogInformation("Information");
                try
                {
                    int i = 0;
                    int j = 1 / i;
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex, "Error Information");
                }
            }
        }
    }
}

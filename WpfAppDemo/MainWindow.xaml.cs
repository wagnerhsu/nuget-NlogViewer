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
using NLog;

namespace WpfAppDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ILogger Logger = LogManager.CreateNullLogger();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            if (button == null) return;

            if (button.Name == nameof(btnTest))
            {
                Logger.Info("Information");
                try
                {
                    int i = 0;
                    int j = 1 / i;
                }
                catch (Exception ex)
                {
                    Logger.Error(ex, "Error Information");
                }
            }
        }
    }
}

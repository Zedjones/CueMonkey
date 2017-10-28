using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CueMonkey
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object Sender, StartupEventArgs e) {
            MainWindow wnd = new MainWindow();
            wnd.Title = "CueMonkey";
            wnd.Show();
        }
    }
}

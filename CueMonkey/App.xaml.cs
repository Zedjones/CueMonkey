using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CueMonkey.Models;
using CueMonkey.Controllers;

namespace CueMonkey
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private AppController appController;

        /// <summary>
        /// Overrides default startup function for application
        /// Sets up controller for the application
        /// </summary>
        /// <param name="Sender"></param>
        /// <param name="e"></param>
        /// 
        private void Application_Startup(object Sender, StartupEventArgs e) {

            //Create new Controller for the Application
            appController = new AppController();
            
            //Create New Window and pass Controller and set Title of Window
            MainWindow wnd = new MainWindow(appController)
            {
                Title = "CueMonkey"
            };

            //Show the Window
            wnd.Show();
        }
    }
}

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
using CueMonkey.Controllers;

namespace CueMonkey
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        ///Application Controller Passed From App.xaml.cs
        private AppController controller;
        
        public MainWindow(AppController controller)
        {
            ///Save Controller Object
            this.controller = controller;

            ///Initialize Window
            InitializeComponent();
        }

        private void AudioBtnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}

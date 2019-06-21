using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WorkFlowMax_Timer_GUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private bool _timmerRunning = false;
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Startbutton_Click(object sender, RoutedEventArgs e)
        {
            
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            Displaytext.Text = timer.Interval.Ticks.ToString(@"hh\:mm\:ss");
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            Displaytext.Text = timer.Interval.ToString();
        }

        private void Stopbutton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            _timmerRunning = false;
        }

        


        
    }
}

//TimeSpan elapsed = DateTime.Now - StartTime;

//// Start with the days if greater than 0.
//string text = "";
//    if (elapsed.Days > 0)
//        text += elapsed.Days.ToString() + ".";

//    // Convert milliseconds into tenths of seconds.
//    int tenths = elapsed.Milliseconds / 100;

//// Compose the rest of the elapsed time.
//text +=
//        elapsed.Hours.ToString("00") + ":" +
//        elapsed.Minutes.ToString("00") + ":" +
//        elapsed.Seconds.ToString("00") + "." +
//        tenths.ToString("0");

//    lblElapsed.Text = text;
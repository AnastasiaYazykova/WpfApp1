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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      

        private void pic1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("картина");
        }

        private void pic2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("картина");
        }

        private void pic3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("картина");
        }

        private void pic4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("картина");
        }

        private void pic5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("картина");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("назад");
        }

        private void Front_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("вперед");
        }

        private void bottom1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("что то");
        }

        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (mePlayer.Source != null)
            {
                if (mePlayer.NaturalDuration.HasTimeSpan)
                    lblStatus.Content = String.Format("{0} / {1}", mePlayer.Position.ToString(@"mm\:ss"), mePlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void butnPause_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Pause();
        }

        private void butnStop_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Stop();
        }

        private void butnPlay_Click(object sender, RoutedEventArgs e)
        {
            mePlayer.Play();
        }
    }
}

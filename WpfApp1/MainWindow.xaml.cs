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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

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
    }
}

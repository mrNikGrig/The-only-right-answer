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
using System.Threading;

namespace sberbank
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ButtonYes_Click(object sender, RoutedEventArgs e)
        {
            TextBlok1.Visibility = Visibility.Hidden;
            TextBlock2.Visibility = Visibility.Visible;
            ButtonNo.Visibility = Visibility.Hidden;
            ButtonYes.Visibility = Visibility.Hidden;
        }

        private void ButtonNo_MouseEnter(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            int y = rand.Next(0, 400);
            int x = rand.Next(0, 800);
            Canvas.SetLeft(ButtonNo, x);
            Canvas.SetTop(ButtonNo, y);
        }
    }
}

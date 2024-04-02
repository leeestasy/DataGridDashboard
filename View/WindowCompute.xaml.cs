using DataGridDashboard.ViewModel;
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
using System.Windows.Shapes;

namespace DataGridDashboard.View
{
    /// <summary>
    /// Логика взаимодействия для WindowCompute.xaml
    /// </summary>
    public partial class WindowCompute : Window
    {
        public WindowCompute()
        {
            InitializeComponent();
            ProductsViewModel vmProducts = new ProductsViewModel();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private bool IsMaximized = false;

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (this.IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    IsMaximized = true;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;
                    IsMaximized = false;
                }
            }

        }
        private void Click_Main(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
        private void Click_Products(object sender, RoutedEventArgs e)
        {
            WindowProducts wProducts = new WindowProducts();
            wProducts.Show();
            this.Close(); // Если вы хотите закрыть текущее окно при переходе
        }

        private void Click_Calculate(object sender, RoutedEventArgs e)
        {
            WindowCalculate wCalculate = new WindowCalculate();
            wCalculate.Show();
            this.Close(); // Если вы хотите закрыть текущее окно при переходе
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Click_Compute(object sender, RoutedEventArgs e)
        {
            WindowCompute wCompute = new WindowCompute();
            wCompute.Show();
            this.Close();
        }

        private void membersDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}

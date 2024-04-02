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

namespace DataGridDashboard.View
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {
        public PageProduct()
        {
            InitializeComponent();
        }
        private void Click_Main(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }
        private void Click_Products(object sender, RoutedEventArgs e)
        {
            PageProduct pageProduct = new PageProduct(); // Создание экземпляра страницы
            this.Content = pageProduct; // Установка содержимого главного окна на страницу продуктов
        }

        private void Click_Calculate(object sender, RoutedEventArgs e)
        {
            WindowCalculate wCalculate = new WindowCalculate();
            wCalculate.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Click_Compute(object sender, RoutedEventArgs e)
        {
            WindowCompute wCompute = new WindowCompute();
            wCompute.Show();
        }
    }
}

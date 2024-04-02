using DataGridDashboard.View;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;


namespace DataGridDashboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
                PageProduct pageProduct = new PageProduct(); // Создание экземпляра страницы
                this.Content = pageProduct; // Установка содержимого главного окна на страницу продуктов
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

        private void txtSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }

}
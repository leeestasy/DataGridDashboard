using DataGridDashboard.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для WindowCalculate.xaml
    /// </summary>
    public partial class WindowCalculate : Window
    {
        public WindowCalculate()
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

        }`
        private void TextBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ApplyRestrictions(sender as TextBox, e);
        }

        private void TextBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            ApplyRestrictions(sender as TextBox, e);
        }

        private void ApplyRestrictions(TextBox textBox, TextCompositionEventArgs e)
        {
            int value;

            if (!int.TryParse(e.Text, out value) || // Проверяем, что введенный символ - число
                textBox.Text.Length >= 3 || // Запрещаем ввод более трех символов
                textBox.Text == "0" || // Запрещаем ввод нуля
                value <= 0) // Запрещаем ввод отрицательных значений и нуля
            {
                e.Handled = true; // Если хотя бы одно условие не выполняется, блокируем ввод
            }
        }



        //// Свойство для числового значения
        //private int _numericValue;
        //public int NumericValue
        //{
        //    get { return _numericValue; }
        //    set
        //    {
        //        if (value < 1) // Если устанавливается значение меньше 1
        //        {
        //            _numericValue = 1; // Устанавливаем значение 1
        //        }
        //        else
        //        {
        //            _numericValue = value; // Устанавливаем установленное значение
        //        }
        //        OnPropertyChanged(nameof(NumericValue)); // Уведомление об изменении свойства NumericValue
        //    }
        //}


        //public event PropertyChangedEventHandler PropertyChanged;

        //protected void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


        //private void TextBox_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Enter)
        //    {
        //        // Переменная для хранения следующего элемента управления, на который нужно перевести фокус
        //        UIElement nextElement = GetNextElement((sender as UIElement));

        //        // Перевод фокуса на следующий элемент
        //        if (nextElement != null)
        //        {
        //            nextElement.Focus();
        //            e.Handled = true; // Предотвращаем дальнейшую обработку нажатия клавиши Enter
        //        }
        //    }
        //}

        //private UIElement GetNextElement(UIElement currentElement)
        //{
        //    // Получаем контейнер, содержащий элементы управления
        //    Panel parentPanel = VisualTreeHelper.GetParent(currentElement) as Panel;

        //    if (parentPanel != null)
        //    {
        //        // Ищем следующий элемент управления с помощью TabIndex
        //        int currentTabIndex = Panel.GetTabIndex(currentElement);
        //        UIElement nextElement = parentPanel.Children
        //            .OfType<UIElement>()
        //            .FirstOrDefault(element => Panel.GetTabIndex(element) > currentTabIndex);

        //        return nextElement;
        //    }

        //    return null; // Если не удалось найти следующий элемент
        //}

    }
}

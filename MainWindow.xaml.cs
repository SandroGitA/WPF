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

            /*tBox textBox = new TextBox();
            textBox.Text = "Hello";
            MainGrid.Children.Add(textBox);*/

            //List<RowDefinition> rd = new List<RowDefinition>();

            /*RowDefinition rd = new RowDefinition();
            ColumnDefinition cd = new ColumnDefinition();*/

            MainButton.Background = Brushes.Black;
            MainGrid.Background = Brushes.Green;

            for (int i = 0; i < 5; i++)
            {
                RowDefinition rd = new RowDefinition();
                ColumnDefinition cd = new ColumnDefinition();

                MainGrid.RowDefinitions.Add(rd);
                MainGrid.ColumnDefinitions.Add(cd);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

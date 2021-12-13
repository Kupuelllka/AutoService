using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using UsersApp;
namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {

        public Main()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            db.Orders.Load();
            dataGrid.ItemsSource = db.Orders.Local.ToBindingList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Detalsbutton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
           System.Windows.Application.Current.Shutdown();
        }

        private void empoyeebutton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            EmployeeInfo employee = new EmployeeInfo();
            employee.ShowDialog();
        }
    }
}

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
    /// Логика взаимодействия для EmployeeInfo.xaml
    /// </summary>
    public partial class EmployeeInfo : Window
    {
        ApplicationContext db = new ApplicationContext();
        public EmployeeInfo()
        {
            InitializeComponent();
            db.Employees.Load();
            dataGrid.ItemsSource = db.Orders.Local.ToBindingList();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Label_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
        private void Button_Add(object sender, RoutedEventArgs e)
        {
            EmployeeAdd employee = new EmployeeAdd();
            employee.ShowDialog();
        }

        private void Button_Change(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee();
            employee.Id = dataGrid.SelectedIndex+1;
            db.Employees.Attach(employee);
            db.Employees.Remove(employee);

            db.SaveChanges();
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {

        }
    }
}

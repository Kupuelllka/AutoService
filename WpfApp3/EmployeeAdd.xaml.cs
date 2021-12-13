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
using UsersApp;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для EmployeeAdd.xaml
    /// </summary>
    public partial class EmployeeAdd : Window
    {
        ApplicationContext db = new ApplicationContext();
        public EmployeeAdd()
        {
            InitializeComponent();
            textBox_Fio.Text = "";
            textBox_Login.Text = "";
            textBox_Password.Text = "";
            textBox_Password.Text = "";
            textBox_Experience.Text = "";
        }
        public void Check_Password() {


        }
        public void AddEmployee() {
            Employee new_employee = new Employee(textBox_Fio.Text,textBox_Login.Text,textBox_Password.Text,textBox_Experience.Text);
            db.Employees.Add(new_employee);

        }
        private void button_Add_Click(object sender, RoutedEventArgs e)
        {
                AddEmployee();
            if (db.SaveChanges() > 0  ) {
                MessageBox.Show(db.SaveChanges().ToString());
            }
        }

        private void button_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

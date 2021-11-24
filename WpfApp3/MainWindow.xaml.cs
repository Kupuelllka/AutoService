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
using UsersApp;

namespace WpfApp3
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

        private void Autorisation_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string password = TextBoxPassword.Text.Trim();
            if (login.Length < 3)
            {
                TextBoxLogin.ToolTip = "Это поле введено не корректно";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else if (password.Length < 5)
            {
                TextBoxLogin.ToolTip = "Это поле введено не корректно";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            else {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPassword.ToolTip = "";
                TextBoxPassword.Background = Brushes.Transparent;

                Employee authEmployee = null;
                using (ApplicationContext db = new ApplicationContext()) {
                    authEmployee = db.Employees.Where(b => b.Login==login && b.Password== password).FirstOrDefault();
                }
                if (authEmployee != null)
                {
                    MessageBox.Show("Авторизация успешна");
                    Main Main = new Main();
                    this.Close();
                    Main.Show();
                }
                else MessageBox.Show("Вы ввели что-то некорректно");
            }
        }
    }
}

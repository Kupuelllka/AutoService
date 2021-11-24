using System;
namespace UsersApp { 
 class Employee
    {
        public int Id { get; set; }
        private string login, password,fio,experience;
        public string Login { get { return login; } set { login =value; } }
        public string Password { get { return password; } set { password = value; } }
        public string FIO { get { return fio; } set { fio = value; } }
        public string Experience { get { return experience; } set { experience = value; } }
        public Employee() { }
        public Employee(string login, string pass,string fio, string experience) {
            this.fio = fio;
            this.login = login;
            this.password = pass;
            this.experience = experience;
        }
    }
}

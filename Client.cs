using System;
namespace UsersApp { 
 class User
 {
        private int Id { get; set; }
        private string FullName;
        private string PhoneNumber;

        public User() { }
        public User(int id,string FullName, string PhoneNumber) {
            this.Id = id;
            this.FullName = FullName;
            this.PhoneNumber = PhoneNumber; 
        }
 }
}

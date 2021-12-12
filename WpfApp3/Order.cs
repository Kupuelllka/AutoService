using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersApp
{
    class Order
    {
        int Id;
        int Id_auto;
        int Id_owner;
        DateTime DatePostup;
        string Comment;
        public int ID { get { return Id; } set { Id = value; } }
        public int ID_auto { get { return Id_auto; } set { Id_auto = value; } }
        public int ID_owner { get { return Id_owner; } set { Id_owner = value; } }
        public DateTime Datepostup { get { return DatePostup; } set { DatePostup = value; } }
        public string comment { get { return Comment; } set { Comment = value; } }
        public Order() { }
        public Order(int id, int Id_auto, int Id_owner, string comment)
        {
            this.Id = id;
            this.Id_auto = Id_auto;
            this.Id_owner = Id_owner;
            this.Comment = comment;
        }

    }
}

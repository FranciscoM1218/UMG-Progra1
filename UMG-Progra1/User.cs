using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMG_Progra1
{
    class User
    {
        private int id_user;
        private string dpi;
        private string name;
        private string email;
        private int age;
        private bool admin;

        public User(int id_user, string dpi, string name, string email, int age, bool admin)
        {
            this.id_user = id_user;
            this.dpi = dpi;
            this.name = name;
            this.email = email;
            this.admin = admin;
            Console.Write("Otro texto");
        }

    }
}

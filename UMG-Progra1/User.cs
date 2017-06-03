using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMG_Progra1
{
    public class User
    {
        private int id_user;
        private string dpi;
        private string name;
        private string email;
        private int age;
        private bool admin;
        private string password;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int ID
        {
            get
            {
                return id_user;
            }

            set
            {
                id_user = value;
            }
        }

        public User(int id_user, string dpi, string password, string name, string email, int age, bool admin)
        {
            this.id_user = id_user;
            this.dpi = dpi;
            this.password = password;
            this.name = name;
            this.email = email;
            this.admin = admin;
        }
        public User(int id_user, string dpi, string name, string email, int age, bool admin)
        {
            this.id_user = id_user;
            this.dpi = dpi;
            this.name = name;
            this.email = email;
            this.admin = admin;
        }

        // constructor temporal
        public  User(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public User Save ()
        {
            Connection.exec(
                String.Format("INSERT INTO [dbo].[user] "
                       + "([dpi]"
                       + ",[name]"
                       + ",[email]"
                       + ",[password]"
                       + ",[age]"
                       + ",[admin])"
                 + "VALUES"
                       + "('{0}'"
                       + ",'{1}'"
                       + ",'{2}'"
                       + ",'{3}'"
                       + ",{4}"
                       + ",{5})",
                       this.dpi, this.name, this.email, this.password, this.age, this.admin ? 1 : 0));
            return this;
        }
        public User Update()
        {
            Connection.exec(
                String.Format("UPDATE [dbo].[user] "
                       + "SET [dpi] = '{0}'"
                       + ",[name] = '{1}'"
                       + ",[email] = '{2}'"
                       + ",[password] = '{3}'"
                       + ",[age] = {4}"
                       + ",[admin] = {5}"
                 + "WHERE [id_user] = {6} ",
                       this.dpi, this.name, this.email, this.password, this.age, this.admin ? 1 : 0, this.id_user));
            return this;
        }
    }
}

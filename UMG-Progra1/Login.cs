using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UMG_Progra1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        User getUser (string email, string password)
        {
            // if (password.Equals(""))
            SqlDataReader reader = Connection.exec(String.Format("SELECT * FROM [dbo].[user] WHERE [email] = '{0}' AND [password] = '{1}'", email, password));
            if (reader.HasRows && reader.Read())
            {
                return new User(
                    (int) reader.GetValue(reader.GetOrdinal("id_user")),
                    reader.GetValue(reader.GetOrdinal("dpi")).ToString(),
                    reader.GetValue(reader.GetOrdinal("name")).ToString(),
                    reader.GetValue(reader.GetOrdinal("email")).ToString(),
                    (int) reader.GetValue(reader.GetOrdinal("age")),
                    (Boolean) reader.GetValue(reader.GetOrdinal("admin"))
                );
            }
            else
            {
                return null;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var parent = (Main)MdiParent;
            User user = getUser(emailText.Text, paswordText.Text);
            if (user != null)
            {
                parent.EnableMenuStrip(user);
            }
            else
            {
                loginWarning.Visible = true;
            } 
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

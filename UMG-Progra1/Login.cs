using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (password.Equals("test"))
            {
                return new User("Mario", "mario@email.com");
            }
            else
            {
                return null;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var parent = (Form1)MdiParent;
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
    }
}

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
    public partial class Main : Form
    {
        Login login;
        private User currentUser;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.MdiParent = this;
            login.Show();
        }
        public void EnableMenuStrip (User user)
        {
            Console.WriteLine("Enabled");
            //menuStrip1.Items[0].Visible  = false;
            menuStrip1.Visible = true;
            login.Hide();
            this.currentUser = user;
            userMenu.Text = user.Name;
        }

        FrmResidencias residencias;

        private void ingresarResidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (residencias == null)
            {
                residencias = new FrmResidencias();
                residencias.MdiParent = this;
                residencias.FormClosed += new FormClosedEventHandler(residencias_FormClosed);
                residencias.Show();
            }            
        }

        void residencias_FormClosed(object sender, EventArgs e)
        {
            residencias = null;
        }

    }
}

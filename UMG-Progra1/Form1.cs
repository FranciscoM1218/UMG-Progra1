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
    public partial class Form1 : Form
    {
        Login login;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.MdiParent = this;
            login.Show();
        }
        public void EnableMenuStrip ()
        {
            Console.WriteLine("Enabled");
            //menuStrip1.Items[0].Visible  = false;
            menuStrip1.Visible = true;
            login.Hide();

        }
    }
}

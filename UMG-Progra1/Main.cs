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
    public partial class Main : Form
    {
        FrmResidencias residencias;
        FrmUsuarios usuarios;
        FrmEspaciosPublicos espaciospublicos;
        FrmCuotas cuotas;

        Login login;
        private User currentUser;
        public Main()
        {
            /*SqlDataReader reader = Connection.exec("SELECT * FROM [dbo].[user]");
            while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(reader.GetOrdinal("name")));
                MessageBox.Show(reader.GetValue(reader.GetOrdinal("name")).ToString());
            }*/
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.MdiParent = this;
            login.Show();
        }
        public void EnableMenuStrip(User user)
        {
            Console.WriteLine("Enabled");
            //menuStrip1.Items[0].Visible  = false;
            menuStrip1.Visible = true;
            login.Hide();
            this.currentUser = user;
            userMenu.Text = user.Name;
        }

        void residencias_FormClosed(object sender, EventArgs e)
        {
            residencias = null;
        }

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

        void usuarios_FormClosed(object sender, EventArgs e)
        {
            usuarios = null;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuarios == null)
            {
                usuarios = new FrmUsuarios();
                usuarios.MdiParent = this;
                usuarios.FormClosed += new FormClosedEventHandler(usuarios_FormClosed);
                usuarios.Show();
            }
        }

        void espaciospublicos_FormClosed(object sender, EventArgs e)
        {
            //MessageBox.Show("Espacios Publicos cerrado");
            espaciospublicos = null;
        }

        private void espaciosPublicosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (espaciospublicos == null)
            {
                espaciospublicos = new FrmEspaciosPublicos();
                espaciospublicos.MdiParent = this;
                espaciospublicos.FormClosed += new FormClosedEventHandler(espaciospublicos_FormClosed);
                espaciospublicos.Show();
            }
        }

        void cuotas_FormClosed(object sender, EventArgs e)
        {
            //MessageBox.Show("Espacios Publicos cerrado");
            cuotas = null;
        }

        private void cuotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cuotas == null)
            {
                cuotas = new FrmCuotas();
                cuotas.MdiParent = this;
                cuotas.FormClosed += new FormClosedEventHandler(cuotas_FormClosed);
                cuotas.Show();
            }
        }
    }
}

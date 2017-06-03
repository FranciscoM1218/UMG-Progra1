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
    public partial class FrmUsuarios : Form
    {
        DataTable dt;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            adp = Connection.getAdapter("user");

            dt = new DataTable();
            cb = new SqlCommandBuilder(adp);
            adp.Fill(dt);

            dataGridView2.DataSource = dt;
            dataGridView2.Update();
        }

        private void GuardarRow(DataGridViewRow row)
        {
            if (row == null) return;

            User user = new User(
                string.IsNullOrEmpty(row.Cells["id_user"].Value.ToString()) ? -1 : (int)row.Cells["id_user"].Value,
                row.Cells["dpi"].Value.ToString(),
                row.Cells["password"].Value.ToString(),
                row.Cells["name"].Value.ToString(),
                row.Cells["email"].Value.ToString(),
                (int)row.Cells["age"].Value,
                string.IsNullOrEmpty(row.Cells["admin"].Value.ToString()) ? false : (bool)row.Cells["admin"].Value
            );
            
            if(user.ID > 0)
            {
                user.Update();
            } 
            else
            {
                user.Save();
            }
            
            adp.UpdateCommand = cb.GetUpdateCommand();
            adp.Update(dt);
            
            dataGridView2.Refresh();

            MessageBox.Show("Se ha guardado correctamente.");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            /*if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                EliminarRow(dataGridView2.Rows[e.RowIndex]);
                
            }*/

            if (dataGridView2.ColumnCount - 2 == e.ColumnIndex)
            {
                GuardarRow(dataGridView2.Rows[e.RowIndex]);
               // MessageBox.Show("Guardar");
            }

            if (dataGridView2.ColumnCount - 1 == e.ColumnIndex)
            {
                EliminarRow(dataGridView2.Rows[e.RowIndex]);
                // MessageBox.Show("Eliminar");
            }
        }

        private void EliminarRow(DataGridViewRow row)
        {
            if (row == null) return;

            int id = (int)row.Cells["id_user"].Value;

            Connection.deleteRow("user", id);

            dataGridView2.Rows.RemoveAt(row.Index);

            MessageBox.Show("Se elimino correctamente el registro!");
        }

    }
}

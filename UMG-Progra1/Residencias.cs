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
    public partial class FrmResidencias : Form
    {
        public FrmResidencias()
        {
            InitializeComponent();
        }

        private void FrmResidencias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.fee' Puede moverla o quitarla según sea necesario.
            this.feeTableAdapter.Fill(this.umgDataSet.fee);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.user' Puede moverla o quitarla según sea necesario.
            this.userTableAdapter.Fill(this.umgDataSet.user);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.place' Puede moverla o quitarla según sea necesario.
            this.placeTableAdapter.Fill(this.umgDataSet.place);
        }

        DataTable dt;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;

        private void Residencias_Load(object sender, EventArgs e)
        {

            adp = Connection.getAdapter("place", "WHERE type = 'Residencia'");

            dt = new DataTable();
            cb = new SqlCommandBuilder(adp);
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Update();
        }
        
        private void GuardarRow(DataGridViewRow row)
        {
            if (row == null) return;

            Residence residence = new Residence(
                string.IsNullOrEmpty(row.Cells["id_place"].Value.ToString()) ? -1 : (int)row.Cells["id_place"].Value,
                row.Cells["location"].Value.ToString(),
                row.Cells["number"].Value.ToString(),
                (int)row.Cells["id_user"].Value,
                (DateTime)row.Cells["star_date"].Value,
                (DateTime)row.Cells["end_date"].Value,
                (int)row.Cells["id_fee"].Value,
                (int)row.Cells["capacity"].Value,
                row.Cells["status"].Value.ToString()
            );

            if (residence.ID > 0)
            {
                residence.Update();
            }
            else
            {
                residence.Save();
            }

            //adp.UpdateCommand = cb.GetUpdateCommand();
            //adp.Update(dt);

            dataGridView1.Refresh();

            MessageBox.Show("Se ha guardado correctamente.");
            //Console.Write(row.Cells["id_user"].Value);
        }

        private void EliminarRow(DataGridViewRow row)
        {
            if (row == null) return;

            int id = (int)row.Cells["id_place"].Value;

            Connection.deleteRow("place", id);

            dataGridView1.Rows.RemoveAt(row.Index);

            MessageBox.Show("Se elimino correctamente el registro!");
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            /*if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                EliminarRow(dataGridView2.Rows[e.RowIndex]);
                
            }*/

            if (dataGridView1.ColumnCount - 2 == e.ColumnIndex)
            {
                GuardarRow(dataGridView1.Rows[e.RowIndex]);
                //MessageBox.Show("Guardar");
            }

            if (dataGridView1.ColumnCount - 1 == e.ColumnIndex)
            {
                EliminarRow(dataGridView1.Rows[e.RowIndex]);
                //MessageBox.Show("Eliminar");
            }
        }

    }

}

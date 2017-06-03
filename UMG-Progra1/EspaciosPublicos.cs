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
    public partial class FrmEspaciosPublicos : Form
    {
        public FrmEspaciosPublicos()
        {
            InitializeComponent();
        }

        private void FrmEspaciosPublicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet1.place' Puede moverla o quitarla según sea necesario.
            this.placeTableAdapter1.Fill(this.umgDataSet1.place);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.place' Puede moverla o quitarla según sea necesario.
            //this.placeTableAdapter.Fill(this.umgDataSet.place);

        }

        DataTable dt;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;

        private void EspaciosPublicos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet1.fee' Puede moverla o quitarla según sea necesario.
            this.feeTableAdapter1.Fill(this.umgDataSet1.fee);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet1.user' Puede moverla o quitarla según sea necesario.
            this.userTableAdapter1.Fill(this.umgDataSet1.user);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.fee' Puede moverla o quitarla según sea necesario.
            //this.feeTableAdapter.Fill(this.umgDataSet.fee);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.user' Puede moverla o quitarla según sea necesario.
            //this.userTableAdapter.Fill(this.umgDataSet.user);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet1.payment' Puede moverla o quitarla según sea necesario.
            this.paymentTableAdapter.Fill(this.umgDataSet1.payment);

            adp = Connection.getAdapter("place","WHERE type = 'Espacio Publico'");

            dt = new DataTable();
            cb = new SqlCommandBuilder(adp);
            adp.Fill(dt);

            //dataGridView1.DataSource = dt;
           //dataGridView1.Update();
            dataGridView2.DataSource = dt;
            dataGridView2.Update();
        }

        private void GuardarRow(DataGridViewRow row)
        {
            if (row == null) return;

            int id_place = string.IsNullOrEmpty(row.Cells["id_place"].Value.ToString()) ? -1 : (int)row.Cells["id_place"].Value;
            string location = row.Cells["location"].Value.ToString();
            string number = row.Cells["number"].Value.ToString();
            int id_user = (int)row.Cells["id_user"].Value;
            DateTime star_date = (DateTime)row.Cells["star_date"].Value;
            DateTime end_date = (DateTime)row.Cells["end_date"].Value;
            int id_fee = (int)row.Cells["id_fee"].Value;
            int capacity = (int)row.Cells["capacity"].Value;
            string status = row.Cells["status"].Value.ToString();


            PublicSpaces publicspaces = new PublicSpaces(
                id_place,
                location,
                number,
                id_user,
                star_date,
                end_date,
                id_fee,
                capacity,
                status 
            );

            if (publicspaces.ID > 0)
            {
                publicspaces.Update();
            }
            else
            {
                publicspaces.Save();
            }

            //adp.UpdateCommand = cb.GetUpdateCommand();
            //adp.Update(dt);

            dataGridView2.Refresh();

            MessageBox.Show("Se ha guardado correctamente.");
            Console.Write(row.Cells["id_user"].Value);
        }

        private void EliminarRow(DataGridViewRow row)
        {
            if (row == null) return;

            int id = (int)row.Cells["id_place"].Value;

            Connection.deleteRow("place", id);

            dataGridView2.Rows.RemoveAt(row.Index);

            MessageBox.Show("Se elimino correctamente el registro!");
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
                //MessageBox.Show("Guardar");
            }

            if (dataGridView2.ColumnCount - 1 == e.ColumnIndex)
            {
                EliminarRow(dataGridView2.Rows[e.RowIndex]);
                //MessageBox.Show("Eliminar");
            }
        }
    }


}

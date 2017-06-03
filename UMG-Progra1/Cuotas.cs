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
    public partial class FrmCuotas : Form
    {

        public FrmCuotas()
        {
            InitializeComponent();
        }

        DataTable dt;
        SqlDataAdapter adp;
        SqlCommandBuilder cb;
        private void Cuotas_Load(object sender, EventArgs e)
        {

            adp = Connection.getAdapter("payment");

            dt = new DataTable();
            cb = new SqlCommandBuilder(adp);
            adp.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Update();
        }

        private void FrmCuotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.user' Puede moverla o quitarla según sea necesario.
            this.userTableAdapter1.Fill(this.umgDataSet.user);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.payment' Puede moverla o quitarla según sea necesario.
            this.paymentTableAdapter.Fill(this.umgDataSet.payment);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.fee' Puede moverla o quitarla según sea necesario.
            this.feeTableAdapter.Fill(this.umgDataSet.fee);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet.place' Puede moverla o quitarla según sea necesario.
            this.placeTableAdapter1.Fill(this.umgDataSet.place);
            // TODO: esta línea de código carga datos en la tabla 'umgDataSet1.user' Puede moverla o quitarla según sea necesario.


        }

        private void GuardarRow(DataGridViewRow row)
        {
            if (row == null) return;

            int id_payment = string.IsNullOrEmpty(row.Cells["id_payment"].Value.ToString()) ? -1 : (int)row.Cells["id_payment"].Value;
            int id_place = (int)row.Cells["id_place"].Value;
            DateTime date = (DateTime)row.Cells["date"].Value;
            int id_user = (int)row.Cells["id_user"].Value;
            int id_fee = (int)row.Cells["id_fee"].Value;


            Payment payment = new Payment(id_payment,
                id_place,
                date,
                id_user,
                id_fee                
            );

            if (payment.ID > 0)
            {
                payment.Update();
            }
            else
            {
                payment.Save();
            }

            //adp.UpdateCommand = cb.GetUpdateCommand();
            //adp.Update(dt);

            dataGridView1.Refresh();

            MessageBox.Show("Se ha guardado correctamente.");
        }

       /* private void EliminarRow(DataGridViewRow row)
        {
            if (row == null) return;

            int id = (int)row.Cells["id_payment"].Value;

            Connection.deleteRow("payment", id);

            dataGridView1.Rows.RemoveAt(row.Index);

            MessageBox.Show("Se elimino correctamente el registro!");
        }*/

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            /*if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                EliminarRow(dataGridView2.Rows[e.RowIndex]);
                
            }*/

            if (dataGridView1.ColumnCount - 1 == e.ColumnIndex)
            {
                GuardarRow(dataGridView1.Rows[e.RowIndex]);
                //MessageBox.Show("Guardar");
            }

            /*if (dataGridView1.ColumnCount - 1 == e.ColumnIndex)
            {
                EliminarRow(dataGridView1.Rows[e.RowIndex]);
                //MessageBox.Show("Eliminar");
            }*/
        }
    }
}

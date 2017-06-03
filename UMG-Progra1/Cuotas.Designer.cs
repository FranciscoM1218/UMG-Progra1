namespace UMG_Progra1
{
    partial class FrmCuotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new UMG_Progra1.umgDataSet1TableAdapters.userTableAdapter();
            this.umgDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.placeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.umgDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.placeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.placeTableAdapter1 = new UMG_Progra1.umgDataSetTableAdapters.placeTableAdapter();
            this.umgDataSet = new UMG_Progra1.umgDataSet();
            this.feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feeTableAdapter = new UMG_Progra1.umgDataSetTableAdapters.feeTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new UMG_Progra1.umgDataSetTableAdapters.paymentTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new UMG_Progra1.umgDataSetTableAdapters.userTableAdapter();
            this.feeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id_payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_place = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_fee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Guardar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // placeTableAdapter1
            // 
            this.placeTableAdapter1.ClearBeforeFill = true;
            // 
            // umgDataSet
            // 
            this.umgDataSet.DataSetName = "umgDataSet";
            this.umgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feeBindingSource
            // 
            this.feeBindingSource.DataMember = "fee";
            this.feeBindingSource.DataSource = this.umgDataSet;
            // 
            // feeTableAdapter
            // 
            this.feeTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.umgDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_payment,
            this.id_place,
            this.date,
            this.id_user,
            this.id_fee,
            this.Guardar});
            this.dataGridView1.DataSource = this.paymentBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(711, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "payment";
            this.paymentBindingSource1.DataSource = this.umgDataSet;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "place";
            this.placeBindingSource.DataSource = this.umgDataSet;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "user";
            this.userBindingSource1.DataSource = this.umgDataSet;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // feeBindingSource1
            // 
            this.feeBindingSource1.DataMember = "fee";
            this.feeBindingSource1.DataSource = this.umgDataSet;
            // 
            // id_payment
            // 
            this.id_payment.DataPropertyName = "id_payment";
            this.id_payment.HeaderText = "id_payment";
            this.id_payment.Name = "id_payment";
            this.id_payment.ReadOnly = true;
            // 
            // id_place
            // 
            this.id_place.DataPropertyName = "id_place";
            this.id_place.DataSource = this.placeBindingSource;
            this.id_place.DisplayMember = "location";
            this.id_place.HeaderText = "Lugar";
            this.id_place.Name = "id_place";
            this.id_place.ValueMember = "id_place";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.Name = "date";
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.DataSource = this.userBindingSource1;
            this.id_user.DisplayMember = "name";
            this.id_user.HeaderText = "Usuario";
            this.id_user.Name = "id_user";
            this.id_user.ValueMember = "id_user";
            // 
            // id_fee
            // 
            this.id_fee.DataPropertyName = "id_fee";
            this.id_fee.DataSource = this.feeBindingSource1;
            this.id_fee.DisplayMember = "amount";
            this.id_fee.HeaderText = "Cuota";
            this.id_fee.Name = "id_fee";
            this.id_fee.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_fee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_fee.ValueMember = "id_fee";
            // 
            // Guardar
            // 
            this.Guardar.HeaderText = "Guardar";
            this.Guardar.Name = "Guardar";
            // 
            // FrmCuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmCuotas";
            this.Text = "Cuotas";
            this.Load += new System.EventHandler(this.FrmCuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource userBindingSource;
        private umgDataSet1TableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource placeBindingSource1;
        private System.Windows.Forms.BindingSource umgDataSet1BindingSource;
        private System.Windows.Forms.BindingSource placeBindingSource2;
        private System.Windows.Forms.BindingSource paymentBindingSource2;
        private System.Windows.Forms.BindingSource umgDataSetBindingSource1;
        private System.Windows.Forms.BindingSource placeBindingSource3;
        private umgDataSetTableAdapters.placeTableAdapter placeTableAdapter1;
        private umgDataSet umgDataSet;
        private System.Windows.Forms.BindingSource feeBindingSource;
        private umgDataSetTableAdapters.feeTableAdapter feeTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private umgDataSetTableAdapters.paymentTableAdapter paymentTableAdapter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private umgDataSetTableAdapters.userTableAdapter userTableAdapter1;
        private System.Windows.Forms.BindingSource feeBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_payment;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_user;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_fee;
        private System.Windows.Forms.DataGridViewButtonColumn Guardar;
    }
}
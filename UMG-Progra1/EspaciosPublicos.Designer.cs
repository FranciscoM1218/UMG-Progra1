namespace UMG_Progra1
{
    partial class FrmEspaciosPublicos
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
            this.umgDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.umgDataSet1 = new UMG_Progra1.umgDataSet1();
            this.fKpaymentplaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new UMG_Progra1.umgDataSetTableAdapters.userTableAdapter();
            this.feeTableAdapter = new UMG_Progra1.umgDataSetTableAdapters.feeTableAdapter();
            this.placeTableAdapter1 = new UMG_Progra1.umgDataSet1TableAdapters.placeTableAdapter();
            this.paymentTableAdapter = new UMG_Progra1.umgDataSet1TableAdapters.paymentTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.umgDataSet = new UMG_Progra1.umgDataSet();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.feeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new UMG_Progra1.umgDataSet1TableAdapters.userTableAdapter();
            this.feeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.feeTableAdapter1 = new UMG_Progra1.umgDataSet1TableAdapters.feeTableAdapter();
            this.id_place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.star_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpaymentplaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = this.umgDataSetBindingSource;
            // 
            // feeBindingSource
            // 
            this.feeBindingSource.DataSource = this.umgDataSetBindingSource;
            // 
            // placeBindingSource1
            // 
            this.placeBindingSource1.DataMember = "place";
            this.placeBindingSource1.DataSource = this.umgDataSet1;
            // 
            // umgDataSet1
            // 
            this.umgDataSet1.DataSetName = "umgDataSet1";
            this.umgDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKpaymentplaceBindingSource
            // 
            this.fKpaymentplaceBindingSource.DataMember = "FK_payment_place";
            this.fKpaymentplaceBindingSource.DataSource = this.placeBindingSource1;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // feeTableAdapter
            // 
            this.feeTableAdapter.ClearBeforeFill = true;
            // 
            // placeTableAdapter1
            // 
            this.placeTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_place,
            this.location,
            this.number,
            this.id_user,
            this.star_date,
            this.end_date,
            this.id_fee,
            this.capacity,
            this.status,
            this.Guardar,
            this.Eliminar});
            this.dataGridView2.DataSource = this.placeBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1335, 226);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // umgDataSet
            // 
            this.umgDataSet.DataSetName = "umgDataSet";
            this.umgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "user";
            this.userBindingSource1.DataSource = this.umgDataSet;
            // 
            // feeBindingSource1
            // 
            this.feeBindingSource1.DataMember = "fee";
            this.feeBindingSource1.DataSource = this.umgDataSet;
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataMember = "user";
            this.userBindingSource2.DataSource = this.umgDataSet1;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // feeBindingSource2
            // 
            this.feeBindingSource2.DataMember = "fee";
            this.feeBindingSource2.DataSource = this.umgDataSet1;
            // 
            // feeTableAdapter1
            // 
            this.feeTableAdapter1.ClearBeforeFill = true;
            // 
            // id_place
            // 
            this.id_place.DataPropertyName = "id_place";
            this.id_place.HeaderText = "id_place";
            this.id_place.Name = "id_place";
            this.id_place.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "location";
            this.location.Name = "location";
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "number";
            this.number.Name = "number";
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.DataSource = this.userBindingSource2;
            this.id_user.DisplayMember = "name";
            this.id_user.HeaderText = "Usuario";
            this.id_user.Name = "id_user";
            this.id_user.ValueMember = "id_user";
            // 
            // star_date
            // 
            this.star_date.DataPropertyName = "star_date";
            this.star_date.HeaderText = "star_date";
            this.star_date.Name = "star_date";
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "end_date";
            this.end_date.Name = "end_date";
            // 
            // id_fee
            // 
            this.id_fee.DataPropertyName = "id_fee";
            this.id_fee.DataSource = this.feeBindingSource2;
            this.id_fee.DisplayMember = "amount";
            this.id_fee.HeaderText = "Cuota";
            this.id_fee.Name = "id_fee";
            this.id_fee.ValueMember = "id_fee";
            // 
            // capacity
            // 
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "capacity";
            this.capacity.Name = "capacity";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "status";
            this.status.Name = "status";
            // 
            // Guardar
            // 
            this.Guardar.HeaderText = "Guardar";
            this.Guardar.Name = "Guardar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // FrmEspaciosPublicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 509);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FrmEspaciosPublicos";
            this.Text = "EspaciosPublicos";
            this.Load += new System.EventHandler(this.EspaciosPublicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKpaymentplaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource umgDataSetBindingSource;
        private umgDataSet1 umgDataSet1;
        private System.Windows.Forms.BindingSource placeBindingSource1;
        private umgDataSet1TableAdapters.placeTableAdapter placeTableAdapter1;
        private System.Windows.Forms.BindingSource fKpaymentplaceBindingSource;
        private umgDataSet1TableAdapters.paymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private umgDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource feeBindingSource;
        private umgDataSetTableAdapters.feeTableAdapter feeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private umgDataSet umgDataSet;
        private System.Windows.Forms.BindingSource feeBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private umgDataSet1TableAdapters.userTableAdapter userTableAdapter1;
        private System.Windows.Forms.BindingSource feeBindingSource2;
        private umgDataSet1TableAdapters.feeTableAdapter feeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_place;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn star_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_date;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewButtonColumn Guardar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}
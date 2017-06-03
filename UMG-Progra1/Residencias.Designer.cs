namespace UMG_Progra1
{
    partial class FrmResidencias
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umgDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umgDataSet = new UMG_Progra1.umgDataSet();
            this.feeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeTableAdapter = new UMG_Progra1.umgDataSetTableAdapters.placeTableAdapter();
            this.userTableAdapter = new UMG_Progra1.umgDataSetTableAdapters.userTableAdapter();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.feeTableAdapter = new UMG_Progra1.umgDataSetTableAdapters.feeTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.placeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1150, 500);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "user";
            this.userBindingSource.DataSource = this.umgDataSetBindingSource;
            // 
            // umgDataSetBindingSource
            // 
            this.umgDataSetBindingSource.DataSource = this.umgDataSet;
            this.umgDataSetBindingSource.Position = 0;
            // 
            // umgDataSet
            // 
            this.umgDataSet.DataSetName = "umgDataSet";
            this.umgDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feeBindingSource
            // 
            this.feeBindingSource.DataMember = "fee";
            this.feeBindingSource.DataSource = this.umgDataSetBindingSource;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "place";
            this.placeBindingSource.DataSource = this.umgDataSetBindingSource;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "user";
            this.userBindingSource1.DataSource = this.umgDataSetBindingSource;
            // 
            // feeTableAdapter
            // 
            this.feeTableAdapter.ClearBeforeFill = true;
            // 
            // id_place
            // 
            this.id_place.DataPropertyName = "id_place";
            this.id_place.HeaderText = "Lugar";
            this.id_place.Name = "id_place";
            this.id_place.ReadOnly = true;
            // 
            // location
            // 
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Ubicación";
            this.location.Name = "location";
            // 
            // number
            // 
            this.number.DataPropertyName = "number";
            this.number.HeaderText = "Número";
            this.number.Name = "number";
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.DataSource = this.userBindingSource;
            this.id_user.DisplayMember = "name";
            this.id_user.HeaderText = "Usuario";
            this.id_user.Name = "id_user";
            this.id_user.ValueMember = "id_user";
            // 
            // star_date
            // 
            this.star_date.DataPropertyName = "star_date";
            this.star_date.HeaderText = "Fecha Inicial";
            this.star_date.Name = "star_date";
            // 
            // end_date
            // 
            this.end_date.DataPropertyName = "end_date";
            this.end_date.HeaderText = "Fecha Final";
            this.end_date.Name = "end_date";
            // 
            // id_fee
            // 
            this.id_fee.DataPropertyName = "id_fee";
            this.id_fee.DataSource = this.feeBindingSource;
            this.id_fee.DisplayMember = "amount";
            this.id_fee.HeaderText = "Cuota";
            this.id_fee.Name = "id_fee";
            this.id_fee.ValueMember = "id_fee";
            // 
            // capacity
            // 
            this.capacity.DataPropertyName = "capacity";
            this.capacity.HeaderText = "Capcidad";
            this.capacity.Name = "capacity";
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Estado";
            this.status.Name = "status";
            // 
            // Guardar
            // 
            this.Guardar.HeaderText = "Guardar";
            this.Guardar.Name = "Guardar";
            this.Guardar.ReadOnly = true;
            this.Guardar.Text = "Guardar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            // 
            // FrmResidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 523);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmResidencias";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmResidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umgDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource umgDataSetBindingSource;
        private umgDataSet umgDataSet;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private umgDataSetTableAdapters.placeTableAdapter placeTableAdapter;
        private umgDataSetTableAdapters.userTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource feeBindingSource;
        private umgDataSetTableAdapters.feeTableAdapter feeTableAdapter;
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
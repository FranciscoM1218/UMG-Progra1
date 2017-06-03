namespace UMG_Progra1
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarResidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espaciosPublicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.userMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarResidenciasToolStripMenuItem,
            this.espaciosPublicosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.cuotasToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // ingresarResidenciasToolStripMenuItem
            // 
            this.ingresarResidenciasToolStripMenuItem.Name = "ingresarResidenciasToolStripMenuItem";
            this.ingresarResidenciasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ingresarResidenciasToolStripMenuItem.Text = "Residencias";
            this.ingresarResidenciasToolStripMenuItem.Click += new System.EventHandler(this.ingresarResidenciasToolStripMenuItem_Click);
            // 
            // espaciosPublicosToolStripMenuItem
            // 
            this.espaciosPublicosToolStripMenuItem.Name = "espaciosPublicosToolStripMenuItem";
            this.espaciosPublicosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.espaciosPublicosToolStripMenuItem.Text = "Espacios publicos";
            this.espaciosPublicosToolStripMenuItem.Click += new System.EventHandler(this.espaciosPublicosToolStripMenuItem_Click_1);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // cuotasToolStripMenuItem
            // 
            this.cuotasToolStripMenuItem.Name = "cuotasToolStripMenuItem";
            this.cuotasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cuotasToolStripMenuItem.Text = "Cuotas";
            this.cuotasToolStripMenuItem.Click += new System.EventHandler(this.cuotasToolStripMenuItem_Click);
            // 
            // userMenu
            // 
            this.userMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.userMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.userMenu.Name = "userMenu";
            this.userMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userMenu.Size = new System.Drawing.Size(12, 20);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Cerrar Sesión";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 456);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Administración de Condominio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarResidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espaciosPublicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}


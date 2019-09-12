namespace WindowsFormsApp1
{
    partial class FrmPrincipal
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
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motivoCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbMostrarTurnos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFiltroClientePrincipal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdBuscarClientesPrincipal = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscarClientesPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.citasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.motivoCitasToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // motivoCitasToolStripMenuItem
            // 
            this.motivoCitasToolStripMenuItem.Name = "motivoCitasToolStripMenuItem";
            this.motivoCitasToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.motivoCitasToolStripMenuItem.Text = "Motivo citas";
            this.motivoCitasToolStripMenuItem.Click += new System.EventHandler(this.motivoCitasToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCitasToolStripMenuItem});
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // verCitasToolStripMenuItem
            // 
            this.verCitasToolStripMenuItem.Name = "verCitasToolStripMenuItem";
            this.verCitasToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verCitasToolStripMenuItem.Text = "Crear citas";
            // 
            // lbMostrarTurnos
            // 
            this.lbMostrarTurnos.FormattingEnabled = true;
            this.lbMostrarTurnos.Location = new System.Drawing.Point(12, 59);
            this.lbMostrarTurnos.Name = "lbMostrarTurnos";
            this.lbMostrarTurnos.Size = new System.Drawing.Size(253, 225);
            this.lbMostrarTurnos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turnos para hoy";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtFiltroClientePrincipal
            // 
            this.TxtFiltroClientePrincipal.Location = new System.Drawing.Point(302, 59);
            this.TxtFiltroClientePrincipal.Name = "TxtFiltroClientePrincipal";
            this.TxtFiltroClientePrincipal.Size = new System.Drawing.Size(320, 20);
            this.TxtFiltroClientePrincipal.TabIndex = 3;
            this.TxtFiltroClientePrincipal.TextChanged += new System.EventHandler(this.TxtFiltroClientePrincipal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // grdBuscarClientesPrincipal
            // 
            this.grdBuscarClientesPrincipal.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdBuscarClientesPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscarClientesPrincipal.Location = new System.Drawing.Point(302, 85);
            this.grdBuscarClientesPrincipal.MultiSelect = false;
            this.grdBuscarClientesPrincipal.Name = "grdBuscarClientesPrincipal";
            this.grdBuscarClientesPrincipal.ReadOnly = true;
            this.grdBuscarClientesPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdBuscarClientesPrincipal.Size = new System.Drawing.Size(320, 150);
            this.grdBuscarClientesPrincipal.TabIndex = 4;
            this.grdBuscarClientesPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBuscarClientesPrincipal_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Actualizar Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdBuscarClientesPrincipal);
            this.Controls.Add(this.TxtFiltroClientePrincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMostrarTurnos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscarClientesPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motivoCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCitasToolStripMenuItem;
        private System.Windows.Forms.ListBox lbMostrarTurnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFiltroClientePrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdBuscarClientesPrincipal;
        private System.Windows.Forms.Button button1;
    }
}


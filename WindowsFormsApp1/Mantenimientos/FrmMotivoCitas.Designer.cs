namespace WindowsFormsApp1.Mantenimientos
{
    partial class FrmMotivoCitas
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
            this.tabControlMotivoCitas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.GrdMotivoCita = new System.Windows.Forms.DataGridView();
            this.txtFiltroMotivoCita = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtInsertarMotivoCita = new System.Windows.Forms.TextBox();
            this.lblIDMotivoCita = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMotivoCitas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMotivoCita)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMotivoCitas
            // 
            this.tabControlMotivoCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMotivoCitas.Controls.Add(this.tabPage1);
            this.tabControlMotivoCitas.Controls.Add(this.tabPage2);
            this.tabControlMotivoCitas.Location = new System.Drawing.Point(0, 27);
            this.tabControlMotivoCitas.Name = "tabControlMotivoCitas";
            this.tabControlMotivoCitas.SelectedIndex = 0;
            this.tabControlMotivoCitas.Size = new System.Drawing.Size(294, 245);
            this.tabControlMotivoCitas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.GrdMotivoCita);
            this.tabPage1.Controls.Add(this.txtFiltroMotivoCita);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(286, 219);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de citas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filtro";
            // 
            // GrdMotivoCita
            // 
            this.GrdMotivoCita.AllowUserToAddRows = false;
            this.GrdMotivoCita.AllowUserToDeleteRows = false;
            this.GrdMotivoCita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrdMotivoCita.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrdMotivoCita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdMotivoCita.Location = new System.Drawing.Point(8, 48);
            this.GrdMotivoCita.Name = "GrdMotivoCita";
            this.GrdMotivoCita.ReadOnly = true;
            this.GrdMotivoCita.Size = new System.Drawing.Size(272, 165);
            this.GrdMotivoCita.TabIndex = 1;
            this.GrdMotivoCita.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrdMotivoCita_CellMouseDoubleClick);
            // 
            // txtFiltroMotivoCita
            // 
            this.txtFiltroMotivoCita.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltroMotivoCita.Location = new System.Drawing.Point(8, 22);
            this.txtFiltroMotivoCita.Name = "txtFiltroMotivoCita";
            this.txtFiltroMotivoCita.Size = new System.Drawing.Size(272, 20);
            this.txtFiltroMotivoCita.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtInsertarMotivoCita);
            this.tabPage2.Controls.Add(this.lblIDMotivoCita);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(286, 219);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro citas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtInsertarMotivoCita
            // 
            this.txtInsertarMotivoCita.Location = new System.Drawing.Point(11, 56);
            this.txtInsertarMotivoCita.Name = "txtInsertarMotivoCita";
            this.txtInsertarMotivoCita.Size = new System.Drawing.Size(191, 20);
            this.txtInsertarMotivoCita.TabIndex = 1;
            // 
            // lblIDMotivoCita
            // 
            this.lblIDMotivoCita.AutoSize = true;
            this.lblIDMotivoCita.Location = new System.Drawing.Point(32, 14);
            this.lblIDMotivoCita.Name = "lblIDMotivoCita";
            this.lblIDMotivoCita.Size = new System.Drawing.Size(13, 13);
            this.lblIDMotivoCita.TabIndex = 0;
            this.lblIDMotivoCita.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // FrmMotivoCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 274);
            this.Controls.Add(this.tabControlMotivoCitas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMotivoCitas";
            this.Text = "Motivos de cita";
            this.Load += new System.EventHandler(this.FrmMotivoCitas_Load);
            this.tabControlMotivoCitas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdMotivoCita)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMotivoCitas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GrdMotivoCita;
        private System.Windows.Forms.TextBox txtFiltroMotivoCita;
        private System.Windows.Forms.TextBox txtInsertarMotivoCita;
        private System.Windows.Forms.Label lblIDMotivoCita;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}
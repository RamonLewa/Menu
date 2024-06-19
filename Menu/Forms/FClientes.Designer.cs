namespace Menu.Forms
{
    partial class FClientes
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
            this.DataGridClientes = new System.Windows.Forms.DataGridView();
            this.ContextMenuClientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarClientes = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).BeginInit();
            this.ContextMenuClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridClientes
            // 
            this.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClientes.Location = new System.Drawing.Point(12, 114);
            this.DataGridClientes.Name = "DataGridClientes";
            this.DataGridClientes.Size = new System.Drawing.Size(776, 324);
            this.DataGridClientes.TabIndex = 0;
            this.DataGridClientes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridClientes_MouseDown);
            // 
            // ContextMenuClientes
            // 
            this.ContextMenuClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarClientes,
            this.toolStripSeparator1,
            this.importarClientes});
            this.ContextMenuClientes.Name = "ContextMenuClientes";
            this.ContextMenuClientes.Size = new System.Drawing.Size(184, 76);
            // 
            // exportarClientes
            // 
            this.exportarClientes.Name = "exportarClientes";
            this.exportarClientes.Size = new System.Drawing.Size(183, 22);
            this.exportarClientes.Text = "Exportar clientes .xls";
            this.exportarClientes.Click += new System.EventHandler(this.exportarClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // importarClientes
            // 
            this.importarClientes.Name = "importarClientes";
            this.importarClientes.Size = new System.Drawing.Size(183, 22);
            this.importarClientes.Text = "Importar clientes .xls";
            this.importarClientes.Click += new System.EventHandler(this.importarClientes_Click);
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataGridClientes);
            this.Name = "FClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).EndInit();
            this.ContextMenuClientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGridClientes;
        private System.Windows.Forms.ContextMenuStrip ContextMenuClientes;
        private System.Windows.Forms.ToolStripMenuItem exportarClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarClientes;
    }
}
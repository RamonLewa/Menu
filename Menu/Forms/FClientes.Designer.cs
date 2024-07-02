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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FClientes));
            this.DataGridClientes = new System.Windows.Forms.DataGridView();
            this.ContextMenuClientes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClientes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).BeginInit();
            this.ContextMenuClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridClientes
            // 
            this.DataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClientes.Location = new System.Drawing.Point(12, 51);
            this.DataGridClientes.Name = "DataGridClientes";
            this.DataGridClientes.Size = new System.Drawing.Size(1880, 770);
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
            this.ContextMenuClientes.Size = new System.Drawing.Size(190, 54);
            // 
            // exportarClientes
            // 
            this.exportarClientes.Name = "exportarClientes";
            this.exportarClientes.Size = new System.Drawing.Size(189, 22);
            this.exportarClientes.Text = "Exportar clientes .xlsx";
            this.exportarClientes.Click += new System.EventHandler(this.exportarClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // importarClientes
            // 
            this.importarClientes.Name = "importarClientes";
            this.importarClientes.Size = new System.Drawing.Size(189, 22);
            this.importarClientes.Text = "Importar clientes .xlsx";
            this.importarClientes.Click += new System.EventHandler(this.importarClientes_Click);
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.Location = new System.Drawing.Point(9, 9);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(876, 16);
            this.lblClientes.TabIndex = 1;
            this.lblClientes.Text = "* Importe os dados em uma planilha no modelo: Cliente, Fantasia, CPF, CNPJ, UF, C" +
    "idade, Bairro, Endereço, Número, CEP, Complemento e E-mail";
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 833);
            this.Controls.Add(this.lblClientes);
            this.Controls.Add(this.DataGridClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-8, 169);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClientes)).EndInit();
            this.ContextMenuClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGridClientes;
        private System.Windows.Forms.ContextMenuStrip ContextMenuClientes;
        private System.Windows.Forms.ToolStripMenuItem exportarClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarClientes;
        private System.Windows.Forms.Label lblClientes;
    }
}
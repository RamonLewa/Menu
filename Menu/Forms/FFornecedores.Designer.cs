namespace Menu.Forms
{
    partial class FFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFornecedores));
            this.dataGridFornecedores = new System.Windows.Forms.DataGridView();
            this.contextMenuFornecedores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFornecedores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).BeginInit();
            this.contextMenuFornecedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridFornecedores
            // 
            this.dataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedores.Location = new System.Drawing.Point(12, 51);
            this.dataGridFornecedores.Name = "dataGridFornecedores";
            this.dataGridFornecedores.Size = new System.Drawing.Size(1880, 770);
            this.dataGridFornecedores.TabIndex = 0;
            this.dataGridFornecedores.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridFornecedores_MouseDown);
            // 
            // contextMenuFornecedores
            // 
            this.contextMenuFornecedores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarFornecedores,
            this.toolStripSeparator1,
            this.importarFornecedores});
            this.contextMenuFornecedores.Name = "contextMenuFornecedores";
            this.contextMenuFornecedores.Size = new System.Drawing.Size(219, 54);
            // 
            // exportarFornecedores
            // 
            this.exportarFornecedores.Name = "exportarFornecedores";
            this.exportarFornecedores.Size = new System.Drawing.Size(218, 22);
            this.exportarFornecedores.Text = "Exportar fornecedores .xlsx";
            this.exportarFornecedores.Click += new System.EventHandler(this.exportarFornecedores_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // importarFornecedores
            // 
            this.importarFornecedores.Name = "importarFornecedores";
            this.importarFornecedores.Size = new System.Drawing.Size(218, 22);
            this.importarFornecedores.Text = "Importar fornecedores .xlsx";
            this.importarFornecedores.Click += new System.EventHandler(this.importarFornecedores_Click);
            // 
            // lblFornecedores
            // 
            this.lblFornecedores.AutoSize = true;
            this.lblFornecedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedores.Location = new System.Drawing.Point(9, 9);
            this.lblFornecedores.Name = "lblFornecedores";
            this.lblFornecedores.Size = new System.Drawing.Size(914, 16);
            this.lblFornecedores.TabIndex = 1;
            this.lblFornecedores.Text = "* Importe os dados em uma planilha no modelo: Fantasia, Razão social, CPF, CNPJ, " +
    "UF, Cidade, Bairro, Endereço, CEP, Número, Complemento e E-mail";
            // 
            // FFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 833);
            this.Controls.Add(this.lblFornecedores);
            this.Controls.Add(this.dataGridFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-8, 169);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).EndInit();
            this.contextMenuFornecedores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFornecedores;
        private System.Windows.Forms.ContextMenuStrip contextMenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem exportarFornecedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarFornecedores;
        private System.Windows.Forms.Label lblFornecedores;
    }
}
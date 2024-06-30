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
            this.dataGridFornecedores = new System.Windows.Forms.DataGridView();
            this.contextMenuFornecedores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).BeginInit();
            this.contextMenuFornecedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridFornecedores
            // 
            this.dataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedores.Location = new System.Drawing.Point(12, 124);
            this.dataGridFornecedores.Name = "dataGridFornecedores";
            this.dataGridFornecedores.Size = new System.Drawing.Size(776, 314);
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
            this.contextMenuFornecedores.Size = new System.Drawing.Size(219, 76);
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
            // 
            // FFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridFornecedores);
            this.Name = "FFornecedores";
            this.Text = "FFornecedores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).EndInit();
            this.contextMenuFornecedores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFornecedores;
        private System.Windows.Forms.ContextMenuStrip contextMenuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem exportarFornecedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarFornecedores;
    }
}
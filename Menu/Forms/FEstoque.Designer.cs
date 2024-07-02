namespace Menu.Forms
{
    partial class FEstoque
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
            this.dataGridEstoque = new System.Windows.Forms.DataGridView();
            this.contextMenuEstoque = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportarEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.importarEstoque = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).BeginInit();
            this.contextMenuEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEstoque
            // 
            this.dataGridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstoque.Location = new System.Drawing.Point(12, 104);
            this.dataGridEstoque.Name = "dataGridEstoque";
            this.dataGridEstoque.Size = new System.Drawing.Size(776, 334);
            this.dataGridEstoque.TabIndex = 0;
            this.dataGridEstoque.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridEstoque_MouseDown);
            // 
            // contextMenuEstoque
            // 
            this.contextMenuEstoque.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarEstoque,
            this.toolStripSeparator1,
            this.importarEstoque});
            this.contextMenuEstoque.Name = "contextMenuEstoque";
            this.contextMenuEstoque.Size = new System.Drawing.Size(192, 76);
            // 
            // exportarEstoque
            // 
            this.exportarEstoque.Name = "exportarEstoque";
            this.exportarEstoque.Size = new System.Drawing.Size(191, 22);
            this.exportarEstoque.Text = "Exportar estoque .xlsx";
            this.exportarEstoque.Click += new System.EventHandler(this.exportarEstoque_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // importarEstoque
            // 
            this.importarEstoque.Name = "importarEstoque";
            this.importarEstoque.Size = new System.Drawing.Size(191, 22);
            this.importarEstoque.Text = "Importar estoque .xlsx";
            this.importarEstoque.Click += new System.EventHandler(this.importarEstoque_Click);
            // 
            // FEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridEstoque);
            this.Name = "FEstoque";
            this.Text = "FEstoque";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).EndInit();
            this.contextMenuEstoque.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEstoque;
        private System.Windows.Forms.ContextMenuStrip contextMenuEstoque;
        private System.Windows.Forms.ToolStripMenuItem exportarEstoque;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem importarEstoque;
    }
}
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
            this.dataGridFornecedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFornecedores
            // 
            this.dataGridFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFornecedores.Location = new System.Drawing.Point(12, 12);
            this.dataGridFornecedores.Name = "dataGridFornecedores";
            this.dataGridFornecedores.Size = new System.Drawing.Size(776, 426);
            this.dataGridFornecedores.TabIndex = 0;
            // 
            // FFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridFornecedores);
            this.Name = "FFornecedores";
            this.Text = "FFornecedores";
            this.Load += new System.EventHandler(this.FFornecedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFornecedores;
    }
}
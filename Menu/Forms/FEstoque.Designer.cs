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
            this.dataGridEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEstoque
            // 
            this.dataGridEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEstoque.Location = new System.Drawing.Point(12, 12);
            this.dataGridEstoque.Name = "dataGridEstoque";
            this.dataGridEstoque.Size = new System.Drawing.Size(776, 426);
            this.dataGridEstoque.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEstoque;
    }
}
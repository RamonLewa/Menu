namespace Menu
{
    partial class FMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 144);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(251, 146);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(274, 144);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(251, 146);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(536, 144);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(251, 146);
            this.btnFornecedores.TabIndex = 2;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnClientes);
            this.Name = "FMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnFornecedores;
    }
}


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMenu));
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesCadastrosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueCadastrosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresCadastrosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairCadastrosToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Location = new System.Drawing.Point(169, 61);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(134, 48);
            this.btnEstoque.TabIndex = 1;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(324, 61);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(109, 48);
            this.btnFornecedores.TabIndex = 2;
            this.btnFornecedores.Text = "Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(109)))), ((int)(((byte)(140)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenu,
            this.sairToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenu
            // 
            this.cadastrosToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesCadastrosToolStripMenu,
            this.estoqueCadastrosToolStripMenu,
            this.fornecedoresCadastrosToolStripMenu,
            this.toolStripSeparator1,
            this.sairCadastrosToolStripMenu});
            this.cadastrosToolStripMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.cadastrosToolStripMenu.Name = "cadastrosToolStripMenu";
            this.cadastrosToolStripMenu.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenu.Text = "Cadastros";
            // 
            // clientesCadastrosToolStripMenu
            // 
            this.clientesCadastrosToolStripMenu.Name = "clientesCadastrosToolStripMenu";
            this.clientesCadastrosToolStripMenu.Size = new System.Drawing.Size(145, 22);
            this.clientesCadastrosToolStripMenu.Text = "Clientes";
            this.clientesCadastrosToolStripMenu.Click += new System.EventHandler(this.clientesCadastrosToolStripMenu_Click);
            // 
            // estoqueCadastrosToolStripMenu
            // 
            this.estoqueCadastrosToolStripMenu.Name = "estoqueCadastrosToolStripMenu";
            this.estoqueCadastrosToolStripMenu.Size = new System.Drawing.Size(145, 22);
            this.estoqueCadastrosToolStripMenu.Text = "Estoque";
            this.estoqueCadastrosToolStripMenu.Click += new System.EventHandler(this.estoqueCadastrosToolStripMenu_Click);
            // 
            // fornecedoresCadastrosToolStripMenu
            // 
            this.fornecedoresCadastrosToolStripMenu.Name = "fornecedoresCadastrosToolStripMenu";
            this.fornecedoresCadastrosToolStripMenu.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresCadastrosToolStripMenu.Text = "Fornecedores";
            this.fornecedoresCadastrosToolStripMenu.Click += new System.EventHandler(this.fornecedoresCadastrosToolStripMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // sairCadastrosToolStripMenu
            // 
            this.sairCadastrosToolStripMenu.Name = "sairCadastrosToolStripMenu";
            this.sairCadastrosToolStripMenu.Size = new System.Drawing.Size(145, 22);
            this.sairCadastrosToolStripMenu.Text = "Sair";
            this.sairCadastrosToolStripMenu.Click += new System.EventHandler(this.sairCadastrosToolStripMenu_Click);
            // 
            // sairToolStripMenu
            // 
            this.sairToolStripMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.sairToolStripMenu.Name = "sairToolStripMenu";
            this.sairToolStripMenu.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenu.Text = "Sair";
            this.sairToolStripMenu.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Menu.Properties.Resources.SGBr_junino24;
            this.pictureBox1.Location = new System.Drawing.Point(1727, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 74);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = global::Menu.Properties.Resources.pessoa;
            this.btnClientes.Location = new System.Drawing.Point(12, 35);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(55, 55);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // FMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 129);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu | |";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem clientesCadastrosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem estoqueCadastrosToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresCadastrosToolStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairCadastrosToolStripMenu;
    }
}


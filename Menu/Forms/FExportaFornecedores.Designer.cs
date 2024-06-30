namespace Menu.Forms
{
    partial class FExportaFornecedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExportaFornecedores));
            this.checkedListFornecedores = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSelecionarTodosForn = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkedListFornecedores
            // 
            this.checkedListFornecedores.FormattingEnabled = true;
            this.checkedListFornecedores.Items.AddRange(new object[] {
            "Código",
            "Nome fantasia",
            "Razão social",
            "CPF",
            "RG",
            "CNPJ",
            "Celular",
            "Telefone",
            "País",
            "UF",
            "Cód. cidade",
            "Cidade",
            "Bairro",
            "Endereço",
            "CEP",
            "Número",
            "Complemento",
            "IE",
            "IM",
            "SAC",
            "E-mail",
            "Site",
            "Forma de pagamento",
            "Nome contato jurídica",
            "Data hora cadastro",
            "Campo 1",
            "Campo 2",
            "Campo 3",
            "Campo 4",
            "Campo 5",
            "Campo 6",
            "Campo 7",
            "Campo 8",
            "Campo 9",
            "Campo 10",
            "Cód. cidade IBGE",
            "Ativo"});
            this.checkedListFornecedores.Location = new System.Drawing.Point(12, 44);
            this.checkedListFornecedores.Name = "checkedListFornecedores";
            this.checkedListFornecedores.Size = new System.Drawing.Size(208, 169);
            this.checkedListFornecedores.TabIndex = 0;
            // 
            // checkBoxSelecionarTodosForn
            // 
            this.checkBoxSelecionarTodosForn.AutoSize = true;
            this.checkBoxSelecionarTodosForn.Location = new System.Drawing.Point(12, 12);
            this.checkBoxSelecionarTodosForn.Name = "checkBoxSelecionarTodosForn";
            this.checkBoxSelecionarTodosForn.Size = new System.Drawing.Size(105, 17);
            this.checkBoxSelecionarTodosForn.TabIndex = 1;
            this.checkBoxSelecionarTodosForn.Text = "Selecionar todos";
            this.checkBoxSelecionarTodosForn.UseVisualStyleBackColor = true;
            this.checkBoxSelecionarTodosForn.CheckedChanged += new System.EventHandler(this.checkBoxSelecionarTodosForn_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Blue;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirmar.Image = global::Menu.Properties.Resources.confirmar;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.Location = new System.Drawing.Point(138, 276);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(82, 28);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Items.AddRange(new object[] {
            "Todos",
            "Ativos",
            "Inativos"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(12, 233);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(208, 21);
            this.comboBoxFiltro.TabIndex = 4;
            // 
            // FExportaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 316);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.checkBoxSelecionarTodosForn);
            this.Controls.Add(this.checkedListFornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FExportaFornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de colunas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListFornecedores;
        private System.Windows.Forms.CheckBox checkBoxSelecionarTodosForn;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
    }
}
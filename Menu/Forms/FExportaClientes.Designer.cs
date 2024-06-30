namespace Menu.Forms
{
    partial class FExportaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExportaClientes));
            this.checkedListClientes = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSelecionarTodosClientes = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkedListClientes
            // 
            this.checkedListClientes.FormattingEnabled = true;
            this.checkedListClientes.Items.AddRange(new object[] {
            "Código",
            "Cliente",
            "Fantasia",
            "CPF",
            "CNPJ",
            "Telefone",
            "Celular",
            "País",
            "UF",
            "Cidade",
            "Bairro",
            "Endereço",
            "Número",
            "CEP",
            "Complemento",
            "E-mail",
            "E-mail2",
            "Nacionalidade",
            "Naturalidade",
            "Data nascimento",
            "Tipo de cliente",
            "RG",
            "IE",
            "Estado civil",
            "Sexo",
            "IM",
            "Data e hora cadastro",
            "Pai",
            "Mãe",
            "Nome cônjuge",
            "Nome contato jurídico",
            "Data última venda",
            "Limite de crédito",
            "Cód. convênio",
            "Convênio",
            "Profissão",
            "Empresa",
            "Fone trabalho",
            "Renda mensal",
            "Dias sem comprar",
            "Código cidade IBGE",
            "Status",
            "Cód. vendedor",
            "Vendedor",
            "Ativo",
            "Campo 1",
            "Campo 2",
            "Campo 3",
            "Campo 4",
            "Campo 5",
            "Campo 6",
            "Campo 7",
            "Campo 8",
            "Campo 9",
            "Campo 10"});
            this.checkedListClientes.Location = new System.Drawing.Point(12, 46);
            this.checkedListClientes.Name = "checkedListClientes";
            this.checkedListClientes.Size = new System.Drawing.Size(203, 169);
            this.checkedListClientes.TabIndex = 0;
            // 
            // checkBoxSelecionarTodosClientes
            // 
            this.checkBoxSelecionarTodosClientes.AutoSize = true;
            this.checkBoxSelecionarTodosClientes.Location = new System.Drawing.Point(12, 12);
            this.checkBoxSelecionarTodosClientes.Name = "checkBoxSelecionarTodosClientes";
            this.checkBoxSelecionarTodosClientes.Size = new System.Drawing.Size(105, 17);
            this.checkBoxSelecionarTodosClientes.TabIndex = 1;
            this.checkBoxSelecionarTodosClientes.Text = "Selecionar todos";
            this.checkBoxSelecionarTodosClientes.UseVisualStyleBackColor = true;
            this.checkBoxSelecionarTodosClientes.CheckedChanged += new System.EventHandler(this.checkBoxSelecionarTodosClientes_CheckedChanged);
            // 
            // FExportaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 274);
            this.Controls.Add(this.checkBoxSelecionarTodosClientes);
            this.Controls.Add(this.checkedListClientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FExportaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleção de colunas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListClientes;
        private System.Windows.Forms.CheckBox checkBoxSelecionarTodosClientes;
    }
}
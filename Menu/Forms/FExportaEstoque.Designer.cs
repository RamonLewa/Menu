namespace Menu.Forms
{
    partial class FExportaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FExportaEstoque));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.checkBoxSelecionarTodosEstoque = new System.Windows.Forms.CheckBox();
            this.checkedListEstoque = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
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
            "Com quantidade positiva",
            "Zerados",
            "Negativos",
            "Ativos",
            "Inativos"});
            this.comboBoxFiltro.Location = new System.Drawing.Point(12, 232);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(208, 21);
            this.comboBoxFiltro.TabIndex = 4;
            // 
            // checkBoxSelecionarTodosEstoque
            // 
            this.checkBoxSelecionarTodosEstoque.AutoSize = true;
            this.checkBoxSelecionarTodosEstoque.Location = new System.Drawing.Point(12, 12);
            this.checkBoxSelecionarTodosEstoque.Name = "checkBoxSelecionarTodosEstoque";
            this.checkBoxSelecionarTodosEstoque.Size = new System.Drawing.Size(105, 17);
            this.checkBoxSelecionarTodosEstoque.TabIndex = 5;
            this.checkBoxSelecionarTodosEstoque.Text = "Selecionar todos";
            this.checkBoxSelecionarTodosEstoque.UseVisualStyleBackColor = true;
            this.checkBoxSelecionarTodosEstoque.CheckedChanged += new System.EventHandler(this.checkBoxSelecionarTodosEstoque_CheckedChanged);
            // 
            // checkedListEstoque
            // 
            this.checkedListEstoque.FormattingEnabled = true;
            this.checkedListEstoque.Items.AddRange(new object[] {
            "Código",
            "Produto",
            "Cód.barras",
            "Referência",
            "Unidade",
            "Preço de custo",
            "Perc. lucro",
            "Preço de venda",
            "Cód. grupo",
            "Grupo",
            "Cód. fornecedor",
            "Fornecedor",
            "Tamanho",
            "Peso",
            "Qtde total comprada",
            "Qtde total vendida",
            "Data última compra",
            "Data última venda",
            "Data e hora cadastro",
            "Qtde mínima",
            "Qtde máxima",
            "Qtde",
            "Ativo",
            "NCM",
            "Perc. crédito ICMS",
            "Usa grade",
            "Usa serial",
            "Origem",
            "Cód. tributação IPI",
            "Tributação IPI",
            "Cód. tributação PIS",
            "Tributação PIS",
            "Cód. tributação COFINS",
            "Tributação COFINS",
            "Tipo tributação",
            "Perc. ICMS interna",
            "Perc. MVA original",
            "Perc. ICMS Próprio S.T",
            "IAT",
            "IPPT",
            "CSOSN/CST",
            "Descrição CSOSN/CST",
            "Pesado",
            "Base de cálculo ICMS retido",
            "Valor ICMS retido",
            "Alíquota ICMS ECF",
            "Mensagem NFE",
            "Cód. mensagem NFE",
            "Cód. unidade de medida",
            "Cód. aplicação produto",
            "Aplicação produto",
            "Qtde inicial",
            "Alíquota ISS",
            "Cód. imposto médio",
            "Perc. imposto médio",
            "Cód. CST origem",
            "Cód. emitente",
            "Validade produto",
            "Fator conversão",
            "Tributação serviço",
            "Redução base de cálculo serviço",
            "Status",
            "Descrição complementar",
            "Preço de venda USS",
            "Perc. máximo desconto",
            "Valor comissão fixo",
            "Perc. comissão",
            "Preço mínimo USS",
            "Preço mínimo",
            "Cód. compra",
            "Valor conversão",
            "Valor frete",
            "Valor outros",
            "Valor ICMS ST",
            "Valor IPI",
            "Valor unitário compra",
            "Perc. PIS",
            "Perc. COFINS",
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
            "Marca",
            "Perc. redução de B.C",
            "Perc. redução de B.C S.T",
            "Cód. subgrupo",
            "Subgrupo",
            "Controlar validade",
            "Cód. marca",
            "Preço revenda",
            "Perc. IPI",
            "CFOP",
            "UN conversão venda",
            "Valor conversão venda",
            "Cód. tabela preço",
            "Tabela preço",
            "Perc. imposto estadual",
            "Perc. imposto municipal",
            "Cód. enquadramento IPI",
            "CEST",
            "Qtde em produção",
            "Qtde pedido de venda",
            "Qtde pedido de compra",
            "Qtde reservada",
            "Qtde real",
            "Qtde em produção MP",
            "Unidade medida etiqueta",
            "Fator conversão etiqueta",
            "Cód. ANP",
            "Descrição ANP",
            "Perc. GLP",
            "Perc. GNN",
            "Perc. GNI",
            "Valor partida",
            "Selo IPI",
            "Alíquota FCP",
            "% FCP",
            "CNPJ fabricante",
            "Cód. benefício fiscal",
            "Cód. ANVISA",
            "Cód. UN trib.",
            "UN trib",
            "Qtde trib.",
            "Desmontar na Venda",
            "Alíquota ICMS ST retido",
            "Valor BC ICMS ST retido",
            "Alíquota ICMS efetivo",
            "% ICMS efetivo",
            "Valor BC ICMS efetivo",
            "Valor ICMS efetivo",
            "Valor BC ICMS Substituto",
            "Valor ICMS ST retido",
            "Cód. barras caixa",
            "Valor PMC",
            "Enviar Dados",
            "Valor FCP ST",
            "Localização",
            "Cód. barras interno",
            "Cód. barras tributável",
            "Vacina",
            "% Desconto caixa",
            "Perc. cashback",
            "Tipo barra"});
            this.checkedListEstoque.Location = new System.Drawing.Point(12, 45);
            this.checkedListEstoque.Name = "checkedListEstoque";
            this.checkedListEstoque.Size = new System.Drawing.Size(208, 169);
            this.checkedListEstoque.TabIndex = 6;
            // 
            // FExportaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 316);
            this.Controls.Add(this.checkedListEstoque);
            this.Controls.Add(this.checkBoxSelecionarTodosEstoque);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FExportaEstoque";
            this.Text = "Seleção de colunas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.CheckBox checkBoxSelecionarTodosEstoque;
        private System.Windows.Forms.CheckedListBox checkedListEstoque;
    }
}
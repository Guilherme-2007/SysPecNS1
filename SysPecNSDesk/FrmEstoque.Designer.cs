namespace SysPecNSDesk
{
    partial class FrmEstoque
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
            label1 = new Label();
            dgvProdutos = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnCodigodebarras = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnitario = new DataGridViewTextBoxColumn();
            clnUnidadedevenda = new DataGridViewTextBoxColumn();
            clnCategoria = new DataGridViewTextBoxColumn();
            clnEstoqueMinimo = new DataGridViewTextBoxColumn();
            clnDesconto = new DataGridViewTextBoxColumn();
            clnDatadecadastro = new DataGridViewTextBoxColumn();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            txtUnidadeVenda = new TextBox();
            label7 = new Label();
            txtEstoqueMin = new TextBox();
            txtDisponivelEstoque = new TextBox();
            txtEntradaEstoque = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            btnInsere = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(193, 31);
            label1.Name = "label1";
            label1.Size = new Size(331, 33);
            label1.TabIndex = 1;
            label1.Text = "Controle de Estoque";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigodebarras, clnDescricao, clnValorUnitario, clnUnidadedevenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnDatadecadastro });
            dgvProdutos.Location = new Point(35, 101);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(696, 200);
            dgvProdutos.TabIndex = 9;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
            dgvProdutos.DoubleClick += dgvProdutos_DoubleClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnCodigodebarras
            // 
            clnCodigodebarras.Frozen = true;
            clnCodigodebarras.HeaderText = "Código de Barras";
            clnCodigodebarras.Name = "clnCodigodebarras";
            clnCodigodebarras.ReadOnly = true;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            // 
            // clnValorUnitario
            // 
            clnValorUnitario.Frozen = true;
            clnValorUnitario.HeaderText = "Valor Unitário";
            clnValorUnitario.Name = "clnValorUnitario";
            clnValorUnitario.ReadOnly = true;
            // 
            // clnUnidadedevenda
            // 
            clnUnidadedevenda.Frozen = true;
            clnUnidadedevenda.HeaderText = "Unidade de Venda";
            clnUnidadedevenda.Name = "clnUnidadedevenda";
            clnUnidadedevenda.ReadOnly = true;
            // 
            // clnCategoria
            // 
            clnCategoria.Frozen = true;
            clnCategoria.HeaderText = "Categoria";
            clnCategoria.Name = "clnCategoria";
            clnCategoria.ReadOnly = true;
            // 
            // clnEstoqueMinimo
            // 
            clnEstoqueMinimo.Frozen = true;
            clnEstoqueMinimo.HeaderText = "Estoque Minímo";
            clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            clnEstoqueMinimo.ReadOnly = true;
            // 
            // clnDesconto
            // 
            clnDesconto.Frozen = true;
            clnDesconto.HeaderText = "Desconto";
            clnDesconto.Name = "clnDesconto";
            clnDesconto.ReadOnly = true;
            // 
            // clnDatadecadastro
            // 
            clnDatadecadastro.Frozen = true;
            clnDatadecadastro.HeaderText = "Data de Cadastro";
            clnDatadecadastro.Name = "clnDatadecadastro";
            clnDatadecadastro.ReadOnly = true;
            // 
            // txtId
            // 
            txtId.Location = new Point(39, 55);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(53, 23);
            txtId.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 35);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 11;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 106);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 12;
            label3.Text = "Codigo de Barras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 106);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 13;
            label4.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(406, 106);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 14;
            label5.Text = "Unidade de Venda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 170);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 15;
            label6.Text = "Estoque Minimo";
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(39, 124);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.ReadOnly = true;
            txtCodBar.Size = new Size(127, 23);
            txtCodBar.TabIndex = 16;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(197, 124);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ReadOnly = true;
            txtDescricao.Size = new Size(184, 23);
            txtDescricao.TabIndex = 17;
            // 
            // txtUnidadeVenda
            // 
            txtUnidadeVenda.Location = new Point(406, 124);
            txtUnidadeVenda.Name = "txtUnidadeVenda";
            txtUnidadeVenda.ReadOnly = true;
            txtUnidadeVenda.Size = new Size(120, 23);
            txtUnidadeVenda.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(197, 170);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 19;
            label7.Text = "Disponivel em Estoque";
            // 
            // txtEstoqueMin
            // 
            txtEstoqueMin.Location = new Point(39, 188);
            txtEstoqueMin.Name = "txtEstoqueMin";
            txtEstoqueMin.ReadOnly = true;
            txtEstoqueMin.Size = new Size(127, 23);
            txtEstoqueMin.TabIndex = 20;
            // 
            // txtDisponivelEstoque
            // 
            txtDisponivelEstoque.Location = new Point(197, 188);
            txtDisponivelEstoque.Name = "txtDisponivelEstoque";
            txtDisponivelEstoque.ReadOnly = true;
            txtDisponivelEstoque.Size = new Size(127, 23);
            txtDisponivelEstoque.TabIndex = 21;
            // 
            // txtEntradaEstoque
            // 
            txtEntradaEstoque.Location = new Point(361, 188);
            txtEntradaEstoque.Name = "txtEntradaEstoque";
            txtEntradaEstoque.Size = new Size(100, 23);
            txtEntradaEstoque.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 170);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 23;
            label8.Text = "Entrada";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnInsere);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEntradaEstoque);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDisponivelEstoque);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtEstoqueMin);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtUnidadeVenda);
            groupBox1.Controls.Add(txtCodBar);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Location = new Point(35, 349);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(670, 271);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnInsere
            // 
            btnInsere.Location = new Point(517, 187);
            btnInsere.Name = "btnInsere";
            btnInsere.Size = new Size(117, 55);
            btnInsere.TabIndex = 24;
            btnInsere.Text = "Inserir";
            btnInsere.UseVisualStyleBackColor = true;
            btnInsere.Click += btnInsere_Click;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 649);
            Controls.Add(groupBox1);
            Controls.Add(dgvProdutos);
            Controls.Add(label1);
            Name = "FrmEstoque";
            Tag = "";
            Text = "Estoque";
            Load += FrmEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigodebarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnitario;
        private DataGridViewTextBoxColumn clnUnidadedevenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDatadecadastro;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private TextBox txtUnidadeVenda;
        private Label label7;
        private TextBox txtEstoqueMin;
        private TextBox txtDisponivelEstoque;
        private TextBox txtEntradaEstoque;
        private Label label8;
        private GroupBox groupBox1;
        private Button btnInsere;
    }
}
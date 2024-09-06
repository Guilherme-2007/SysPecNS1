namespace SysPecNSDesk
{
    partial class FrmProduto
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
            groupBox1 = new GroupBox();
            npEstoqueMinimo = new NumericUpDown();
            btnConsultar = new Button();
            btnEditar = new Button();
            btnAdicionar = new Button();
            cmbCategoria = new ComboBox();
            txtDesconto = new TextBox();
            txtDescricao = new TextBox();
            txtUnidadedeVenda = new TextBox();
            txtValorUnitario = new TextBox();
            txtCodigodebarras = new TextBox();
            txtId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 73);
            label1.Name = "label1";
            label1.Size = new Size(196, 40);
            label1.TabIndex = 0;
            label1.Text = "PRODUTOS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(npEstoqueMinimo);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(txtDesconto);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtUnidadedeVenda);
            groupBox1.Controls.Add(txtValorUnitario);
            groupBox1.Controls.Add(txtCodigodebarras);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(43, 145);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(696, 270);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produtos";
            // 
            // npEstoqueMinimo
            // 
            npEstoqueMinimo.Location = new Point(510, 94);
            npEstoqueMinimo.Name = "npEstoqueMinimo";
            npEstoqueMinimo.Size = new Size(57, 23);
            npEstoqueMinimo.TabIndex = 3;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(407, 199);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 7;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Enabled = false;
            btnEditar.Location = new Point(303, 199);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(199, 199);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 8;
            btnAdicionar.Text = "&Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(234, 146);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(428, 23);
            cmbCategoria.TabIndex = 5;
            cmbCategoria.SelectedIndexChanged += cmbCategoria_SelectedIndexChanged;
            // 
            // txtDesconto
            // 
            txtDesconto.Location = new Point(66, 199);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(100, 23);
            txtDesconto.TabIndex = 6;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(66, 146);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(162, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtUnidadedeVenda
            // 
            txtUnidadedeVenda.ForeColor = SystemColors.ScrollBar;
            txtUnidadedeVenda.Location = new Point(354, 94);
            txtUnidadedeVenda.Name = "txtUnidadedeVenda";
            txtUnidadedeVenda.Size = new Size(118, 23);
            txtUnidadedeVenda.TabIndex = 2;
            txtUnidadedeVenda.Text = "Ex: Caixa";
            // 
            // txtValorUnitario
            // 
            txtValorUnitario.Location = new Point(220, 94);
            txtValorUnitario.Name = "txtValorUnitario";
            txtValorUnitario.Size = new Size(113, 23);
            txtValorUnitario.TabIndex = 1;
            // 
            // txtCodigodebarras
            // 
            txtCodigodebarras.Location = new Point(66, 94);
            txtCodigodebarras.Name = "txtCodigodebarras";
            txtCodigodebarras.Size = new Size(133, 23);
            txtCodigodebarras.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Location = new Point(66, 50);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(41, 23);
            txtId.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 181);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 7;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(234, 128);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 6;
            label8.Text = "Categoria";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 128);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 5;
            label7.Text = "Descrição";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(510, 76);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 4;
            label6.Text = "Estoque Mínimo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 76);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 3;
            label5.Text = "Unidade de Venda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(221, 76);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 2;
            label4.Text = "Valor Unitário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 76);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 1;
            label3.Text = "Código de barras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 33);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // dgvProdutos
            // 
            dgvProdutos.AllowUserToAddRows = false;
            dgvProdutos.AllowUserToDeleteRows = false;
            dgvProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { clnId, clnCodigodebarras, clnDescricao, clnValorUnitario, clnUnidadedevenda, clnCategoria, clnEstoqueMinimo, clnDesconto, clnDatadecadastro });
            dgvProdutos.Location = new Point(43, 438);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.RowHeadersVisible = false;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(696, 200);
            dgvProdutos.TabIndex = 2;
            dgvProdutos.CellContentClick += dgvProdutos_CellContentClick;
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
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 656);
            Controls.Add(dgvProdutos);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmProduto";
            Text = "FrmProduto";
            Load += FrmProduto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)npEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvProdutos;
        private Button btnConsultar;
        private Button btnEditar;
        private Button btnAdicionar;
        private ComboBox cmbCategoria;
        private TextBox txtDesconto;
        private TextBox txtDescricao;
        private TextBox txtUnidadedeVenda;
        private TextBox txtValorUnitario;
        private TextBox txtCodigodebarras;
        private TextBox txtId;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnCodigodebarras;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnitario;
        private DataGridViewTextBoxColumn clnUnidadedevenda;
        private DataGridViewTextBoxColumn clnCategoria;
        private DataGridViewTextBoxColumn clnEstoqueMinimo;
        private DataGridViewTextBoxColumn clnDesconto;
        private DataGridViewTextBoxColumn clnDatadecadastro;
        private NumericUpDown npEstoqueMinimo;
    }
}
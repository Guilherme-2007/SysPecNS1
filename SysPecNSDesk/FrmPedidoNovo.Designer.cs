namespace SysPecNSDesk
{
    partial class FrmPedidoNovo
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
            grbIdentificacao = new GroupBox();
            btnCliente = new Button();
            btnInserePedido = new Button();
            txtIdCliente = new TextBox();
            txtCliente = new TextBox();
            txtUsuario = new TextBox();
            label3 = new Label();
            grbItens = new GroupBox();
            label15 = new Label();
            label10 = new Label();
            txtTotal = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnAddItem = new Button();
            txtDescontoItem = new TextBox();
            txtQuantidade = new TextBox();
            txtValorUnit = new TextBox();
            txtCodBar = new TextBox();
            txtDescricao = new TextBox();
            dgvItensPedido = new DataGridView();
            clnSeq = new DataGridViewTextBoxColumn();
            clnCodBar = new DataGridViewTextBoxColumn();
            clnDescricao = new DataGridViewTextBoxColumn();
            clnValorUnit = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnDescontoItem = new DataGridViewTextBoxColumn();
            clnTotalItem = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtIdPedido = new TextBox();
            txtTotal1 = new TextBox();
            txtDescontoPedido = new TextBox();
            txtDescontoItens = new TextBox();
            btnFechar = new Button();
            txtSubTotal = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            grbIdentificacao.SuspendLayout();
            grbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).BeginInit();
            SuspendLayout();
            // 
            // grbIdentificacao
            // 
            grbIdentificacao.Controls.Add(btnCliente);
            grbIdentificacao.Controls.Add(btnInserePedido);
            grbIdentificacao.Controls.Add(txtIdCliente);
            grbIdentificacao.Controls.Add(txtCliente);
            grbIdentificacao.Controls.Add(txtUsuario);
            grbIdentificacao.Controls.Add(label3);
            grbIdentificacao.Location = new Point(75, 74);
            grbIdentificacao.Name = "grbIdentificacao";
            grbIdentificacao.Size = new Size(534, 140);
            grbIdentificacao.TabIndex = 0;
            grbIdentificacao.TabStop = false;
            grbIdentificacao.Text = "Identificação";
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.Control;
            btnCliente.FlatAppearance.BorderSize = 0;
            btnCliente.FlatStyle = FlatStyle.Flat;
            btnCliente.Location = new Point(6, 86);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(75, 23);
            btnCliente.TabIndex = 3;
            btnCliente.Text = "Cliente";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // btnInserePedido
            // 
            btnInserePedido.Location = new Point(443, 53);
            btnInserePedido.Name = "btnInserePedido";
            btnInserePedido.Size = new Size(75, 52);
            btnInserePedido.TabIndex = 2;
            btnInserePedido.Text = "Abrir";
            btnInserePedido.UseVisualStyleBackColor = true;
            btnInserePedido.Click += btnInserePedido_Click;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdCliente.Location = new Point(84, 83);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(65, 27);
            txtIdCliente.TabIndex = 0;
            txtIdCliente.TextChanged += txtIdCliente_TextChanged;
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(155, 83);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(256, 27);
            txtCliente.TabIndex = 1;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(77, 34);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(334, 27);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 37);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario";
            label3.Click += label3_Click;
            // 
            // grbItens
            // 
            grbItens.Controls.Add(label15);
            grbItens.Controls.Add(label10);
            grbItens.Controls.Add(txtTotal);
            grbItens.Controls.Add(label9);
            grbItens.Controls.Add(label8);
            grbItens.Controls.Add(label7);
            grbItens.Controls.Add(label6);
            grbItens.Controls.Add(label5);
            grbItens.Controls.Add(btnAddItem);
            grbItens.Controls.Add(txtDescontoItem);
            grbItens.Controls.Add(txtQuantidade);
            grbItens.Controls.Add(txtValorUnit);
            grbItens.Controls.Add(txtCodBar);
            grbItens.Controls.Add(txtDescricao);
            grbItens.Controls.Add(dgvItensPedido);
            grbItens.Enabled = false;
            grbItens.Location = new Point(75, 251);
            grbItens.Name = "grbItens";
            grbItens.Size = new Size(640, 299);
            grbItens.TabIndex = 1;
            grbItens.TabStop = false;
            grbItens.Text = "Itens do Pedido";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.Red;
            label15.Location = new Point(560, 81);
            label15.Name = "label15";
            label15.Size = new Size(20, 15);
            label15.TabIndex = 13;
            label15.Text = "R$";
            label15.Click += label15_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(428, 264);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 12;
            label10.Text = "Total R$";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.ForeColor = Color.Navy;
            txtTotal.Location = new Point(515, 260);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 33);
            txtTotal.TabIndex = 11;
            txtTotal.TextChanged += txtTotal_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(477, 40);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 10;
            label9.Text = "Desconto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(383, 39);
            label8.Name = "label8";
            label8.Size = new Size(69, 15);
            label8.TabIndex = 9;
            label8.Text = "Quantidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(304, 40);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 8;
            label7.Text = "Valor Unit";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 39);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 7;
            label6.Text = "Descrição";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 39);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 5;
            label5.Text = "Codigo de Barras";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(560, 57);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 5;
            btnAddItem.Text = "A&dicionar";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // txtDescontoItem
            // 
            txtDescontoItem.Location = new Point(466, 58);
            txtDescontoItem.Name = "txtDescontoItem";
            txtDescontoItem.RightToLeft = RightToLeft.Yes;
            txtDescontoItem.Size = new Size(84, 23);
            txtDescontoItem.TabIndex = 4;
            txtDescontoItem.Text = "0";
            txtDescontoItem.TextChanged += txtDescontoItem_TextChanged;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(400, 57);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.RightToLeft = RightToLeft.Yes;
            txtQuantidade.Size = new Size(31, 23);
            txtQuantidade.TabIndex = 3;
            txtQuantidade.Text = "1";
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(304, 58);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(65, 23);
            txtValorUnit.TabIndex = 2;
            // 
            // txtCodBar
            // 
            txtCodBar.Location = new Point(14, 57);
            txtCodBar.Name = "txtCodBar";
            txtCodBar.Size = new Size(83, 23);
            txtCodBar.TabIndex = 0;
            txtCodBar.Leave += txtCodBar_Leave;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(103, 57);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(186, 23);
            txtDescricao.TabIndex = 1;
            // 
            // dgvItensPedido
            // 
            dgvItensPedido.AllowUserToAddRows = false;
            dgvItensPedido.AllowUserToDeleteRows = false;
            dgvItensPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensPedido.Columns.AddRange(new DataGridViewColumn[] { clnSeq, clnCodBar, clnDescricao, clnValorUnit, clnQuantidade, clnDescontoItem, clnTotalItem });
            dgvItensPedido.Location = new Point(14, 99);
            dgvItensPedido.Name = "dgvItensPedido";
            dgvItensPedido.ReadOnly = true;
            dgvItensPedido.RowHeadersVisible = false;
            dgvItensPedido.Size = new Size(620, 150);
            dgvItensPedido.TabIndex = 0;
            // 
            // clnSeq
            // 
            clnSeq.Frozen = true;
            clnSeq.HeaderText = "#SEQ";
            clnSeq.Name = "clnSeq";
            clnSeq.ReadOnly = true;
            clnSeq.Width = 40;
            // 
            // clnCodBar
            // 
            clnCodBar.Frozen = true;
            clnCodBar.HeaderText = "Cod. Barras";
            clnCodBar.Name = "clnCodBar";
            clnCodBar.ReadOnly = true;
            clnCodBar.Width = 90;
            // 
            // clnDescricao
            // 
            clnDescricao.Frozen = true;
            clnDescricao.HeaderText = "Descrição";
            clnDescricao.Name = "clnDescricao";
            clnDescricao.ReadOnly = true;
            clnDescricao.Width = 170;
            // 
            // clnValorUnit
            // 
            clnValorUnit.Frozen = true;
            clnValorUnit.HeaderText = "Valor Unit";
            clnValorUnit.Name = "clnValorUnit";
            clnValorUnit.ReadOnly = true;
            clnValorUnit.Width = 90;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 70;
            // 
            // clnDescontoItem
            // 
            clnDescontoItem.Frozen = true;
            clnDescontoItem.HeaderText = "Desconto";
            clnDescontoItem.Name = "clnDescontoItem";
            clnDescontoItem.ReadOnly = true;
            clnDescontoItem.Width = 70;
            // 
            // clnTotalItem
            // 
            clnTotalItem.Frozen = true;
            clnTotalItem.HeaderText = "Total";
            clnTotalItem.Name = "clnTotalItem";
            clnTotalItem.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(196, 11);
            label1.Name = "label1";
            label1.Size = new Size(182, 30);
            label1.TabIndex = 2;
            label1.Text = "Novo Pedido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(881, 114);
            label2.Name = "label2";
            label2.Size = new Size(106, 27);
            label2.TabIndex = 3;
            label2.Text = "Número";
            // 
            // txtIdPedido
            // 
            txtIdPedido.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdPedido.ForeColor = Color.Red;
            txtIdPedido.Location = new Point(869, 144);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(118, 35);
            txtIdPedido.TabIndex = 4;
            // 
            // txtTotal1
            // 
            txtTotal1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal1.Location = new Point(881, 416);
            txtTotal1.Name = "txtTotal1";
            txtTotal1.ReadOnly = true;
            txtTotal1.Size = new Size(100, 29);
            txtTotal1.TabIndex = 7;
            txtTotal1.TextChanged += textBox4_TextChanged;
            // 
            // txtDescontoPedido
            // 
            txtDescontoPedido.Location = new Point(764, 416);
            txtDescontoPedido.Name = "txtDescontoPedido";
            txtDescontoPedido.Size = new Size(100, 23);
            txtDescontoPedido.TabIndex = 8;
            txtDescontoPedido.TextChanged += txtDescontoPedido_TextChanged;
            // 
            // txtDescontoItens
            // 
            txtDescontoItens.Location = new Point(881, 370);
            txtDescontoItens.Name = "txtDescontoItens";
            txtDescontoItens.ReadOnly = true;
            txtDescontoItens.Size = new Size(100, 23);
            txtDescontoItens.TabIndex = 8;
            txtDescontoItens.TextChanged += txtDescontoItens_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(837, 463);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "&Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(764, 370);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(100, 23);
            txtSubTotal.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(789, 348);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 9;
            label11.Text = "SubTotal";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(886, 350);
            label12.Name = "label12";
            label12.Size = new Size(85, 15);
            label12.TabIndex = 10;
            label12.Text = "Desconto Itens";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(789, 398);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 11;
            label13.Text = "Desconto";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(906, 398);
            label14.Name = "label14";
            label14.Size = new Size(32, 15);
            label14.TabIndex = 12;
            label14.Text = "Total";
            // 
            // FrmPedidoNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 562);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtSubTotal);
            Controls.Add(txtDescontoItens);
            Controls.Add(txtDescontoPedido);
            Controls.Add(txtTotal1);
            Controls.Add(txtIdPedido);
            Controls.Add(label2);
            Controls.Add(btnFechar);
            Controls.Add(label1);
            Controls.Add(grbItens);
            Controls.Add(grbIdentificacao);
            Name = "FrmPedidoNovo";
            Text = "FrmPedidoNovo";
            Load += FrmPedidoNovo_Load;
            grbIdentificacao.ResumeLayout(false);
            grbIdentificacao.PerformLayout();
            grbItens.ResumeLayout(false);
            grbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbIdentificacao;
        private GroupBox grbItens;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox txtIdPedido;
        private TextBox txtUsuario;
        private TextBox txtCliente;
        private TextBox txtIdCliente;
        private Button btnInserePedido;
        private Button btnAddItem;
        private DataGridView dgvItensPedido;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtDescontoItem;
        private TextBox txtQuantidade;
        private TextBox txtValorUnit;
        private TextBox txtCodBar;
        private TextBox txtDescricao;
        private Label label10;
        private TextBox txtTotal;
        private TextBox txtTotal1;
        private TextBox txtDescontoPedido;
        private TextBox txtDescontoItens;
        private Button btnFechar;
        private TextBox txtSubTotal;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn clnSeq;
        private DataGridViewTextBoxColumn clnCodBar;
        private DataGridViewTextBoxColumn clnDescricao;
        private DataGridViewTextBoxColumn clnValorUnit;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnDescontoItem;
        private DataGridViewTextBoxColumn clnTotalItem;
        private Label label15;
        private Button btnCliente;
    }
}
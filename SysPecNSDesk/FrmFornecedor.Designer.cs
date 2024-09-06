namespace SysPecNSDesk
{
    partial class FrmFornecedor
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            txtRazaoSocial = new TextBox();
            txtFantasia = new TextBox();
            txtCnpj = new TextBox();
            txtTelefone = new TextBox();
            txtContato = new TextBox();
            txtEmail = new TextBox();
            btnInserir = new Button();
            btnEditar = new Button();
            btnConsultar = new Button();
            dgvFornecedor = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnRazaoSocial = new DataGridViewTextBoxColumn();
            clnFantasia = new DataGridViewTextBoxColumn();
            clnCNPJ = new DataGridViewTextBoxColumn();
            clnContato = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 73);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 130);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Razão Social";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 130);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Fantasia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 130);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "CNPJ";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(275, 187);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 4;
            label5.Text = "Contato";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(111, 187);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(111, 241);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // txtId
            // 
            txtId.Location = new Point(111, 91);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(39, 23);
            txtId.TabIndex = 7;
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(111, 148);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(157, 23);
            txtRazaoSocial.TabIndex = 8;
            // 
            // txtFantasia
            // 
            txtFantasia.Location = new Point(275, 148);
            txtFantasia.Name = "txtFantasia";
            txtFantasia.Size = new Size(140, 23);
            txtFantasia.TabIndex = 9;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(421, 148);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(205, 23);
            txtCnpj.TabIndex = 10;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(111, 205);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(157, 23);
            txtTelefone.TabIndex = 11;
            // 
            // txtContato
            // 
            txtContato.Location = new Point(275, 205);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(140, 23);
            txtContato.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(111, 259);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(304, 23);
            txtEmail.TabIndex = 13;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(452, 258);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(75, 23);
            btnInserir.TabIndex = 14;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(561, 259);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "&Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(672, 258);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "&Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvFornecedor
            // 
            dgvFornecedor.AllowUserToAddRows = false;
            dgvFornecedor.AllowUserToDeleteRows = false;
            dgvFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFornecedor.Columns.AddRange(new DataGridViewColumn[] { clnId, clnRazaoSocial, clnFantasia, clnCNPJ, clnContato, clnTelefone, clnEmail });
            dgvFornecedor.Location = new Point(59, 328);
            dgvFornecedor.Name = "dgvFornecedor";
            dgvFornecedor.ReadOnly = true;
            dgvFornecedor.RowHeadersVisible = false;
            dgvFornecedor.Size = new Size(701, 185);
            dgvFornecedor.TabIndex = 17;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            // 
            // clnRazaoSocial
            // 
            clnRazaoSocial.Frozen = true;
            clnRazaoSocial.HeaderText = "Razão Social";
            clnRazaoSocial.Name = "clnRazaoSocial";
            clnRazaoSocial.ReadOnly = true;
            // 
            // clnFantasia
            // 
            clnFantasia.Frozen = true;
            clnFantasia.HeaderText = "Fantasia";
            clnFantasia.Name = "clnFantasia";
            clnFantasia.ReadOnly = true;
            // 
            // clnCNPJ
            // 
            clnCNPJ.Frozen = true;
            clnCNPJ.HeaderText = "CNPJ";
            clnCNPJ.Name = "clnCNPJ";
            clnCNPJ.ReadOnly = true;
            // 
            // clnContato
            // 
            clnContato.Frozen = true;
            clnContato.HeaderText = "Contato";
            clnContato.Name = "clnContato";
            clnContato.ReadOnly = true;
            // 
            // clnTelefone
            // 
            clnTelefone.Frozen = true;
            clnTelefone.HeaderText = "Telefone";
            clnTelefone.Name = "clnTelefone";
            clnTelefone.ReadOnly = true;
            // 
            // clnEmail
            // 
            clnEmail.Frozen = true;
            clnEmail.HeaderText = "Email";
            clnEmail.Name = "clnEmail";
            clnEmail.ReadOnly = true;
            // 
            // FrmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 599);
            Controls.Add(dgvFornecedor);
            Controls.Add(btnConsultar);
            Controls.Add(btnEditar);
            Controls.Add(btnInserir);
            Controls.Add(txtEmail);
            Controls.Add(txtContato);
            Controls.Add(txtTelefone);
            Controls.Add(txtCnpj);
            Controls.Add(txtFantasia);
            Controls.Add(txtRazaoSocial);
            Controls.Add(txtId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFornecedor";
            Text = "FrmFornecedor";
            Load += FrmFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtId;
        private TextBox txtRazaoSocial;
        private TextBox txtFantasia;
        private TextBox txtCnpj;
        private TextBox txtTelefone;
        private TextBox txtContato;
        private TextBox txtEmail;
        private Button btnInserir;
        private Button btnEditar;
        private Button btnConsultar;
        private DataGridView dgvFornecedor;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnRazaoSocial;
        private DataGridViewTextBoxColumn clnFantasia;
        private DataGridViewTextBoxColumn clnCNPJ;
        private DataGridViewTextBoxColumn clnContato;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
    }
}
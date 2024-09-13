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
            txtProduto = new TextBox();
            label1 = new Label();
            txtQuantidade = new TextBox();
            dtpInsercaoAtualizacao = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAtualizar = new Button();
            dgvEstoque = new DataGridView();
            clnProduto = new DataGridViewTextBoxColumn();
            clnQuantidade = new DataGridViewTextBoxColumn();
            clnData = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(88, 172);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(146, 23);
            txtProduto.TabIndex = 0;
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
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(240, 172);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(48, 23);
            txtQuantidade.TabIndex = 2;
            // 
            // dtpInsercaoAtualizacao
            // 
            dtpInsercaoAtualizacao.Location = new Point(88, 221);
            dtpInsercaoAtualizacao.Name = "dtpInsercaoAtualizacao";
            dtpInsercaoAtualizacao.Size = new Size(200, 23);
            dtpInsercaoAtualizacao.TabIndex = 3;
            dtpInsercaoAtualizacao.Value = new DateTime(2024, 9, 13, 10, 33, 2, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 154);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(250, 154);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "Qnt";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 203);
            label4.Name = "label4";
            label4.Size = new Size(149, 15);
            label4.TabIndex = 6;
            label4.Text = "Data de Inserção/Alteração";
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(133, 262);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(101, 38);
            btnAtualizar.TabIndex = 8;
            btnAtualizar.Text = "&Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { clnProduto, clnQuantidade, clnData });
            dgvEstoque.Location = new Point(370, 124);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.Size = new Size(403, 273);
            dgvEstoque.TabIndex = 9;
            // 
            // clnProduto
            // 
            clnProduto.Frozen = true;
            clnProduto.HeaderText = "Produto";
            clnProduto.Name = "clnProduto";
            clnProduto.ReadOnly = true;
            clnProduto.Width = 200;
            // 
            // clnQuantidade
            // 
            clnQuantidade.Frozen = true;
            clnQuantidade.HeaderText = "Quant";
            clnQuantidade.Name = "clnQuantidade";
            clnQuantidade.ReadOnly = true;
            clnQuantidade.Width = 50;
            // 
            // clnData
            // 
            clnData.Frozen = true;
            clnData.HeaderText = "Data";
            clnData.Name = "clnData";
            clnData.ReadOnly = true;
            clnData.Width = 150;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEstoque);
            Controls.Add(btnAtualizar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtpInsercaoAtualizacao);
            Controls.Add(txtQuantidade);
            Controls.Add(label1);
            Controls.Add(txtProduto);
            Name = "FrmEstoque";
            Tag = "";
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProduto;
        private Label label1;
        private TextBox txtQuantidade;
        private DateTimePicker dtpInsercaoAtualizacao;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAtualizar;
        private DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn clnProduto;
        private DataGridViewTextBoxColumn clnQuantidade;
        private DataGridViewTextBoxColumn clnData;
    }
}
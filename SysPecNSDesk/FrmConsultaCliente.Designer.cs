namespace SysPecNSDesk
{
    partial class FrmConsultaCliente
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tabConsultaCliente = new TabControl();
            tabPageBuscar = new TabPage();
            label7 = new Label();
            txtBusca = new TextBox();
            dgvClientes = new DataGridView();
            clnId = new DataGridViewTextBoxColumn();
            clnNome = new DataGridViewTextBoxColumn();
            clnCpf = new DataGridViewTextBoxColumn();
            clnTelefone = new DataGridViewTextBoxColumn();
            clnEmail = new DataGridViewTextBoxColumn();
            clnDataNasc = new DataGridViewTextBoxColumn();
            clnAtivo = new DataGridViewCheckBoxColumn();
            tabPageEditar = new TabPage();
            dgvEnderecos = new DataGridView();
            clnCEP = new DataGridViewTextBoxColumn();
            clnLogradouro = new DataGridViewTextBoxColumn();
            clnNumero = new DataGridViewTextBoxColumn();
            clnComplemento = new DataGridViewTextBoxColumn();
            clnBairro = new DataGridViewTextBoxColumn();
            clnCidade = new DataGridViewTextBoxColumn();
            clnUF = new DataGridViewTextBoxColumn();
            clnTipoEndereco = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            tabConsultaCliente.SuspendLayout();
            tabPageBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabConsultaCliente);
            groupBox1.Location = new Point(1, -19);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 428);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tabConsultaCliente
            // 
            tabConsultaCliente.Controls.Add(tabPageBuscar);
            tabConsultaCliente.Controls.Add(tabPageEditar);
            tabConsultaCliente.Location = new Point(6, 22);
            tabConsultaCliente.Name = "tabConsultaCliente";
            tabConsultaCliente.SelectedIndex = 0;
            tabConsultaCliente.Size = new Size(764, 398);
            tabConsultaCliente.TabIndex = 0;
            // 
            // tabPageBuscar
            // 
            tabPageBuscar.Controls.Add(label7);
            tabPageBuscar.Controls.Add(txtBusca);
            tabPageBuscar.Controls.Add(dgvClientes);
            tabPageBuscar.Location = new Point(4, 24);
            tabPageBuscar.Name = "tabPageBuscar";
            tabPageBuscar.Padding = new Padding(3);
            tabPageBuscar.Size = new Size(756, 370);
            tabPageBuscar.TabIndex = 0;
            tabPageBuscar.Text = "Buscar cliente";
            tabPageBuscar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 12);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 42;
            label7.Text = "Buscar Cliente";
            // 
            // txtBusca
            // 
            txtBusca.Location = new Point(45, 30);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(666, 23);
            txtBusca.TabIndex = 41;
            txtBusca.TextChanged += txtBusca_TextChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeColumns = false;
            dgvClientes.AllowUserToResizeRows = false;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { clnId, clnNome, clnCpf, clnTelefone, clnEmail, clnDataNasc, clnAtivo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Location = new Point(45, 59);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(666, 286);
            dgvClientes.TabIndex = 40;
            dgvClientes.CellContentDoubleClick += dgvClientes_CellContentDoubleClick;
            // 
            // clnId
            // 
            clnId.Frozen = true;
            clnId.HeaderText = "ID";
            clnId.Name = "clnId";
            clnId.ReadOnly = true;
            clnId.Width = 40;
            // 
            // clnNome
            // 
            clnNome.Frozen = true;
            clnNome.HeaderText = "Nome";
            clnNome.Name = "clnNome";
            clnNome.ReadOnly = true;
            clnNome.Width = 160;
            // 
            // clnCpf
            // 
            clnCpf.Frozen = true;
            clnCpf.HeaderText = "CPF";
            clnCpf.Name = "clnCpf";
            clnCpf.ReadOnly = true;
            clnCpf.Width = 110;
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
            clnEmail.Width = 120;
            // 
            // clnDataNasc
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            clnDataNasc.DefaultCellStyle = dataGridViewCellStyle1;
            clnDataNasc.Frozen = true;
            clnDataNasc.HeaderText = "Data de Nascimento";
            clnDataNasc.Name = "clnDataNasc";
            clnDataNasc.ReadOnly = true;
            clnDataNasc.Width = 90;
            // 
            // clnAtivo
            // 
            clnAtivo.Frozen = true;
            clnAtivo.HeaderText = "Ativo";
            clnAtivo.Name = "clnAtivo";
            clnAtivo.ReadOnly = true;
            clnAtivo.Width = 45;
            // 
            // tabPageEditar
            // 
            tabPageEditar.Location = new Point(4, 24);
            tabPageEditar.Name = "tabPageEditar";
            tabPageEditar.Padding = new Padding(3);
            tabPageEditar.Size = new Size(756, 370);
            tabPageEditar.TabIndex = 1;
            tabPageEditar.Text = "Editar cadastro";
            tabPageEditar.UseVisualStyleBackColor = true;
            // 
            // dgvEnderecos
            // 
            dgvEnderecos.AllowUserToAddRows = false;
            dgvEnderecos.AllowUserToDeleteRows = false;
            dgvEnderecos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEnderecos.Columns.AddRange(new DataGridViewColumn[] { clnCEP, clnLogradouro, clnNumero, clnComplemento, clnBairro, clnCidade, clnUF, clnTipoEndereco });
            dgvEnderecos.Location = new Point(56, 435);
            dgvEnderecos.Name = "dgvEnderecos";
            dgvEnderecos.ReadOnly = true;
            dgvEnderecos.RowHeadersVisible = false;
            dgvEnderecos.Size = new Size(693, 238);
            dgvEnderecos.TabIndex = 41;
            dgvEnderecos.SelectionChanged += dgvEnderecos_SelectionChanged;
            // 
            // clnCEP
            // 
            clnCEP.Frozen = true;
            clnCEP.HeaderText = "CEP";
            clnCEP.Name = "clnCEP";
            clnCEP.ReadOnly = true;
            clnCEP.Width = 80;
            // 
            // clnLogradouro
            // 
            clnLogradouro.Frozen = true;
            clnLogradouro.HeaderText = "Logradouro";
            clnLogradouro.Name = "clnLogradouro";
            clnLogradouro.ReadOnly = true;
            clnLogradouro.Width = 200;
            // 
            // clnNumero
            // 
            clnNumero.Frozen = true;
            clnNumero.HeaderText = "N°";
            clnNumero.Name = "clnNumero";
            clnNumero.ReadOnly = true;
            clnNumero.Width = 30;
            // 
            // clnComplemento
            // 
            clnComplemento.Frozen = true;
            clnComplemento.HeaderText = "Complemento";
            clnComplemento.Name = "clnComplemento";
            clnComplemento.ReadOnly = true;
            // 
            // clnBairro
            // 
            clnBairro.Frozen = true;
            clnBairro.HeaderText = "Bairro";
            clnBairro.Name = "clnBairro";
            clnBairro.ReadOnly = true;
            // 
            // clnCidade
            // 
            clnCidade.Frozen = true;
            clnCidade.HeaderText = "Cidade";
            clnCidade.Name = "clnCidade";
            clnCidade.ReadOnly = true;
            clnCidade.Width = 50;
            // 
            // clnUF
            // 
            clnUF.Frozen = true;
            clnUF.HeaderText = "UF";
            clnUF.Name = "clnUF";
            clnUF.ReadOnly = true;
            clnUF.Width = 30;
            // 
            // clnTipoEndereco
            // 
            clnTipoEndereco.Frozen = true;
            clnTipoEndereco.HeaderText = "Tipo Endereço";
            clnTipoEndereco.Name = "clnTipoEndereco";
            clnTipoEndereco.ReadOnly = true;
            // 
            // FrmConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 685);
            Controls.Add(dgvEnderecos);
            Controls.Add(groupBox1);
            Name = "FrmConsultaCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmConsultaCliente";
            Load += FrmConsultaCliente_Load;
            groupBox1.ResumeLayout(false);
            tabConsultaCliente.ResumeLayout(false);
            tabPageBuscar.ResumeLayout(false);
            tabPageBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEnderecos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private TabControl tabConsultaCliente;
        private TabPage tabPageBuscar;
        private TabPage tabPageEditar;
        private Label label7;
        private TextBox txtBusca;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn clnId;
        private DataGridViewTextBoxColumn clnNome;
        private DataGridViewTextBoxColumn clnCpf;
        private DataGridViewTextBoxColumn clnTelefone;
        private DataGridViewTextBoxColumn clnEmail;
        private DataGridViewTextBoxColumn clnDataNasc;
        private DataGridViewCheckBoxColumn clnAtivo;
        private DataGridView dgvEnderecos;
        private DataGridViewTextBoxColumn clnCEP;
        private DataGridViewTextBoxColumn clnLogradouro;
        private DataGridViewTextBoxColumn clnNumero;
        private DataGridViewTextBoxColumn clnComplemento;
        private DataGridViewTextBoxColumn clnBairro;
        private DataGridViewTextBoxColumn clnCidade;
        private DataGridViewTextBoxColumn clnUF;
        private DataGridViewTextBoxColumn clnTipoEndereco;
    }
}
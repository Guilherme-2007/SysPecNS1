using SysPecNSLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysPecNSDesk
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            //Cria um novo objeto usuário
            Fornecedor fornecedor = new(
                //int.Parse(txtId.Text),
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCnpj.Text,
                txtTelefone.Text,
                txtContato.Text,
                txtEmail.Text
                );
            //Insere as informações no banco
            fornecedor.Inserir();
            if (fornecedor.Id > 0)
            {
                //Exibe id gerado para o novo usuário, enquanto a caixa de diálogo não for fechada.
                txtId.Text = fornecedor.Id.ToString();
                MessageBox.Show($"O Fornecedor {fornecedor.Id} foi inserido com sucesso.");
                //Limpa as informações do formulário
                txtId.Clear();
                txtRazaoSocial.Clear();
                txtEmail.Clear();
                txtFantasia.Clear();
                txtCnpj.Clear();
                txtTelefone.Clear();
                txtContato.Clear();
                //Foca o cursor no campo Nome para a nova inserção
                txtId.Focus();
                FrmFornecedor_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Falha ao gravar o fornecedor.");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new(
                int.Parse(txtId.Text),
                txtRazaoSocial.Text,
                txtFantasia.Text,
                txtCnpj.Text,
                txtTelefone.Text,
                txtContato.Text,
                txtEmail.Text
                );
            fornecedor.Atualizar();
            MessageBox.Show($"Fornecedor {fornecedor.Id} atualizado com sucesso");
            FrmFornecedor_Load(sender, e);
        }

        private void CarregaGrid(string nome = "")
        {

            //Preenchendo o datagrid com os usuarios
            var lista = Fornecedor.ObterLista(nome);

            //Limpar as linhas da tabela
            dgvFornecedor.Rows.Clear();
            int cont = 0;
            foreach (var fornecedor in lista)
            {
                //Carrega informações de cada campo nas linhas da tabela
                dgvFornecedor.Rows.Add();
                dgvFornecedor.Rows[cont].Cells[0].Value = fornecedor.Id;
                dgvFornecedor.Rows[cont].Cells[1].Value = fornecedor.RazaoSocial;
                dgvFornecedor.Rows[cont].Cells[2].Value = fornecedor.Fantasia;
                dgvFornecedor.Rows[cont].Cells[3].Value = fornecedor.CNPJ;
                dgvFornecedor.Rows[cont].Cells[4].Value = fornecedor.Telefone;
                dgvFornecedor.Rows[cont].Cells[5].Value = fornecedor.Contato;
                dgvFornecedor.Rows[cont].Cells[6].Value = fornecedor.Email;

                cont++;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (btnConsultar.Text == "&Consultar")
            {
                txtRazaoSocial.Clear();
                txtFantasia.Clear();
                txtCnpj.Clear();
                txtTelefone.Clear();
                txtContato.Clear();
                txtEmail.Clear();
                btnConsultar.Text = "&Obter por ID";
                txtId.Focus();
                txtId.ReadOnly = false;
            }
            else
            {
                if (txtId.Text.Length > 0)
                {
                    Fornecedor fornecedor = Fornecedor.ObterPorId(int.Parse(txtId.Text));
                    txtRazaoSocial.Text = fornecedor.RazaoSocial;
                    txtFantasia.Text = fornecedor.Fantasia;
                    txtCnpj.Text = fornecedor.CNPJ;
                    txtTelefone.Text = fornecedor.Telefone;
                    txtContato.Text = fornecedor.Contato;
                    txtEmail.Text = fornecedor.Email;
                    btnEditar.Enabled = true;
                }
            }
        }
    }
}

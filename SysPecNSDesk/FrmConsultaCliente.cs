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
    public partial class FrmConsultaCliente : Form
    {
        public FrmConsultaCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultaCliente_Load(object sender, EventArgs e)
        {
            
            CarregaGrid();
            CarregaGrid1();
        }

        private void CarregaGrid(string nome = "")
        {
            //Obtem lista de clientes
            var lista = Cliente.ObterLista(nome);

            //Limpa as linhas da tabela antes de consultar as informações de cada campo
            dgvClientes.Rows.Clear();
            //contador para alterar o índice a cada cliente da lista
            int cont = 0;
            foreach (var cliente in lista)
            {
                //Adiciona uma nova linha a tabela
                dgvClientes.Rows.Add();

                //Preenche a linha com as colunas e seus respectivos dados
                dgvClientes.Rows[cont].Cells[0].Value = cliente.Id;
                dgvClientes.Rows[cont].Cells[1].Value = cliente.Nome;
                dgvClientes.Rows[cont].Cells[2].Value = cliente.Cpf;
                dgvClientes.Rows[cont].Cells[3].Value = cliente.Telefone;
                dgvClientes.Rows[cont].Cells[4].Value = cliente.Email;
                dgvClientes.Rows[cont].Cells[5].Value = cliente.Data_Nasc;
                dgvClientes.Rows[cont].Cells[6].Value = cliente.Ativo;

                //Soma +1 ao contador de cliente
                cont++;


            }

        }

        private void CarregaGrid1(string nome = "")
        {
            //Obtem lista de clientes
            var lista = Endereco.ObterLista(nome);

            //Limpa as linhas da tabela antes de consultar as informações de cada campo
            dgvEnderecos.Rows.Clear();
            //contador para alterar o índice a cada cliente da lista
            int cont = 0;
            foreach (var enderecos in lista)
            {
                //Adiciona uma nova linha a tabela
                dgvEnderecos.Rows.Add();

                //Preenche a linha com as colunas e seus respectivos dados
                dgvEnderecos.Rows[cont].Cells[0].Value = enderecos.Cep;
                dgvEnderecos.Rows[cont].Cells[1].Value = enderecos.Logradouro;
                dgvEnderecos.Rows[cont].Cells[2].Value = enderecos.Numero;
                dgvEnderecos.Rows[cont].Cells[3].Value = enderecos.Complemento;
                dgvEnderecos.Rows[cont].Cells[4].Value = enderecos.Bairro;
                dgvEnderecos.Rows[cont].Cells[5].Value = enderecos.Cidade;
                dgvEnderecos.Rows[cont].Cells[6].Value = enderecos.Uf;
                dgvEnderecos.Rows[cont].Cells[7].Value = enderecos.Tipo_Endereco;

                //Soma +1 ao contador de cliente
                cont++;


            }

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            //Se algo for digitado no campo, o texto é utilizado como parâmetro da classe CarregaGrid
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                //Se nada for digitado, a classe é executada normalmente e exibe todos os clientes
                CarregaGrid();
            }
        }



        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int posicaoLinha = dgvClientes.CurrentRow.Index;
            id = Convert.ToInt32(dgvClientes.Rows[posicaoLinha].Cells[0].Value);

            //MessageBox.Show(id.ToString());

            this.tabConsultaCliente.SelectedTab = tabPageEditar;
        }
    }
}

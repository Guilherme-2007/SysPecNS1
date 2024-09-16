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
    public partial class FrmEstoque : Form
    {
        public FrmEstoque()
        {
            InitializeComponent();
        }

        private void FrmEstoque_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid(string nome = "")
        {
            var lista = Produto.ObterLista(nome);
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.CodBarras;
                dgvProdutos.Rows[cont].Cells[2].Value = produto.Descricao;
                dgvProdutos.Rows[cont].Cells[3].Value = produto.ValorUnit;
                dgvProdutos.Rows[cont].Cells[4].Value = produto.UnidadeVenda;
                dgvProdutos.Rows[cont].Cells[5].Value = produto.Categoria.Nome;
                dgvProdutos.Rows[cont].Cells[6].Value = produto.EstoqueMinimo;
                dgvProdutos.Rows[cont].Cells[7].Value = produto.ClasseDesconto;
                dgvProdutos.Rows[cont].Cells[8].Value = produto.DataCad;

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

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = 0;
            //Identifica a linha atual(que foi clicada)
            int posicaoLinha = dgvProdutos.CurrentRow.Index;

            //Atribui o valor da celula 0 da linha atual(id)
            id = Convert.ToInt32(dgvProdutos.Rows[posicaoLinha].Cells[0].Value);

            txtEntradaEstoque.Clear();
            //Ativa os campos de entrada no estoque
            gpEstoque.Enabled = true;

            Produto produto = Produto.ObterPorId(id);

            //Preenche os campos com as informações do produto após obtê-los através do ID
            txtId.Text = produto.Id.ToString();
            txtCodBarras.Text = produto.CodBarras;
            txtDescricao.Text = produto.Descricao;
            txtUnidadeVenda.Text = produto.UnidadeVenda;
            txtEstoqueMin.Text = produto.EstoqueMinimo.ToString() + $" {produto.UnidadeVenda}s";

            Estoque estoque = Estoque.ObterPorProduto(id);
            txtDisponivelEstoque.Text = estoque.Quantidade.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            double entrada = double.Parse(txtDisponivelEstoque.Text);
            entrada += double.Parse(txtEntradaEstoque.Text);
            string estqMin = txtEstoqueMin.Text;
            double estqDisponivel = double.Parse(txtDisponivelEstoque.Text);
            string qtdeEstoqueMin = estqMin.Substring(0, 3);
            double estoqueMin = double.Parse(qtdeEstoqueMin);

            if (entrada < estoqueMin && estqDisponivel < estoqueMin)
            {
                MessageBox.Show($"É necessário inserir no mínimo {txtEstoqueMin.Text} desse produto no estoque.");
            }
            else
            {

                Estoque estoque = new(
                    Produto.ObterPorId(id),
                    entrada,
                    DateTime.Now
                    );

                estoque.Atualizar(id, entrada);

                txtId.Clear();
                txtCodBarras.Clear();
                txtDescricao.Clear();
                txtUnidadeVenda.Clear();
                txtEstoqueMin.Clear();
                txtDisponivelEstoque.Clear();
                txtEntradaEstoque.Clear();

                FrmEstoque_Load(sender, e);
            }
        }
    }
}
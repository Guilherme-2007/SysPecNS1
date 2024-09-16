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

        private void CarregaGrid()
        {
            var lista = Produto.ObterLista();
            dgvProdutos.Rows.Clear();
            int cont = 0;
            foreach (var produto in lista)
            {
                dgvProdutos.Rows.Add();
                dgvProdutos.Rows[cont].Cells[0].Value = produto.Id;
                dgvProdutos.Rows[cont].Cells[1].Value = produto.CodBar;
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


        private void btnInsere_Click(object sender, EventArgs e)
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
                MessageBox.Show($"Inserir {txtEstoqueMin.Text} desse produto no estoque.");
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
                txtCodBar.Clear();
                txtDescricao.Clear();
                txtUnidadeVenda.Clear();
                txtEstoqueMin.Clear();
                txtDisponivelEstoque.Clear();
                txtEntradaEstoque.Clear();

                FrmEstoque_Load(sender, e);
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;

            int posicaoLinha = dgvProdutos.CurrentRow.Index;

            id = Convert.ToInt32(dgvProdutos.Rows[posicaoLinha].Cells[0].Value);

            txtEntradaEstoque.Clear();

            Produto produto = Produto.ObterPorId(id);

            txtId.Text = produto.Id.ToString();
            txtCodBar.Text = produto.CodBar;
            txtDescricao.Text = produto.Descricao;
            txtUnidadeVenda.Text = produto.UnidadeVenda;
            txtEstoqueMin.Text = produto.EstoqueMinimo.ToString() + $" {produto.UnidadeVenda}s";

            Estoque estoque = Estoque.ObterPorProduto(id);
            txtDisponivelEstoque.Text = estoque.Quantidade.ToString();
        }
    }
}
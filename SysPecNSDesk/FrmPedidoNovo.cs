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
    public partial class FrmPedidoNovo : Form
    {
        public int ClienteId;
        public string NomeCliente;

        Produto produto;
        public FrmPedidoNovo()
        {
            InitializeComponent();
        }

        private void FrmPedidoNovo_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Program.UsuarioLogado.Id + " - " + Program.UsuarioLogado.Nome;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserePedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new(
                Program.UsuarioLogado,
                Cliente.ObterPorId(int.Parse(txtIdCliente.Text)), 0
                );
            pedido.Inserir();
            txtIdPedido.Text = pedido.Id.ToString();
            grbItens.Enabled = true;
            grbIdentificacao.Enabled = false;
            txtCodBar.Focus();

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodBar_Leave(object sender, EventArgs e)
        {
            if (txtCodBar.Text.Length > 0)
            {
                produto = Produto.ObterPorId(txtCodBar.Text);
                txtDescricao.Text = produto.Descricao;
                txtValorUnit.Text = produto.ValorUnit.ToString();
                if (produto.ClasseDesconto == 0)
                {
                    txtDescontoItem.Enabled = false;
                }
                else
                {
                    txtDescontoItem.Enabled = true;
                    label15.Text = "R$" + (produto.ValorUnit * produto.ClasseDesconto).ToString("#0.00");
                }
                txtValorUnit.ReadOnly = true;
                txtQuantidade.Focus();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            double descontoItem = Convert.ToDouble(txtDescontoItem.Text);
            Produto produto = Produto.ObterPorId(txtCodBar.Text);
            Estoque estoque = Estoque.ObterPorProduto(produto.Id);
            double qtdeProduto = double.Parse(txtQuantidade.Text);
            double maxDesconto = ((produto.ValorUnit * produto.ClasseDesconto) * (double.Parse(txtQuantidade.Text)));

            if (qtdeProduto > estoque.Quantidade)
            {
                MessageBox.Show($"Não é possível incluir essa quantidade, há {estoque.Quantidade} {produto.UnidadeVenda}s desse produto disponíveis em estoque.");
            }
            else if (descontoItem > maxDesconto)
            {
                MessageBox.Show("Não é possível aplicar esse desconto!");
            }
            else
            {
                ItemPedido item = new(
                int.Parse(txtIdPedido.Text),
                produto,
                produto.ValorUnit,
                double.Parse(txtQuantidade.Text),
                double.Parse(txtDescontoItem.Text)
                );
                item.Inserir();
                PreencherGridItens();
                txtQuantidade.Text = "1";
                txtDescontoItem.Text = "0";
                txtDescontoPedido.Text = "0";
                txtCodBar.Clear();
                txtDescricao.Clear();
                txtValorUnit.Clear();
                produto = new();
            }
        }

        private void PreencherGridItens()
        {
            var itens = ItemPedido.ObterListaPorPedido(int.Parse(txtIdPedido.Text));
            dgvItensPedido.Rows.Clear();
            int linha = 0;
            double desconto = 0;
            double total = 0;

            foreach (var item in itens)
            {
                dgvItensPedido.Rows.Add();
                dgvItensPedido.Rows[linha].Cells[0].Value = $"#{linha + 1}";
                dgvItensPedido.Rows[linha].Cells[1].Value = item.Produto.CodBar;
                dgvItensPedido.Rows[linha].Cells[2].Value = item.Produto.Descricao;
                dgvItensPedido.Rows[linha].Cells[3].Value = item.ValorUnit.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[4].Value = item.Quantidade.ToString("#0.000");
                dgvItensPedido.Rows[linha].Cells[5].Value = item.Desconto.ToString("#0.00");
                dgvItensPedido.Rows[linha].Cells[6].Value = (item.ValorUnit * item.Quantidade - item.Desconto).ToString("#0.00");
                linha++;
                total += item.ValorUnit * item.Quantidade - item.Desconto;
                desconto += item.Desconto;


            }
            txtTotal.Text = total.ToString("#0.00");
            txtDescontoItens.Text = desconto.ToString("#0.00");

            txtSubTotal.Text = (total + desconto).ToString("#0.00");
            txtTotal.Text = total.ToString("#0.00");

            txtTotal1.Text = (desconto + total).ToString();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmBuscaCliente frmBuscaCliente = new();
            frmBuscaCliente.ShowDialog();

            ClienteId = frmBuscaCliente.ClienteId;

            NomeCliente = frmBuscaCliente.NomeCliente;

            txtIdCliente.Text = ClienteId.ToString();
            txtCliente.Text = NomeCliente;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtDescontoItens_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontoPedido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescontoItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvItensPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

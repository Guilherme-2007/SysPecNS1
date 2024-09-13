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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Estoque estoque = new(
                decimal.Parse(txtProduto.Text),
                TimeSpan.Parse(txtQuantidade.Text)
                );
            estoque.Atualizar();
            MessageBox.Show($"Produto {estoque.Quantidade} - {estoque.DataUltimoMovimento} atualizado com sucesso");
            LimpaControles();
        }

        private void LimpaControles()
        {
            txtProduto.Clear();
            txtQuantidade.Clear();
        }
    }
}

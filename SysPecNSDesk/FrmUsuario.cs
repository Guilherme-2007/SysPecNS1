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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            //carregando o combobox de niveis
            var niveis = Nivel.ObterLista();
            //Carrega a lista de nivel
            cmbNivel.DataSource = niveis;
            //Exibe o nome do nível para o usuario
            cmbNivel.DisplayMember = "Nome";
            //Retorna para o banco o valor contido na coluna ID.
            cmbNivel.ValueMember = "Id";

            CarregaGrid();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cria um novo objeto usuário
            Usuario usuario = new(
                txtNome.Text,
                txtEmail.Text,
                txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(cmbNivel.SelectedValue))
                );
            //Insere as informações no banco
            usuario.Inserir();
            if (usuario.Id > 0)
            {
                //Exibe id gerado para o novo usuário, enquanto a caixa de diálogo não for fechada.
                txtId.Text = usuario.Id.ToString();
                MessageBox.Show($"O usuário {usuario.Nome}, " + $"foi inserido com sucesso, com o ID {usuario.Id}.");
                //Limpa as informações do formulário
                txtId.Clear();
                txtNome.Clear();
                txtEmail.Clear();
                txtConfSenha.Clear();
                txtSenha.Clear();
                //Foca o cursor no campo Nome para a nova inserção
                txtNome.Focus();
                //Recarrega a tabela do formulário para exibir o novo usuário na lista
                FrmUsuario_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Falha ao gravar o usuário.");
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text.Length > 0)
            {
                CarregaGrid(txtBusca.Text);
            }
            else
            {
                CarregaGrid();
            }
        }

        //Método privado que só funciona nesse formulário
        private void CarregaGrid(string nome = "")
        {

            //Preenchendo o datagrid com os usuarios
            var lista = Usuario.ObterLista(nome);

            //Limpar as linhas da tabela
            dgvUsuarios.Rows.Clear();
            int cont = 0;
            foreach (var usuario in lista)
            {
                //Carrega informações de cada campo nas linhas da tabela
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[cont].Cells[0].Value = usuario.Id;
                dgvUsuarios.Rows[cont].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[cont].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[cont].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[cont].Cells[4].Value = usuario.Ativo;

                cont++;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //É possível utilizar um método como parêmetro, que retorne um valor booleano
            if (VerificaControles())
            {
                var msg = MessageBox.Show(
                    "Deseja continuar o cadastro?", //Texto da mensagem 
                    "Cadastro de Usuário", //Título da caixa de mensagem
                    MessageBoxButtons.YesNo, //Botões exibidos na caixa
                    MessageBoxIcon.Exclamation, //Ícone exibido
                    MessageBoxDefaultButton.Button1); //Botão padrão

                if (msg == DialogResult.No) this.Close();
            }
            else { this.Close(); }

        }

        //Método 
        private bool VerificaControles()
        {
            if (txtNome.Text != string.Empty
                || txtEmail.Text != string.Empty
                || txtSenha.Text != string.Empty
                || txtConfSenha.Text != string.Empty)
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;
            int posicaoLinha = dgvUsuarios.CurrentRow.Index;
            id = Convert.ToInt32(dgvUsuarios.Rows[posicaoLinha].Cells[0].Value);

            MessageBox.Show(id.ToString());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}

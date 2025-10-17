using DAO.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class FrmContatos : Form
    {
        public FrmContatos()
        {
            InitializeComponent();

            CarregarContatos();
        }

        private void CarregarContatos()
        {
            try
            {
                ContatoDAO contatoDAO = new ContatoDAO();

                // Impede que o DataGridView gere colunas automáticas que bagunçam a ordem
                dgvContatos.AutoGenerateColumns = false;

                // Recarrega os dados
                dgvContatos.DataSource = contatoDAO.ObterTodos();

                // Opcional: atualiza a exibição
                dgvContatos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar contatos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmContato frmContato = new FrmContato();
            frmContato.FormClosed += FrmContato_FormClosed;
            frmContato.MdiParent = this.MdiParent; // O pai deste formulário atual
            frmContato.Show();
         
        }



        private void dgvContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtém o ID da linha clicada (coluna 0)
            var idContato = Convert.ToInt32(dgvContatos.Rows[e.RowIndex].Cells[0].Value);

            if (e.ColumnIndex == dgvContatos.Columns["Editar"].Index)
            {               

                FrmContato frmContato = new FrmContato(idContato);
                frmContato.FormClosed += FrmContato_FormClosed;
                frmContato.MdiParent = this.MdiParent; // O pai deste formulário atual
                frmContato.Show();
              
            }
            else if (e.ColumnIndex == dgvContatos.Columns["Remover"].Index)
            {
                // 1. Exibe a caixa de diálogo de confirmação
                DialogResult resultado = MessageBox.Show(
                    "Tem certeza que deseja remover este contato?", // Mensagem
                    "Confirmar Remoção",                           // Título
                    MessageBoxButtons.YesNo,                       // Botões que serão exibidos
                    MessageBoxIcon.Warning                         // Ícone de alerta
                );

                // 2. Verifica se o usuário clicou em 'Sim'
                if (resultado == DialogResult.Yes)
                {
                    // Lógica para remover (só executa se confirmar)
                    ContatoDAO dao = new ContatoDAO();
                    dao.Excluir(idContato);

                    // Recarrega a lista para mostrar a remoção
                    CarregarContatos();
                }
                // Se o usuário clicar em 'Não', o código simplesmente ignora a remoção.
            }
        }

        private void FrmContato_FormClosed(object sender, FormClosedEventArgs e)
        {           
            CarregarContatos();
        }
    }
}

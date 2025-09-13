using Aula06.Modelos;
using Aula06Agenda.Repositorios;

namespace Aula06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            Contato contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Telefone = txtTelefone.Text;
            contato.Email = txtEmail.Text;

            try
            {

                bool retorno = new ContatoRepositorio().InserirContato(contato);

                if (retorno)
                {
                    MessageBox.Show("Contato adicionado com sucesso!", "Atenção");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao adicionar contato: " + ex.Message, "Erro");

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
         

            try
            {

                Contato contato = new Contato();
                contato.Nome = txtNome.Text;
                contato.Telefone = txtTelefone.Text;
                contato.Email = txtEmail.Text;
                contato.Id_Contato = Convert.ToInt32(txtId.Text);

                bool retorno = new ContatoRepositorio().AlterarContato(contato);

                if (retorno)
                {
                    MessageBox.Show("Contato alterado com sucesso!", "Atenção");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao adicionar contato: " + ex.Message, "Erro");

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ContatoRepositorio contaRepo = new ContatoRepositorio();
            contaRepo.DeletarContato();

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            ContatoRepositorio contaRepo = new ContatoRepositorio();
            contaRepo.SelecionarContatos();
        }
    }
}

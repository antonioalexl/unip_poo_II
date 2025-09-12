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
            ContatoRepositorio contaRepo = new ContatoRepositorio();
            contaRepo.InserirContato();
        }
    }
}

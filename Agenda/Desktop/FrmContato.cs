using DAO.Classes;
using Modelos;
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
    public partial class FrmContato : Form
    {
        private int Id = 0;

        public FrmContato()
        {
            InitializeComponent();
        }

        public FrmContato(int? id)
        {
            InitializeComponent();
            this.Id = id ?? 0;
            carregarContato();


        }

        private void carregarContato()
        {

            ContatoDAO dao = new ContatoDAO();
            Contato contato = dao.ObterPorId(this.Id);

            txtEmail.Text = contato.Email;
            txtNome.Text = contato.Nome;
            txtTelefone.Text = contato.Telefone;
            txtId.Text = contato.Id_Contato.ToString();
            //dtpDataNascimento.Value = contato.DataNascimento == null ? DateTime.MinValue : Convert.ToDateTime(contato.DataNascimento);

        }

        private void FrmContato_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            Contato contato = new Contato();
            contato.Nome = txtNome.Text;
            contato.Telefone = txtTelefone.Text;
            contato.Email = txtEmail.Text;
            contato.DataNascimento = dtpDataNascimento.Value;

            ContatoDAO dao = new ContatoDAO();    

            bool retorno = false;

            if (this.Id == 0)//Inserir
            {
                retorno = dao.Inserir(contato);         

            }
            else
            {
                contato.Id_Contato = this.Id;
                retorno = dao.Alterar(contato);

            }

            if (retorno == true)
            {
                this.Close();
            }
        }
    }
}

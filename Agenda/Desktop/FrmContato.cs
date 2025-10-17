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

            if (this.Id == 0)
            {
                lblId.Visible = false;
                txtId.Visible = false;
            }
        }

        public FrmContato(int? id)
        {
            InitializeComponent();
            this.Id = id ?? 0;

            if (this.Id > 0)
            {
                lblId.Visible = true;
                txtId.Visible = true;
                txtId.ReadOnly = true;
            }

            carregarContato();


        }

        private void carregarContato()
        {

            ContatoDAO dao = new ContatoDAO();
            Contato contato = dao.ObterPorId(this.Id);

            txtEmail.Text = contato.Email;
            txtNome.Text = contato.Nome;
            mTxtTelefone.Text = contato.Telefone;
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
            contato.Telefone = mTxtTelefone.Text;
            contato.Email = txtEmail.Text;
            contato.DataNascimento = dtpDataNascimento.Value;
            contato.Id_Contato = this.Id;

            bool retorno = false;

            try
            {
                retorno = new ContatoDAO().SalvarContato(contato);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha ao salvar registro", "Atenção"); 
            }
            if (retorno == true)
            {
                this.Close();
            }
        }
    }
}

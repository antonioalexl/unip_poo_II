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
            ContatoDAO contatoDao = new ContatoDAO();
            dgvContatos.DataSource = contatoDao.ObterContatos();
            dgvContatos.Show();
        }

        private void btnNovoContato_Click(object sender, EventArgs e)
        {

        }
    }
}

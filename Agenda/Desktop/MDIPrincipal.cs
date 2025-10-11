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
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

       

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

            
      
        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContatos frmContatos = new FrmContatos();

            // --- ADICIONE ESTA LINHA ---
            frmContatos.StartPosition = FormStartPosition.CenterScreen;
            // ---------------------------

            frmContatos.Show();
            frmContatos.MdiParent = this;
        }

        
    }
}

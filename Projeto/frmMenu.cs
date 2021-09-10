using _2020_04_20_VetorArray;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void AgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOutro oForm = new frmOutro();
            oForm.Show();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastrar oCad = new FrmCadastrar();
            oCad.Show();
        }

        private void listaDeDesenvolvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLista oList = new frmLista();
            oList.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre oSob = new frmSobre();
            oSob.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}

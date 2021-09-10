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
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoDataSet3.DESENVOLVEDORR'. Você pode movê-la ou removê-la conforme necessário.
            this.dESENVOLVEDORRTableAdapter.Fill(this.projetoDataSet3.DESENVOLVEDORR);
            

        }
    }
}

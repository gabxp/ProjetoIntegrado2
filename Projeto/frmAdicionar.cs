using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_04_20_VetorArray
{
    public partial class frmAdicionar : Form
    {
        public Boolean bOk = false;
        public String sDesenvolvedor;
        public String sProjeto;
        public String sStartDate;
        public String sDeadLine;

        public frmAdicionar()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            sDesenvolvedor = this.txtNome.Text;
            sProjeto = this.txtSobrenome.Text;
            sStartDate = this.mskTelefone.Text;
            sDeadLine = this.mskDeadLine.Text;
            bOk = true;
            this.Close();
        }
        private void btnCancela_Click(object sender, EventArgs e)
        {
            bOk = false;
            this.Close();
        }

        private void frmAdicionar_Load(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

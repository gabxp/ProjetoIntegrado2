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
    public partial class frmOutro : Form
    {


        public frmOutro()
        {
            InitializeComponent();
        }

        private void frmOutro_Load(object sender, EventArgs e)
        {
           
            carrega();
        }

        private void carrega()
        {
           
            string[] sLinha01 = new string[] { "Mari", "Special Game ", "10/06/2020", "20/06/2020"};
            string[] sLinha02 = new string[] { "Gabe", "Jogos Online", "03/07/2020", "03/08/2020" };
            

            object[] tabela = new object[] { sLinha01, sLinha02 };

            foreach (string[] LinhaMatriz in tabela)
            {
                dgvItens.Rows.Add(LinhaMatriz);
            }



        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmAdicionar form = new frmAdicionar();
            form.ShowDialog();
            if (form.bOk)
            {
                string[] sNovaLinha = new string[] {
                    form.sDesenvolvedor, form.sProjeto, form.sStartDate, form.sDeadLine
                };
                dgvItens.Rows.Add(sNovaLinha);
                MessageBox.Show("Registro adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Cancelado pelo usuário!");
            }
            form = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count>1 )
            {
                dgvItens.Rows.RemoveAt(dgvItens.CurrentRow.Index);
            }
        }

        private void dgvItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto
{
    public partial class FrmCadastrar : Form
    {
        readonly string strConexao = @"server=localhost;user id=root;database=playstar";


        public FrmCadastrar()
        {
            InitializeComponent();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar("L");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool Valida()
            {
                bool ret = true;
                if (this.txbNome.Text.Equals(""))
                {
                    MessageBox.Show("O nome precisa ser preenchido");
                    this.txbNome.Focus();
                    ret = false;
                }

                else if (this.txbEndereco.Text.Equals(""))
                {
                    MessageBox.Show("O endereço precisa ser preenchido");
                    this.txbEndereco.Focus();
                    ret = false;
                }
                else if (Equals(""))
                {
                    MessageBox.Show("O nome precisa ser preenchido");
                    this.txbNome.Focus();
                    ret = false;
                }

                return ret;
            }

            if (Valida() == true)
            {
                string sql = "INSERT INTO desenvolvedor (nome, endereco, telefone, email, cargo )"
                   + "VALUES ('" + txbNome.Text + "' , ' " + txbEndereco.Text + " ' , ' "
                   + txbTelefone.Text + " ' , ' " + txbEmail.Text + " ' , ' " + txbCargo.Text + " ')";

                MySqlConnection con = new MySqlConnection(strConexao);
                MySqlCommand cmd = new MySqlCommand(sql, con)
                {
                    CommandType = CommandType.Text
                };
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
                txbNome.Clear();
                txbEndereco.Clear();
                txbTelefone.Clear();
                txbEmail.Clear();
                txbCargo.Clear();

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Limpar(string tipo)
        {
            //txtCodigo.Clear();
            txbNome.Clear();
            txbEmail.Clear();
            txbEndereco.Clear();
            txbTelefone.Clear();
            txbNome.Enabled = true;
            txbEndereco.Enabled = true;
            txbTelefone.Enabled = true;
            txbEmail.Enabled = true;

        }

        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
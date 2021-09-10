
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
    public partial class FrmLogin : Form
    {
        readonly string strConexao = @"server=localhost;user id=root;database=playstar";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txbNomeLogin.Text == "" || txbSenha.Text == "")
            {
                MessageBox.Show("Campos não podem ficar em branco");
            }
            else
            {
                string sql = "INSERT INTO telalogin(nomelogin, senha  )"
                    + "VALUES ('" + txbNomeLogin.Text + "','" + txbSenha.Text + "')";

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
                txbNomeLogin.Clear();
                txbSenha.Clear();
            }
        }

        private void BtnAcessar_Click(object sender, EventArgs e)
        {
            string sql = "(SELECT * FROM telalogin WHERE nomelogin = '" + txbNomeLogin.Text + "' AND senha = '" + txbSenha.Text + "')";

            MySqlConnection con = new MySqlConnection(strConexao);
            MySqlCommand cmd = new MySqlCommand(sql, con)
            {
                CommandType = CommandType.Text
            };
            MySqlDataReader reader;
            con.Open();

            reader = cmd.ExecuteReader();
            try
            {
                if (!reader.Read())
                {
                    MessageBox.Show("LOGIN E SENHA INCORRETOS");
                }
                else
                {
                    this.Hide();
                    frmMenu newForm = new frmMenu();
                    newForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

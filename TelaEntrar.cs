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

namespace TESTEPLAY
{
    public partial class TelaEntrar : Form
    {

        string conexao = @"Server=.\SQLEXPRESS;Database=TestePlay;Integrated Security=True";
        public TelaEntrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conexao);

            string sql = "SELECT COUNT(*) FROM Usuarios WHERE Login = @Login AND SenhaUsuario = @Senha";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Login", textBox1.Text);
            cmd.Parameters.AddWithValue("@Senha", textBox2.Text);

            conn.Open();

            int resultado = (int)cmd.ExecuteScalar();

            conn.Close();

            if (resultado > 0)
            {
                MessageBox.Show("Login realizado com sucesso!");

                MenuPrincipal menu = new MenuPrincipal();

                menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}

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
    public partial class CadastroUsuarios : Form
    {
        string conexao = @"Server=.\SQLEXPRESS;Database=TestePlay;Integrated Security=True";

        public CadastroUsuarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conexao);

            string sql = "INSERT INTO Usuarios (Nome, Login, SenhaUsuario) VALUES (@Nome, @Login, @SenhaUsuario)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Nome", textBox1.Text);
            cmd.Parameters.AddWithValue("@Login", textBox2.Text);
            cmd.Parameters.AddWithValue("@SenhaUsuario", textBox3.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();


            MessageBox.Show(
                "Salvo com sucesso!",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
    );

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

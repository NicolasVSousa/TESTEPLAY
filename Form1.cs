using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;


namespace TESTEPLAY
{
    public partial class Form1 : Form
    {
        string conexao = @"Server=.\SQLEXPRESS;Database=TestePlay;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            CarregarEstados();
       

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNameLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button_Salvar(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o nome!");
                return;
            }
            if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Preencha o telefone!");
                return;
            }
            if (!maskedTextBox2.MaskCompleted)
            {
                MessageBox.Show("Preencha o CPF/CNPJ!");
                return;
            }
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Preencha a cidade!");
                return;
            }
            if (comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("Preencha O estado");
                    return;
            }

            SqlConnection conn = new SqlConnection(conexao);

            string sql = "INSERT INTO Clientes (Nome, Telefone, CPF, Cidade, Estado) VALUES (@Nome, @Telefone, @CPF, @Cidade," +
                "@Estado)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Nome", textBox1.Text);
            cmd.Parameters.AddWithValue("@Telefone", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@CPF", maskedTextBox2.Text);
            cmd.Parameters.AddWithValue("@Cidade", textBox2.Text);
            cmd.Parameters.AddWithValue("@Estado", comboBox1.Text);

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

        private void button2_Cancelar(object sender, EventArgs e)
        {
            textBox1.Clear();
            maskedTextBox2.Clear();
            maskedTextBox1.Clear();
            maskedTextBox2.Focus();
            textBox2.Clear();

            MessageBox.Show(
                "Excluido com sucesso!",
                "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
        }


        private void maskedTextBoxFone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label_Cidade(object sender, EventArgs e)
        {

        }

        private void textBox_Cidade(object sender, EventArgs e)
        {

        }

        private void comboBox1_Estado(object sender, EventArgs e)
        {

        }

        private void CarregarEstados()
        {
            comboBox1.Items.Add("Acre");
            comboBox1.Items.Add("Alagoas");
            comboBox1.Items.Add("Amapá");
            comboBox1.Items.Add("Amazonas");
            comboBox1.Items.Add("Bahia");
            comboBox1.Items.Add("Ceará");
            comboBox1.Items.Add("Distrito Federal");
            comboBox1.Items.Add("Espírito Santo");
            comboBox1.Items.Add("Goiás");
            comboBox1.Items.Add("Maranhão");
            comboBox1.Items.Add("Mato Grosso");
            comboBox1.Items.Add("Mato Grosso do Sul");
            comboBox1.Items.Add("Minas Gerais");
            comboBox1.Items.Add("Pará");
            comboBox1.Items.Add("Paraíba");
            comboBox1.Items.Add("Paraná");
            comboBox1.Items.Add("Pernambuco");
            comboBox1.Items.Add("Piauí");
            comboBox1.Items.Add("Rio de Janeiro");
            comboBox1.Items.Add("Rio Grande do Norte");
            comboBox1.Items.Add("Rio Grande do Sul");
            comboBox1.Items.Add("Rondônia");
            comboBox1.Items.Add("Roraima");
            comboBox1.Items.Add("Santa Catarina");
            comboBox1.Items.Add("São Paulo");
            comboBox1.Items.Add("Sergipe");
            comboBox1.Items.Add("Tocantins");
        }
    }
}



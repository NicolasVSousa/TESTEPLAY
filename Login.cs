using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TESTEPLAY
{
    public partial class Login : Form
    {

        string conexao = @"Server=.\SQLEXPRESS;Database=TestePlay;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void button_Cadastro(object sender, EventArgs e)
        {
            CadastroUsuarios tela = new CadastroUsuarios();

            tela.ShowDialog();
        }

        private void button_Entrar(object sender, EventArgs e)
        {
            TelaEntrar Tela = new TelaEntrar();
            Tela.ShowDialog();
        }
    }
}

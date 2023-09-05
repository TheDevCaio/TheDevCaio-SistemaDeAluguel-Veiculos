using SistemadeAlugueldeVeiculos.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeAlugueldeVeiculos.Acess
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();
        }

        private void menuToolStripMenu_Click(object sender, EventArgs e)
        {
            Menu menuCliente = new Menu();
            menuCliente.Show();
            this.Hide();
        }

        private void loginToolStripLogin_Click(object sender, EventArgs e)
        {
            Login menuLogin = new Login();
            menuLogin.Show();
            this.Hide();
        }

        private void cadastroToolStripCadastro_Click(object sender, EventArgs e)
        {
                Cadastro cadCliente = new Cadastro();
                cadCliente.Show();
                this.Hide();

        }
    }
}

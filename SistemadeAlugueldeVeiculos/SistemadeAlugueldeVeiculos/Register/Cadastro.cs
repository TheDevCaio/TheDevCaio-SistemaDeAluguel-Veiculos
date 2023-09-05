using SistemadeAlugueldeVeiculos.Acess;
using SistemadeAlugueldeVeiculos.Entityes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace SistemadeAlugueldeVeiculos.Register
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void CPF_Click(object sender, EventArgs e)
        {

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void Obs_Click(object sender, EventArgs e)
        {

        }

        private void Celular_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textCelular.Clear();
            textCPF.Clear();
            textEmail.Clear();
            textTelefone.Clear();
            textNome.Clear();
            textEndereco.Clear();
            textWhatsApp.Clear();
            textData.Value = DateTime.Now;

        }






        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textData_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void textWhatsApp_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarFormulario()
        {
            bool FormValido;
            if(textNome.Text.Length == 0)
            {
                MessageBox.Show("Informe o nome.");
                textNome.Focus();
                FormValido = false;
            }
            else if (textCPF.Text.Length == 0)
            {
                MessageBox.Show("Informe o CPF.");
                textCPF.Focus();
                FormValido = false;
            }
            else if (textEmail.Text.Length == 0)
            {
                MessageBox.Show("Informe o email.");
                textEmail.Focus();
                FormValido = false;
            }
            else if (textTelefone.Text.Length == 0)
            {
                MessageBox.Show("Informe o telefone.");
                textTelefone.Focus();
                FormValido = false;
            }
            else if (textEndereco.Text.Length == 0)
            {
                MessageBox.Show("Informe o endereço.");
                textEndereco.Focus();
                FormValido = false;
            }
            else if (textCelular.Text.Length == 0)
            {
                MessageBox.Show("Informe o celular.");
                textCelular.Focus();
                FormValido = false;
            }
            else if (textWhatsApp.Text.Length == 0)
            {
                MessageBox.Show("Informe o WhatsApp.");
                textWhatsApp.Focus();
                FormValido = false;
            }
            else
            {
                FormValido = true;
            }
            return FormValido;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (ValidarFormulario())
            {
                Cliente novoCliente = new Cliente();
                novoCliente.Nome = textNome.Text;
                novoCliente.CPF = textCPF.Text;
                novoCliente.Email = textEmail.Text;
                novoCliente.Telefone = textTelefone.Text;
                novoCliente.Endereço = textEndereco.Text;
                novoCliente.Celular = textCelular.Text;
                novoCliente.WhatsApp = textWhatsApp.Text;
                novoCliente.Salvar();
                MessageBox.Show($"{novoCliente.Salvar()}");
            }

    }


        private void cadastroToolStripMenuItemC_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItemC_Click(object sender, EventArgs e)
        {
            Menu menuCliente = new Menu();
            menuCliente.Show();
            this.Hide();
        }

        private void loginToolStripMenuItemC_Click(object sender, EventArgs e)
        {
            Login menuLogin = new Login();
            menuLogin.Show();
            this.Hide();
        }

        private void cadastrarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

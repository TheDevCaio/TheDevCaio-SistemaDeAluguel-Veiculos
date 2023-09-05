using SistemadeAlugueldeVeiculos.Acess;
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

namespace SistemadeAlugueldeVeiculos.Payment
{
    public partial class Credit : Form
    {
        public Credit()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string conta = textConta.Text;
                double valor = double.Parse(textValor.Text);
                string total = lblTot.Text;

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login menuLogin = new Login();
            menuLogin.Show();
            this.Hide();

        }
        private void cadastrarUmVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void agendarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void debitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debit debit = new Debit();
            debit.Show();
            this.Hide();
        }
    }
}

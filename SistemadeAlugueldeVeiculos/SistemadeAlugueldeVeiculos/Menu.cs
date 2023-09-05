using SistemadeAlugueldeVeiculos.Acess;
using SistemadeAlugueldeVeiculos.Entityes;
using SistemadeAlugueldeVeiculos.Payment;
using SistemadeAlugueldeVeiculos.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeAlugueldeVeiculos
{
    public partial class Menu : Form
    {
        private object str;

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private bool VerificaCampos()
        {
            bool FormValido;
            if (espcUM.Text.Length == 0)
            {
                MessageBox.Show("Informe a marca.");
                espcUM.Focus();
                FormValido = false;
            }
            else if (espcDOIS.Text.Length == 0)
            {
                MessageBox.Show("Informe o modelo.");
                espcDOIS.Focus();
                FormValido = false;
            }

            //Incrementando um RadioButton, caso precise mais tarde.
            /* else if (!rdoNao.Checked && !rdoSim.Checked )
            {
            MessageBox.Show("Selecione uma opção");
            rdoNao.Focus();
            rdoSim.Focus();
            FormValido = false;
            }
            */

            else if (espcTRES.Text.Length == 0)
            {
                MessageBox.Show("Informe a potência.");
                espcTRES.Focus();
                FormValido = false;
            }
            else if (espcQUATRO.Text.Length == 0)
            {
                MessageBox.Show("Informe a cor.");
                espcQUATRO.Focus();
                FormValido = false;
            }
            else
            {
                FormValido = true;
            }
            return FormValido;
        }

        private void buttonVerifica_Click(object sender, EventArgs e)
        {
            Carro novoCarroPedido = new Carro();
            novoCarroPedido.Marca = espcUM.Text;
            novoCarroPedido.Modelo = espcDOIS.Text;
            novoCarroPedido.Potencia = espcTRES.Text;
            novoCarroPedido.Cor = espcQUATRO.Text;

            //adicionando dependência entre eles
            this.Controls.Add(espcUM);
            this.Controls.Add(espcDOIS);
            this.Controls.Add(espcTRES);
            this.Controls.Add(espcQUATRO);

            //ligando variáveis nos componentes
            string espc_um = espcUM.ToString();
            string espc_dois = espcDOIS.ToString();
            string espc_tres = espcTRES.ToString();
            string espc_quatro = espcQUATRO.ToString();


            //regra de negócio
            if (novoCarroPedido.Marca !=  null && espcDOIS != null && espcTRES != null && espcQUATRO != null)
            {
                labelAprov.Text = "Pacote disponível";
                novoCarroPedido.Salvar();
                MessageBox.Show($"{novoCarroPedido.Salvar()}");
            }
            else
            {

                labelReprov.Text = "Uma ou mais opções indisponíveis";
            }


            espcUM.BeginUpdate();

            espcDOIS.BeginUpdate();

            espcTRES.BeginUpdate();

            espcUM.EndUpdate();

            espcDOIS.EndUpdate();

            espcTRES.EndUpdate();

            //usar combobox

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void h2_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login loginCliente = new Login();
            loginCliente.Show();
            this.Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            Menu pagInicia = new Menu();
            pagInicia.Show();
            pagInicia.Close();

            this.Hide();
        }

        private void espcUM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cadastrarUmVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menuCliente = new Menu();
            menuCliente.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();

            this.Hide();
        }

        private void agendarCarroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();

            this.Hide();

        }

        private void debitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debit debit = new Debit();
            debit.Show();
            this.Hide();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.Show();
            this.Hide();
        }
    }
}

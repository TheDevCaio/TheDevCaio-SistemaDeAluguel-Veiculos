using SistemadeAlugueldeVeiculos.Acess;
using SistemadeAlugueldeVeiculos.Entityes;
using SistemadeAlugueldeVeiculos.Payment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemadeAlugueldeVeiculos.Register
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void h1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaca_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            List<Carro> listaCarros = Carro.BuscarPlaca(placa);
            if (listaCarros.Count > 0 )
            {
                txtMarca.Text = listaCarros[0].Marca;
            }
            else
            {
                MessageBox.Show("Placa não cadastrada");
            }
        }

        private void btnCPF_Click(object sender, EventArgs e)
        {
            double cpf;
            if (double.TryParse(txtCPF.Text, out cpf))
            {
                List<Cliente> clientes = Cliente.BuscarCpf(cpf);
                if (clientes.Count > 0)
                {
                    txtNome.Text = clientes[0].Nome;
                }
                else
                {
                    MessageBox.Show("CPF não cadastrado");
                }

            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void cadastrarVeículoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
            
        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();
        }



        private void btnData_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string nome = txtNome.Text;
            DateTime dataInicioFormatada = DateTime.ParseExact(dataInicio.Text, "dd/MM/yyyy", null);
            DateTime dataFimFormatada = DateTime.ParseExact(dataFinal.Text, "dd/MM/yyyy", null);

            if (string.IsNullOrWhiteSpace(txtMarca.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha todos os campos antes de continuar");
            }
            else
            {
                DialogResult novoRegistro = MessageBox.Show("Data" + " de início: " + MessageBoxButtons.OKCancel);

                if (novoRegistro == DialogResult.OK)
                {
                    Registro registro = new Registro();
                    registro.Marca = marca;
                    registro.Nome = nome;
                    /*registro.DataInicial = dataInicioFormatada;*/
                    /*registro.DataFinal = dataFimFormatada;*/
                    registro.Salvar();
                }
                else
                {
                    MessageBox.Show("Verifique as datas novamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.Show();
            this.Hide();
        }

        private void debitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Debit debit = new Debit();
            debit.Show();
            this.Hide();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

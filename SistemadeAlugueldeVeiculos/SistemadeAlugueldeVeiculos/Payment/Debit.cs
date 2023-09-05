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
    public partial class Debit : Form
    {
        public Debit()
        {
            InitializeComponent();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            credit.Show();
            this.Hide();
        }

        private void debitToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
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
    }
}

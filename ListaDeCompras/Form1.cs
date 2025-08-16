using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAdc_Click(object sender, EventArgs e)
        {
            if (txbProduto.Text.Length == 0)
            {
                MessageBox.Show("O nome do produto não pode estar vazio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbProduto.Text.Length < 2)
            {
                MessageBox.Show("O nome do produto precisa ter no  minimo duas letras!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listCompras.Items.Add(txbProduto.Text);
                    MessageBox.Show($"{txbProduto.Text} foi adicionado na lista de compras ! ", "show!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txbProduto.Text = ""; //igual txbProduto.Clear();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja apagar tudo ? ", "atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
              listCompras.Items.Clear();
            }

        }

        private void txbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdc.PerformClick();
            }
        }
    }
}


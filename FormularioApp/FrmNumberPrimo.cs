using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class FrmNumberPrimo : Form
    {
        public FrmNumberPrimo()
        {
            InitializeComponent();
        }

        private void FrmNumberPrimo_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtNumberEn.Text, out double SoloNum))
            {
                MessageBox.Show("Ingrese solo numeros enteros....", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNumberEn.Clear();
                this.txtNumberEn.Focus();
                return;
            }
            int numero = int.Parse(txtNumberEn.Text);
            Encontrarprimo(numero);
        }
        void Encontrarprimo(int numero)
        {
            int cont = 0;
            for (int k = 1; k <= numero; k++)
            {
                if (numero % k == 0)
                {
                    cont++;
                }
            }

            if (cont == 2)
            {
                label4.Text = Convert.ToString(numero + " es primo");
                label4.Visible = true;
            }
            else
            {
                label4.Text = Convert.ToString(numero + " no es primo");
                label4.Visible = true;
            }
        }

        private void txtNumberEn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

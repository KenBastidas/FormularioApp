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
    public partial class FrmSerieFactorial : Form
    {
        public FrmSerieFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int number = int.Parse(this.txtLimit.Text);
            long cad = TIC.utilidades.Serie(number);
            this.txtResultado.Text = cad.ToString();
        }
    }
}

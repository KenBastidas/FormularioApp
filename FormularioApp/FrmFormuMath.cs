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
    public partial class FrmFormuMath : Form
    {
        public FrmFormuMath()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtInicial.Text);
            int f = int.Parse(this.txtFinal.Text);
            double cad = Formula.FormulaMatematica.Formula(num, f);
            this.txtResultado.Text = cad.ToString();
        }
    }
}

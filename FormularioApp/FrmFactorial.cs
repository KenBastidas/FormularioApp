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
    public partial class FrmFactorial : Form
    {
        public FrmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int factorial = int.Parse(txtEntero.Text);
            facto(factorial);
            txtFacto.Text = facto(factorial).ToString();
        }
        public static double facto(int entero)
        {
            if (entero == 0 || entero == 1)
                return 1;
            return entero * facto(entero - 1);
        }
    }
}

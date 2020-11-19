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
    public partial class frmBinarioEnNumero : Form
    {
        public frmBinarioEnNumero()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double qui = 0;
            double sumar = 0; 
            if(chk1.Checked == true)
            {
                qui = Math.Pow(2, 0);
                sumar += qui;
            }
            if (chk2.Checked == true)
            {
                qui = Math.Pow(2, 1);
                sumar += qui;
            }
            if (chk3.Checked == true)
            {
                qui = Math.Pow(2, 2);
                sumar += qui;
            }
            if (chk4.Checked == true)
            {
                qui = Math.Pow(2, 3);
                sumar += qui;
            }
            if (chk5.Checked == true)
            {
                qui = Math.Pow(2, 4);
                sumar += qui;
            }
            if (chk6.Checked == true)
            {
                qui = Math.Pow(2, 5);
                sumar += qui;
            }
            if (chk7.Checked == true)
            {
                qui = Math.Pow(2, 6);
                sumar += qui;
            }
            if (chk8.Checked == true)
            {
                qui = Math.Pow(2, 7);
                sumar += qui;
            }
            txtBNumero.Text = sumar.ToString();
        }
    }
}

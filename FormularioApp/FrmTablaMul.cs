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
    public partial class FrmTablaMul : Form
    {
        public FrmTablaMul()
        {
            InitializeComponent();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int tablaMul = int.Parse(txtNumTabla.Text);
            int resul;

            for(int k=1; k<=12; k++)
            {
                resul = tablaMul * k;
                listBox1.Items.Add(tablaMul + " x " + k  + " = " + resul);
            }
        }
    }
}

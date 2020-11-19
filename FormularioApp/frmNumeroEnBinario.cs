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
    public partial class frmNumeroEnBinario : Form
    {
        public frmNumeroEnBinario()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            //todo: vlair que sean valores numericos

            //Validar que este en el rango de 0 as 255
            int num = Int32.Parse(this.txtNumero.Text);

            if(!(num>=0 && num<=255))
            {
                MessageBox.Show("Tu numerod ebe estar en el rango 0...255");
                this.txtNumero.Focus();
                return;
                  
            }
            encerar();
            numeroBinario(num);

        }//fin boton calcular

        void encerar()
        {
            //establevce todos lps cehck box en falos
            this.chk1.Checked = false;
            this.chk2.Checked = false;
            this.chk3.Checked = false;
            this.chk4.Checked = false;
            this.chk5.Checked = false;
            this.chk6.Checked = false;
            this.chk7.Checked = false;
            this.chk8.Checked = false;
        }

        void numeroBinario(int num)
        {
            //bulce4 para transformar el numero a binario
            int cont = 9;
            while (num > 0)
            {
                int residuo = num % 2;
                cont--;
                if (cont == 8)
                    this.chk8.Checked = residuo == 0 ? false : true;
                else if (cont == 7)
                    this.chk7.Checked = residuo == 0 ? false : true;
                else if (cont == 6)
                    this.chk6.Checked = residuo == 0 ? false : true;
                else if (cont == 5)
                    this.chk5.Checked = residuo == 0 ? false : true;
                else if (cont == 4)
                    this.chk4.Checked = residuo == 0 ? false : true;
                else if (cont == 3)
                    this.chk3.Checked = residuo == 0 ? false : true;
                else if (cont == 2)
                    this.chk2.Checked = residuo == 0 ? false : true;
                else if (cont == 1)
                    this.chk1.Checked = residuo == 0 ? false : true;

                num = num / 2;

            }//finde bucle while
        }
    }
}

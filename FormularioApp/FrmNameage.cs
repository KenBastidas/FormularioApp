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
    public partial class FrmNameage : Form
    {
        public FrmNameage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(txtEdad.Text, out double SoloNum))
            {
                MessageBox.Show("Ingrese valores numéricos en el cuadro edad....", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtEdad.Clear();
                this.txtEdad.Focus();
                return;
            }

            int edad = int.Parse(txtEdad.Text);
            
            if (!(edad >= 15 && edad <= 80))
            {
                MessageBox.Show(txtName.Text + ", Usted no se encuentra en el rango comprendido de edades entre 15-80 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (edad >= 15 && edad <= 17)
            {

                txtRespuesta.Text = txtName.Text + ", Eres menor de edad";
                txtRespuesta.Visible = true;
            }

            if (edad >= 18 && edad <= 25)
            {

                txtRespuesta.Text = txtName.Text + ", Puedes votar en las elecciones 2021";
                txtRespuesta.Visible = true;
            }

            if (edad >= 26 && edad <= 30)
            {

                txtRespuesta.Text = txtName.Text + ", Ya debes casarte";
                txtRespuesta.Visible = true;
            }

            if (edad >= 31 && edad <= 50)
            {

                txtRespuesta.Text = txtName.Text + ", Trabaja, duerme y disfruta";
                txtRespuesta.Visible = true;
            }

            if (edad > 50)
            {

                txtRespuesta.Text = txtName.Text + ", Ya casi llegas a la tercera edad";
                txtRespuesta.Visible = true;
            }

        }//end btnCalcular
    }
}

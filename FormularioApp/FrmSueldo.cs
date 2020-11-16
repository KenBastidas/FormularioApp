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
    public partial class FrmSueldo : Form
    {
        public FrmSueldo()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Validaciones
            if(this.txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el nombre...");
                this.txtNombre.Focus(); //ubica el cursor en el control
                return ; //abandonar
            }

            //Tarea:
            //1.Validar el ingreso de todos los cuadros de textos
            //2.validar que el dato ingresado sea numerico
            //no usar try...catch
            

            //sumar los ingresos
            double horasTrab = double.Parse(this.txtHorasTrab.Text);
            double valorHora = double.Parse(this.txtValorHora.Text);
            double bono = double.Parse(this.txtBono.Text);
            double totIng = horasTrab * valorHora + bono;

            //mostrar el totIng ewn el cuadro de texto
            this.txtTotalIng.Text = totIng.ToString();

            //suma los egresos
            double asoTrab = double.Parse(this.txtAsoTrab.Text);
            double bar = double.Parse(this.txtBar.Text);
            double cuentaxPagar = double.Parse(this.txtCuentaxPagar.Text);
            double totEgre = asoTrab + bar + cuentaxPagar;
            this.txtTotalEgresos.Text = totEgre.ToString();
            //liquido a  recibir
            double liquidoRecibir = totIng - totEgre;
            lblResultado.Text = "Estimado, " + this.txtNombre.Text +
                ", tu sueldo es: " + liquidoRecibir.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar el formulario actual
        }
    }
}

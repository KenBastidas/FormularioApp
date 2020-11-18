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

            if (this.txtHorasTrab.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar las horas trabajadas...");
                this.txtHorasTrab.Focus(); //ubica el cursor en el control
                return ; //abandonar
            }
            
            
            if(this.txtValorHora.Text.Length== 0)
            {
                MessageBox.Show("Por favor debes ingresar el Valor por hora...");
                this.txtValorHora.Focus(); //ubica el cursor en el control
                return ; //abandonar
            }
            
            if(this.txtBono.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el valor del bono...");
                this.txtBono.Focus(); //ubica el cursor en el control
                return ; //abandonar
            }

            
            if(this.txtAsoTrab.Text.Length== 0)
            {
                MessageBox.Show("Por favor debes ingresar el gatos de la asocicacion...");
                this.txtAsoTrab.Focus(); //ubica el cursor en el control
                return ; //abandonar
            }
            
            if(this.txtBar.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el gasto en el bar...");
                this.txtBar.Focus(); //ubica el cursor en el control
                return ; //abandonar
            }

            if (this.txtCuentaxPagar.Text.Length== 0)
            {
                MessageBox.Show("Por favor debes ingresar el valor de la cuenta por pagar...");
                this.txtCuentaxPagar.Focus(); //ubica el cursor en el control
                return; //abandonar
            }

                     
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

        //2.validar que el dato ingresado sea numerico
        //no usar try...catch

        private void txtHorasTrab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar <=47) || (e.KeyChar>= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtValorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtAsoTrab_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCuentaxPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Only numbers", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

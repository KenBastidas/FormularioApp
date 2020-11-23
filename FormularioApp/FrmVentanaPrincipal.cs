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
    public partial class FrmVentanaPrincipal : Form
    {
        public FrmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcularsueldo_Click(object sender, EventArgs e)
        {
            //Abir el formulario que calula el sueldo
            FrmSueldo frm1 = new FrmSueldo();
            frm1.Show();//mostrar fromualrio
        }

        private void btnEnteenBina_Click(object sender, EventArgs e)
        {
            frmNumeroEnBinario frm1 = new frmNumeroEnBinario();
            frm1.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBinaEnNum_Click(object sender, EventArgs e)
        {
            frmBinarioEnNumero frm1 = new frmBinarioEnNumero();
            frm1.Show();
        }
    }
}

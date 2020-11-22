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
    public partial class FrmDateTimeP : Form
    {
        public FrmDateTimeP()
        {
            InitializeComponent();
        }

        private void btnCalcularE_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Today;
            int AgeYears = fechaActual.Year - dateTimePicker1.Value.Year;
            int AgeDays  = ((fechaActual.Year - dateTimePicker1.Value.Year) * 365) + ((fechaActual.Month - dateTimePicker1.Value.Month) * 31)
                + fechaActual.Day - dateTimePicker1.Value.Day;
            txtyears.Text = AgeYears.ToString() + " Years old";
            txtDays.Text  = AgeDays.ToString() + " Days lived";
        }
    }
}

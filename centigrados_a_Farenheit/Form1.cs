using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace centigrados_a_Farenheit
{
    public partial class Form1 : Form
    {

        Conversion conversion = new Conversion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            conversion.setCentigrados(double.Parse(txtcentigrados.Text));
            lblresultado.Text = " Farenheit:  " + conversion.farenheit().ToString();
            lblresultado.Visible = true;
            txtcentigrados.Focus();
        }
    }
}

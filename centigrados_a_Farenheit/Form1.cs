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
            cmbtemperaturas.Text = "Seleccione..";
            cmbtemperaturas.Items.Add("Seleccione..");
            cmbtemperaturas.Items.Add("Fharenheit");
            cmbtemperaturas.Items.Add("Kelvin ");
            
           

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

          
            //conversion.setCentigrados(double.Parse(txtcentigrados.Text));
            //lblresultado.Text = " Farenheit:  " + conversion.farenheit().ToString();
            //lblresultado.Visible = true;
            //txtcentigrados.Focus();

            switch (cmbtemperaturas.SelectedIndex.ToString()){

                case "1":

                    conversion.setCentigrados(double.Parse(txtcentigrados.Text));
                    lblresultado.Text = " Farenheit:  " + conversion.farenheit().ToString();
                    lblresultado.Visible = true;
                    txtcentigrados.Focus();

                    break;

                case "2":
                    conversion.setCentigrados(double.Parse(txtcentigrados.Text));
                    lblresultado.Text = "Kelvin:  " + conversion.Kelvin().ToString();
                    lblresultado.Visible = true;
                    txtcentigrados.Focus();
                    break;

                default:

                    MessageBox.Show("Ingrese un Valor"
                        , "Mensaje de Advertencia"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);

                    break;


            }
        }
    }
}

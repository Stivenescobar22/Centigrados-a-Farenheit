using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace centigrados_a_Farenheit
{
   public class Conversion
   {
        private double centigrados;
        

        public void setCentigrados(double valor){

            this.centigrados = valor;
        }

        public double getCentigrados(){

            return this.centigrados;
        }


        public double farenheit(){

            return ((this.getCentigrados() * 9/5) + 32 );
        }

        public double Kelvin(){

            return (this.getCentigrados() + 273.15);

        }

       
        
    }
}

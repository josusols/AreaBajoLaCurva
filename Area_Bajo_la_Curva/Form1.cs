using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_Bajo_la_Curva
{
    public partial class AreaBajoCurva : Form
    {
        public AreaBajoCurva()
        {
            InitializeComponent();
        }

        string funcion;
        int limite1, limite2, n;
        decimal deltaX;

        private decimal fx(string fun, decimal xVar)
        {
            char[] separador = new char[5];
            separador[0] = '+';
            //separador[3] = '/';
            separador[1] = '^';
            separador[2] = 'x';
            separador[3] = '(';
            separador[4] = ')';
            string[] arreglo;

            arreglo = fun.Split(separador, StringSplitOptions.RemoveEmptyEntries);

            decimal resultado = 0;

            for (int i = 1; i < arreglo.Length; i+=2)
            {
                resultado += Convert.ToDecimal((Convert.ToDouble(arreglo[i-1]) * Math.Pow(Convert.ToDouble(xVar), Convert.ToDouble(arreglo[i]))));
            }

            return resultado;

        }


        public void sumIn()
        {
            decimal BaseI, xI, AlturaI;
            decimal totalI = 0;

            for (int i = 0; i < n; i++)
            {
                //Base.
                BaseI = deltaX;

                //Altura.
                xI = limite1 + (i * deltaX);
                AlturaI = fx(funcion, xI);

                //Area.
                totalI += (BaseI * AlturaI);

            }
            MessageBox.Show("La aproximacion del area bajo la curva usando sumas inferiores es: " + Convert.ToString(totalI) + ".");
        }

        public void sumSup()
        {
            decimal BaseI, xI, AlturaI;
            decimal totalI = 0;

            for (int i = 1; i < n; i++)
            {
                //Base.
                BaseI = deltaX;

                //Altura.
                xI = limite1 + (i * deltaX);
                AlturaI = fx(funcion, xI);

                //Area.
                totalI += (BaseI * AlturaI);

            }
            MessageBox.Show("La aproximacion del area bajo la curva usando sumas superiores es: " + Convert.ToString(totalI) + ".");
        }

        private void BTN_ok_Click(object sender, EventArgs e)
        {
            funcion = TB_funcion.Text;

            limite1 = Convert.ToInt32(TB_x1.Text);
            limite2 = Convert.ToInt32(TB_x2.Text);
            n = Convert.ToInt32(TB_n.Text);

            deltaX = (limite2 - limite1) / n;

            if (RB_sumasSuperiores.Checked == true)
            {
                sumSup();
            }
            else if (RB_sumasInferiores.Checked == true)
            {
                sumIn();   
            }
            else if (RB_ambas.Checked == true)
            {
                sumSup();
                sumIn();
            }
        }
    }
}

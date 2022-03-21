using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablaPeriodica
{
    public partial class Informacion : Form
    {
        public Informacion(string elemento)
        {
            InitializeComponent();
            seleccionTexto(elemento);
        }

        public void seleccionTexto(string elemento)
        {
            switch (elemento)
            {
                case "btnHidrogeno":
                    this.txtDescripcion.Text = "El hidrógeno se presenta normalmente en forma de gas y lo encontramos en las estrellas y en los planetas gaseosos. \n" +
                        "Se dice de él que es el combustible de las estrellas. De hecho, la razón por la que las estrellas brillan es porque están transformando grandes \n" +
                        "cantidades de hidrógeno en helio. Para que te hagas una idea, el Sol consume 600 millones de toneladas de hidrógeno por segundo. Gracias a ello, \n" +
                        "nosotros recibimos esa energía en forma de luz y calor.";
                    break;

                case "btnLitio":
                    this.txtDescripcion.Text = "Desde hace unos años, el litio se ha implementado en el desarrollo de varios productos que se han extendido en el uso cotidiano \n" +
                        "de la mayoría de las personas en el planeta. Su aplicación más común, según la  Real Sociedad de Química de Reino Unido , es en la fabricación de baterías\n" +
                        " para celulares, computadoras portátiles, cámaras digitales y vehículos eléctricos.";
                    break;

                default:
                    break;
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {

        }
    }
}

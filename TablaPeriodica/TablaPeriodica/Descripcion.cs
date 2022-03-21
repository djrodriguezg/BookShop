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
    public partial class Descripcion : Form
    {
        public Descripcion(string elemento)
        {
            InitializeComponent();
            llenarCuestionario(elemento);
        }

        public void llenarCuestionario(string elemento)
        {
            Font normal = new Font("Tahoma", 12, FontStyle.Regular);
            switch (elemento)
            {

                case "OtrosNoMetales":
                    this.textBox1.Text = "Entre los no metales, se incluyen el hidrógeno, el carbono, el nitrógeno, el fósforo, el oxígeno, el azufre, el selenio; los halógenos flúor, cloro, bromo y yodo y los elementos de gases nobles. El oxígeno y los otros elementos de este grupo constituyen una gran parte de la corteza terrestre. El hidrógeno, el oxígeno, el carbono y el nitrógeno son elementos que se encuentran en todos los organismos vivos.La mayoría de los átomos de los no metales son pequeños y cuentan con una gran cantidad de electrones por lo cual son bastante inertes y disponen de una mayor electronegatividad.\n\n" +
                        "Los no metales varían mucho en su apariencia, no son lustrosos y por lo general son malos conductores del calor y la electricidad. Sus puntos de fusión son más bajos que los de los metales (aunque el diamante, una forma de carbono, funde a 3570 ºC). Varios no metales existen en condiciones ordinarias como moléculas diatómicas.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.OtrosNoMetalesImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "Alcalinos":
                    this.textBox1.Text = "Los metales alcalinos conforman el grupo I de la tabla periódica. Su nombre hace referencia a las sustancias alcalinas que se forman cuando estos elementos reaccionan con el agua. Los elementos más comunes de este grupo son el sodio y el potasio. El rubidio, el litio y el cesio son más raros y constituyen, en orden de aparición, el 0,03, el 0,007 y el 0,0007 por ciento de la corteza terrestre." +
                                          "Estos elementos son altamente reactivos y generalmente están presentes en la naturaleza ya combinados con otros elementos.Tienen un brillo metálico, presentan alta ductilidad y son muy buenos conductores de electricidad y calor.Los metales alcalinos tienen puntos de fusión bajos, que varían entre 28,5 °C y 179 °C.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.AlcalinosImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "Alcalinoterreo":
                    this.textBox1.Text = "Los metales alcalinotérreos conforman el grupo 2 de la tabla periódica. A excepción del radio (el cual tiene algunos usos médicos limitados), todos los elementos de este grupo se utilizan ampliamente en aplicaciones comerciales. El magnesio y el calcio son dos de los seis elementos más comunes en la Tierra y son esenciales para algunos procesos geológicos y biológicos." +
                                          "Estos elementos son brillantes, con colores que van del blanco al gris.Son buenos conductores de electricidad y sus puntos de fusión y ebullición son mayores que los de los metales alcalinos. Los puntos de fusión varían entre 650 °C y 1287 °C y los puntos de ebullición varían entre 1090 °C y 2471 °C.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.AlcalinoterreosImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "MetalesTransicion":
                    this.textBox1.Text = "Un metal de transición lo define la Unión Internacional de Química Pura y Aplicada (IUPAC, por sus siglas en inglés) como un «elemento cuyo átomo tiene una subcapa “d” incompleta o que puede dar lugar a cationes con una subcapa “d” incompleta». Los metales de transición se encuentran en los grupos 4 al 11 de la tabla periódica; algunas veces se incluyen los elementos en los grupos 3 y 12. Al ser similares a los metales, los metales de transición son maleables y dúctiles, conducen calor y electricidad, y forman iones positivos.Sin embargo, estos elementos son más electronegativos y tienen más probabilidades de formar compuestos covalentes. Los metales de transición pueden formar aleaciones útiles con otros elementos de transición o metálicos.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.MetalesTransicionImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "OtrosMetales":
                    this.textBox1.Text = "Generalmente, se considera que los metales postransicionales (también llamados otros metales) son elementos que pertenecen a los grupos 13, 14 y 15. Todas las clasificaciones incluyen los elementos galio, indio, estaño, talio, plomo y bismuto. Sin embargo, en función de cómo se defina la «postransición», esta categoría puede incluir solo seis elementos o hasta 22.Los metales postransicionales comparten muchas características con los metales, incluida la maleabilidad, la ductilidad y la conductividad térmica y eléctrica, pero normalmente son más débiles y tienen puntos de fusión y de ebullición más bajos que los metales de transición.Tienen menor resistencia mecánica, forman enlacen covalentes y muestran propiedades anfóteras de ácido-base.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.OtrosMetalesImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "Lantanidos":
                    this.textBox1.Text = "Los lantánidos constituyen los 15 elementos químicos metálicos con números atómicos entre 57 y 71. Se denominan lantánidos porque su estructura química es similar a la del lantano. Estos elementos y los actínidos conforman la categoría más grande y se conocen como tierras raras. A pesar de la descripción de «tierras raras», estos elementos químicos son muy abundantes en la corteza terrestre. Por ejemplo, el cerio se posiciona en el lugar 25 de mayor abundancia. Los lantánidos se oxidan con rapidez en contacto con aire húmedo, se disuelven rápido en ácidos y reaccionan lentamente con el oxígeno a temperatura ambiente. Estos elementos se utilizan en superconductores y componentes de automóviles híbridos, principalmente imanes y baterías. También se utilizan en la fabricación de vidrios especiales.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.LatanidosImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "Actinidos":
                    this.textBox1.Text = "Los 15 elementos metálicos con números atómicos entre 89 y 104, desde el actinio al laurencio, se conocen como los actínidos. Todos estos elementos son radioactivos, relativamente inestables y emiten energía mediante la desintegración radioactiva. Sin embargo, pueden formar complejos estables con enlaces, como el cloruro, el sulfato, el carbonato y el acetato. La radioactividad, toxicidad, piroforicidad y criticidad nuclear que presentan los actínidos hacen que su manipulación sea peligrosa.El uranio y el plutonio se han empleado en plantas y armas atómicas.Algunos actínidos existen de manera natural en el agua de mar o en los minerales, pero los actínidos con números atómicos entre 95 y 104 son creados por el hombre mediante el uso de aceleradores de partículas.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.ActinidoImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "Metaloide":
                    this.textBox1.Text = "Los metaloides más reconocidos incluyen el boro, el silicio, el germanio, el arsénico, el antimonio y el telurio. Sus propiedades son una mezcla de, o son las mismas que, las que tienen los metales y los no metales. La cantidad de elementos incluidos en esta categoría puede variar. Los metaloides tienen un aspecto brillante como los metales, pero actúan más como los no metales. Tienen una buena conductividad eléctrica y estructuras frágiles. A nivel químico, cuentan con energías intermedias de ionización y valores de electronegatividad. Asimismo, forman óxidos anfotéricos o levemente ácidos. Los metaloides se utilizan en aleaciones, agentes biológicos, catalizadores, retardantes de llamas, vidrios, almacenamiento óptico, optoelectrónica, pirotecnia, semiconductores y electrónica.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.MetaloidesImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "Halogenos":
                    this.textBox1.Text = "Los halógenos son los elementos no metálicos que se encuentran en el grupo 17 de la tabla periódica. Entre estos se incluyen el flúor, el cloro, el bromo y el yodo. Son el único grupo cuyos elementos pueden presentar los estados sólido, líquido y gaseoso a temperatura ambiente. Cuando los halógenos reaccionan con los metales, producen una serie de sales útiles, como el fluoruro de calcio, el cloruro de sodio, el bromuro de plata y el yoduro de potasio. Ya que los halógenos necesitan un electrón más para completar sus niveles de configuración electrónica, pueden combinarse con varios elementos distintos. Son altamente reactivos y pueden ser mortales en cantidades concentradas. En el ámbito comercial, los halógenos se utilizan en desinfectantes, iluminación y medicamentos.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.HalogenosImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

                case "GasesNobles":
                    this.textBox1.Text = "Los gases nobles son miembros del grupo 18 en los seis primeros periodos de la tabla periódica. Son incoloros, inodoros, insípidos y no inflamables. En un principio se creía que sus átomos no podían unirse a otros elementos ni formar compuestos químicos, pero se ha demostrado lo contrario. Todos estos gases están presentes en la atmósfera y se considera que varios de ellos son muy abundantes en la Tierra. A excepción del helio y el radón, los gases nobles se pueden extraer del aire mediante el método de licuefacción y la destilación fraccionada. El helio se extrae de pozos de gas natural y el radón es un producto de desintegración radioactiva.";
                    this.textBox1.Font = normal;
                    this.btnInfo.BackgroundImage = global::TablaPeriodica.Properties.Resources.GasesNoblesImg; //this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                    break;

            }
        }
    }
}
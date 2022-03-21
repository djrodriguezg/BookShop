using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TablaPeriodica.Models;

namespace TablaPeriodica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario(button.Name);
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                switch (button.Name)
                {
                    case "btnHidrogeno": this.btnHidrogeno.BackgroundImage = global::TablaPeriodica.Properties.Resources.Hidrogeno; this.btnHidrogeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnLitio": this.btnLitio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Litio; this.btnLitio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnSodio": this.btnSodio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Sodio; this.btnSodio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPotasio": this.btnPotasio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Potasio; this.btnPotasio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnRubidio": this.btnRubidio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Rubidio; this.btnRubidio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCesio": this.btnCesio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cesio; this.btnCesio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnFrancio": this.btnFrancio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Francio; this.btnFrancio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnBerilio": this.btnBerilio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Berilio; this.btnBerilio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnMagnesio": this.btnMagnesio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Magnesio; this.btnMagnesio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCalcio": this.btnCalcio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Calcio; this.btnCalcio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnEstroncio": this.btnEstroncio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Estroncio; this.btnEstroncio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnBario": this.btnBario.BackgroundImage = global::TablaPeriodica.Properties.Resources.Bario; this.btnBario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnRadio": this.btnRadio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Radio; this.btnRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnEscandio": this.btnEscandio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Escandio; this.btnEscandio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnItrio": this.btnItrio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Itrio; this.btnItrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnLantanidos": this.btnLantanidos.BackgroundImage = global::TablaPeriodica.Properties.Resources.Lantanidos; this.btnLantanidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnActinidos": this.btnActinidos.BackgroundImage = global::TablaPeriodica.Properties.Resources.Actinidos; this.btnActinidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTitanio": this.btnTitanio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Titanio; this.btnTitanio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCirconio": this.btnCirconio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Circonio; this.btnCirconio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnHafnio": this.btnHafnio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Hafnio; this.btnHafnio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnRutherfordio": this.btnRutherfordio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Rutherfordio; this.btnRutherfordio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnLantano": this.btnLantano.BackgroundImage = global::TablaPeriodica.Properties.Resources.Lantano; this.btnLantano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnActinio": this.btnActinio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Actinio; this.btnActinio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnVanadio": this.btnVanadio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Vanadio; this.btnVanadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnNiobio": this.btnNiobio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Niobio; this.btnNiobio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTantalo": this.btnTantalo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Tantalo; this.btnTantalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnDubnio": this.btnDubnio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Dubnio; this.btnDubnio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCerio": this.btnCerio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cerio; this.btnCerio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTorio": this.btnTorio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Torio; this.btnTorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCromo": this.btnCromo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cromo; this.btnCromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnMolibdeno": this.btnMolibdeno.BackgroundImage = global::TablaPeriodica.Properties.Resources.Molibdeno; this.btnMolibdeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnWolframio": this.btnWolframio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Wolframio; this.btnWolframio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnSeaborgio": this.btnSeaborgio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Seaborgio; this.btnSeaborgio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPraseodimio": this.btnPraseodimio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Praseodimio; this.btnPraseodimio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnProtactinio": this.btnProtactinio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Protactinio; this.btnProtactinio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnManganesio": this.btnManganesio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Manganeso; this.btnManganesio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTecnecio": this.btnTecnecio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Tecnecio; this.btnTecnecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnRenio": this.btnRenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Renio; this.btnRenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnBohrio": this.btnBohrio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Bohrio; this.btnBohrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnNeodimio": this.btnNeodimio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Neodimio; this.btnNeodimio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnUranio": this.btnUranio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Uranio; this.btnUranio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnHierro": this.btnHierro.BackgroundImage = global::TablaPeriodica.Properties.Resources.Hierro; this.btnHierro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnRutenio": this.btnRutenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Rutenio; this.btnRutenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnOsmio": this.btnOsmio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Osmio; this.btnOsmio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnHasio": this.btnHasio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Hasio; this.btnHasio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPrometio": this.btnPrometio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Prometio; this.btnPrometio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnNeptunio": this.btnNeptunio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Neptunio; this.btnNeptunio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCobalto": this.btnCobalto.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cobalto; this.btnCobalto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnRodio": this.btnRodio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Rodio; this.btnRodio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnIridio": this.btnIridio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Iridio; this.btnIridio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnMeitnerio": this.btnMeitnerio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Meitnerio; this.btnMeitnerio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnSamario": this.btnSamario.BackgroundImage = global::TablaPeriodica.Properties.Resources.Samario; this.btnSamario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPlutonio": this.btnPlutonio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Plutonio; this.btnPlutonio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnNiquel": this.btnNiquel.BackgroundImage = global::TablaPeriodica.Properties.Resources.Niquel; this.btnNiquel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPaladio": this.btnPaladio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Paladio; this.btnPaladio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPlatino": this.btnPlatino.BackgroundImage = global::TablaPeriodica.Properties.Resources.Platino; this.btnPlatino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnDarmstatio": this.btnDarmstatio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Darmstatio; this.btnDarmstatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnEuropio": this.btnEuropio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Europio; this.btnEuropio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnAmericio": this.btnAmericio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Americio; this.btnAmericio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCobre": this.btnCobre.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cobre; this.btnCobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPlata": this.btnPlata.BackgroundImage = global::TablaPeriodica.Properties.Resources.Plata; this.btnPlata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnOro": this.btnOro.BackgroundImage = global::TablaPeriodica.Properties.Resources.Oro; this.btnOro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnRoentgenio": this.btnRoentgenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Roentgenio; this.btnRoentgenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnGadolinio": this.btnGadolinio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Gadolinio; this.btnGadolinio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCurio": this.btnCurio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Curio; this.btnCurio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnZinc": this.btnZinc.BackgroundImage = global::TablaPeriodica.Properties.Resources.Zinc; this.btnZinc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCadmio": this.btnCadmio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cadmio; this.btnCadmio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnMercurio": this.btnMercurio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Mercurio; this.btnMercurio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCopernicio": this.btnCopernicio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Copernicio; this.btnCopernicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTerbio": this.btnTerbio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Terbio; this.btnTerbio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnBerkelio": this.btnBerkelio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Berkelio; this.btnBerkelio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnBoro": this.btnBoro.BackgroundImage = global::TablaPeriodica.Properties.Resources.Boro; this.btnBoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnAluminio": this.btnAluminio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Aluminio; this.btnAluminio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnGalio": this.btnGalio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Galio; this.btnGalio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnIndio": this.btnIndio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Indio; this.btnIndio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTalio": this.btnTalio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Talio; this.btnTalio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnNihonio": this.btnNihonio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Nihonio; this.btnNihonio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnDisprosio": this.btnDisprosio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Disprosio; this.btnDisprosio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCalifornio": this.btnCalifornio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Californio; this.btnCalifornio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCarbono": this.btnCarbono.BackgroundImage = global::TablaPeriodica.Properties.Resources.Carbono; this.btnCarbono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnSilicio": this.btnSilicio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Silicio; this.btnSilicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnGermanio": this.btnGermanio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Germanio; this.btnGermanio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnEstaño": this.btnEstaño.BackgroundImage = global::TablaPeriodica.Properties.Resources.Estaño; this.btnEstaño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPlomo": this.btnPlomo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Plomo; this.btnPlomo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnFlerovio": this.btnFlerovio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Flerovio; this.btnFlerovio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnHolmio": this.btnHolmio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Holmio; this.btnHolmio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnEinstenio": this.btnEinstenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Einstenio; this.btnEinstenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnNitrogeno": this.btnNitrogeno.BackgroundImage = global::TablaPeriodica.Properties.Resources.Nitrogeno; this.btnNitrogeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnFosforo": this.btnFosforo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Fosforo; this.btnFosforo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnArsenico": this.btnArsenico.BackgroundImage = global::TablaPeriodica.Properties.Resources.Arsenico; this.btnArsenico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnAntimonio": this.btnAntimonio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Antimonio; this.btnAntimonio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnBismuto": this.btnBismuto.BackgroundImage = global::TablaPeriodica.Properties.Resources.Bismuto; this.btnBismuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnMoscovio": this.btnMoscovio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Moscovio; this.btnMoscovio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnErbio": this.btnErbio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Erbio; this.btnErbio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnFermio": this.btnFermio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Fermio; this.btnFermio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnOxigeno": this.btnOxigeno.BackgroundImage = global::TablaPeriodica.Properties.Resources.Oxigeno; this.btnOxigeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnAzufre": this.btnAzufre.BackgroundImage = global::TablaPeriodica.Properties.Resources.Azufre; this.btnAzufre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnSelenio": this.btnSelenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Selenio; this.btnSelenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTelurio": this.btnTelurio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Telurio; this.btnTelurio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnPolonio": this.btnPolonio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Polonio; this.btnPolonio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnLivermorio": this.btnLivermorio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Livermorio; this.btnLivermorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTulio": this.btnTulio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Tulio; this.btnTulio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnMendelevio": this.btnMendelevio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Mendelevio; this.btnMendelevio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnFluor": this.btnFluor.BackgroundImage = global::TablaPeriodica.Properties.Resources.Fluor; this.btnFluor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnCloro": this.btnCloro.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cloro; this.btnCloro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnBromo": this.btnBromo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Bromo; this.btnBromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnYodo": this.btnYodo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Yodo; this.btnYodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnAstato": this.btnAstato.BackgroundImage = global::TablaPeriodica.Properties.Resources.Astato; this.btnAstato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnTeneso": this.btnTeneso.BackgroundImage = global::TablaPeriodica.Properties.Resources.Teneso; this.btnTeneso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnIterbio": this.btnIterbio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Iterbio; this.btnIterbio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnNobelio": this.btnNobelio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Nobelio; this.btnNobelio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnHelio": this.btnHelio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Helio; this.btnHelio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnNeon": this.btnNeon.BackgroundImage = global::TablaPeriodica.Properties.Resources.Neon; this.btnNeon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnArgon": this.btnArgon.BackgroundImage = global::TablaPeriodica.Properties.Resources.Argon; this.btnArgon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnKripton": this.btnKripton.BackgroundImage = global::TablaPeriodica.Properties.Resources.Kripton; this.btnKripton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnXenon": this.btnXenon.BackgroundImage = global::TablaPeriodica.Properties.Resources.Xenon; this.btnXenon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnRadon": this.btnRadon.BackgroundImage = global::TablaPeriodica.Properties.Resources.Radon; this.btnRadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnOganeson": this.btnOganeson.BackgroundImage = global::TablaPeriodica.Properties.Resources.Oganeson; this.btnOganeson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnLutecio": this.btnLutecio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Lutecio; this.btnLutecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    case "btnLawrencio": this.btnLawrencio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Lawrencio; this.btnLawrencio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom; break;
                    default: break;
                }
                Respuesta.respuesta = false;
            }
        }

        private void btn_ClickOtrosNoMetales(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("OtrosNoMetales");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnHidrogeno.BackgroundImage = global::TablaPeriodica.Properties.Resources.Hidrogeno; this.btnHidrogeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCarbono.BackgroundImage = global::TablaPeriodica.Properties.Resources.Carbono; this.btnCarbono.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnNitrogeno.BackgroundImage = global::TablaPeriodica.Properties.Resources.Nitrogeno; this.btnNitrogeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnFosforo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Fosforo; this.btnFosforo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnOxigeno.BackgroundImage = global::TablaPeriodica.Properties.Resources.Oxigeno; this.btnOxigeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnAzufre.BackgroundImage = global::TablaPeriodica.Properties.Resources.Azufre; this.btnAzufre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnSelenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Selenio; this.btnSelenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("OtrosNoMetales");
                descripcion.ShowDialog();
                btnOtrosNoMetales.Enabled = true;
                this.btnHidrogeno.Enabled = false;
                this.btnCarbono.Enabled = false;
                this.btnFosforo.Enabled = false;
                this.btnNitrogeno.Enabled = false;
                this.btnOxigeno.Enabled = false;
                this.btnAzufre.Enabled = false;
                this.btnSelenio.Enabled = false;
            }
        }
        private void btn_ClickAlcalinos(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("Alcalinos");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnLitio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Litio; this.btnLitio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnSodio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Sodio; this.btnSodio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPotasio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Potasio; this.btnPotasio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnRubidio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Rubidio; this.btnRubidio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCesio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cesio; this.btnCesio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnFrancio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Francio; this.btnFrancio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("Alcalinos");
                descripcion.ShowDialog();
                btnAlcalinos.Enabled = true;
                this.btnLitio.Enabled = false;
                this.btnSodio.Enabled = false;
                this.btnPotasio.Enabled = false;
                this.btnRubidio.Enabled = false;
                this.btnCesio.Enabled = false;
                this.btnFrancio.Enabled = false;
            }
        }
        private void btn_ClickAlcalinoterreos(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("Alcalinoterreo");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnBerilio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Berilio; this.btnBerilio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnMagnesio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Magnesio; this.btnMagnesio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCalcio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Calcio; this.btnCalcio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnEstroncio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Estroncio; this.btnEstroncio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnBario.BackgroundImage = global::TablaPeriodica.Properties.Resources.Bario; this.btnBario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnRadio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Radio; this.btnRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("Alcalinoterreo");
                descripcion.ShowDialog();
                btnAlcalinoterreos.Enabled = true;
                this.btnBerilio.Enabled = false;
                this.btnMagnesio.Enabled = false;
                this.btnCalcio.Enabled = false;
                this.btnEstroncio.Enabled = false;
                this.btnBario.Enabled = false;
                this.btnRadio.Enabled = false;
            }
        }
        private void btn_ClickMetalesTransicion(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("MetalesTransicion");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnEscandio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Escandio; this.btnEscandio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnItrio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Itrio; this.btnItrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTitanio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Titanio; this.btnTitanio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCirconio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Circonio; this.btnCirconio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnHafnio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Hafnio; this.btnHafnio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnRutherfordio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Rutherfordio; this.btnRutherfordio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnVanadio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Vanadio; this.btnVanadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnNiobio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Niobio; this.btnNiobio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTantalo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Tantalo; this.btnTantalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnDubnio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Dubnio; this.btnDubnio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCromo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cromo; this.btnCromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnMolibdeno.BackgroundImage = global::TablaPeriodica.Properties.Resources.Molibdeno; this.btnMolibdeno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnWolframio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Wolframio; this.btnWolframio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnSeaborgio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Seaborgio; this.btnSeaborgio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnManganesio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Manganeso; this.btnManganesio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTecnecio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Tecnecio; this.btnTecnecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnRenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Renio; this.btnRenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnBohrio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Bohrio; this.btnBohrio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnHierro.BackgroundImage = global::TablaPeriodica.Properties.Resources.Hierro; this.btnHierro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnRutenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Rutenio; this.btnRutenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnOsmio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Osmio; this.btnOsmio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnHasio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Hasio; this.btnHasio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCobalto.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cobalto; this.btnCobalto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnRodio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Rodio; this.btnRodio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnIridio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Iridio; this.btnIridio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnMeitnerio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Meitnerio; this.btnMeitnerio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnNiquel.BackgroundImage = global::TablaPeriodica.Properties.Resources.Niquel; this.btnNiquel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPaladio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Paladio; this.btnPaladio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPlatino.BackgroundImage = global::TablaPeriodica.Properties.Resources.Platino; this.btnPlatino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnDarmstatio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Darmstatio; this.btnDarmstatio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCobre.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cobre; this.btnCobre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPlata.BackgroundImage = global::TablaPeriodica.Properties.Resources.Plata; this.btnPlata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnOro.BackgroundImage = global::TablaPeriodica.Properties.Resources.Oro; this.btnOro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnRoentgenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Roentgenio; this.btnRoentgenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnZinc.BackgroundImage = global::TablaPeriodica.Properties.Resources.Zinc; this.btnZinc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCadmio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cadmio; this.btnCadmio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnMercurio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Mercurio; this.btnMercurio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCopernicio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Copernicio; this.btnCopernicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;



                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("MetalesTransicion");
                descripcion.ShowDialog();
                btnMetalesTransicion.Enabled = true;
                this.btnEscandio.Enabled = false;
                this.btnItrio.Enabled = false;
                this.btnTitanio.Enabled = false;
                this.btnCirconio.Enabled = false;
                this.btnHafnio.Enabled = false;
                this.btnRutherfordio.Enabled = false;
                this.btnVanadio.Enabled = false;
                this.btnNiobio.Enabled = false;
                this.btnTantalo.Enabled = false;
                this.btnDubnio.Enabled = false;
                this.btnCromo.Enabled = false;
                this.btnMolibdeno.Enabled = false;
                this.btnWolframio.Enabled = false;
                this.btnSeaborgio.Enabled = false;
                this.btnManganesio.Enabled = false;
                this.btnTecnecio.Enabled = false;
                this.btnRenio.Enabled = false;
                this.btnBohrio.Enabled = false;
                this.btnHierro.Enabled = false;
                this.btnRutenio.Enabled = false;
                this.btnOsmio.Enabled = false;
                this.btnHasio.Enabled = false;
                this.btnCobalto.Enabled = false;
                this.btnRodio.Enabled = false;
                this.btnIridio.Enabled = false;
                this.btnMeitnerio.Enabled = false;
                this.btnNiquel.Enabled = false;
                this.btnPaladio.Enabled = false;
                this.btnPlatino.Enabled = false;
                this.btnDarmstatio.Enabled = false;
                this.btnCobre.Enabled = false;
                this.btnPlata.Enabled = false;
                this.btnOro.Enabled = false;
                this.btnRoentgenio.Enabled = false;
                this.btnZinc.Enabled = false;
                this.btnCadmio.Enabled = false;
                this.btnMercurio.Enabled = false;
                this.btnCopernicio.Enabled = false;

            }
        }
        private void btn_ClickOtrosMetales(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("OtrosMetales");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnAluminio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Aluminio; this.btnAluminio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnGalio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Galio; this.btnGalio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnIndio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Indio; this.btnIndio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTalio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Talio; this.btnTalio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnNihonio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Nihonio; this.btnNihonio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnEstaño.BackgroundImage = global::TablaPeriodica.Properties.Resources.Estaño; this.btnEstaño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPlomo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Plomo; this.btnPlomo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnFlerovio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Flerovio; this.btnFlerovio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnBismuto.BackgroundImage = global::TablaPeriodica.Properties.Resources.Bismuto; this.btnBismuto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnMoscovio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Moscovio; this.btnMoscovio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnLivermorio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Livermorio; this.btnLivermorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("OtrosMetales");
                descripcion.ShowDialog();
                btnOtrosMetales.Enabled = true;
                this.btnAluminio.Enabled = false;
                this.btnGalio.Enabled = false;
                this.btnIndio.Enabled = false;
                this.btnTalio.Enabled = false;
                this.btnNihonio.Enabled = false;
                this.btnEstaño.Enabled = false;
                this.btnPlomo.Enabled = false;
                this.btnFlerovio.Enabled = false;
                this.btnBismuto.Enabled = false;
                this.btnMoscovio.Enabled = false;
                this.btnLivermorio.Enabled = false;
            }
        }
        private void btn_ClickLantanidos(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("Lantanidos");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnLantanidos.BackgroundImage = global::TablaPeriodica.Properties.Resources.Lantanidos; this.btnLantanidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnLantano.BackgroundImage = global::TablaPeriodica.Properties.Resources.Lantano; this.btnLantano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCerio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cerio; this.btnCerio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPraseodimio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Praseodimio; this.btnPraseodimio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnNeodimio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Neodimio; this.btnNeodimio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPrometio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Prometio; this.btnPrometio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnSamario.BackgroundImage = global::TablaPeriodica.Properties.Resources.Samario; this.btnSamario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnEuropio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Europio; this.btnEuropio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnGadolinio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Gadolinio; this.btnGadolinio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTerbio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Terbio; this.btnTerbio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnDisprosio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Disprosio; this.btnDisprosio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnHolmio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Holmio; this.btnHolmio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnErbio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Erbio; this.btnErbio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTulio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Tulio; this.btnTulio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnIterbio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Iterbio; this.btnIterbio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnLutecio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Lutecio; this.btnLutecio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("Lantanidos");
                descripcion.ShowDialog();
                btnLantani.Enabled = true;
                this.btnLantanidos.Enabled = false;
                this.btnLantano.Enabled = false;
                this.btnCerio.Enabled = false;
                this.btnPraseodimio.Enabled = false;
                this.btnNeodimio.Enabled = false;
                this.btnPrometio.Enabled = false;
                this.btnSamario.Enabled = false;
                this.btnEuropio.Enabled = false;
                this.btnGadolinio.Enabled = false;
                this.btnTerbio.Enabled = false;
                this.btnDisprosio.Enabled = false;
                this.btnHolmio.Enabled = false;
                this.btnErbio.Enabled = false;
                this.btnTulio.Enabled = false;
                this.btnIterbio.Enabled = false;
                this.btnLutecio.Enabled = false;
            }
        }
        private void btn_ClickActinidos(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("Actinidos");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnActinidos.BackgroundImage = global::TablaPeriodica.Properties.Resources.Actinidos; this.btnActinidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnActinio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Actinio; this.btnActinio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTorio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Torio; this.btnTorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnProtactinio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Protactinio; this.btnProtactinio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnUranio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Uranio; this.btnUranio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnNeptunio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Neptunio; this.btnNeptunio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPlutonio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Plutonio; this.btnPlutonio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnAmericio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Americio; this.btnAmericio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCurio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Curio; this.btnCurio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnBerkelio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Berkelio; this.btnBerkelio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCalifornio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Californio; this.btnCalifornio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnEinstenio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Einstenio; this.btnEinstenio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnFermio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Fermio; this.btnFermio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnMendelevio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Mendelevio; this.btnMendelevio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnNobelio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Nobelio; this.btnNobelio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnLawrencio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Lawrencio; this.btnLawrencio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("Actinidos");
                descripcion.ShowDialog();
                btnActini.Enabled = true;
                this.btnActinidos.Enabled = false;
                this.btnActinio.Enabled = false;
                this.btnTorio.Enabled = false;
                this.btnProtactinio.Enabled = false;
                this.btnUranio.Enabled = false;
                this.btnNeptunio.Enabled = false;
                this.btnPlutonio.Enabled = false;
                this.btnAmericio.Enabled = false;
                this.btnCurio.Enabled = false;
                this.btnBerkelio.Enabled = false;
                this.btnCalifornio.Enabled = false;
                this.btnEinstenio.Enabled = false;
                this.btnFermio.Enabled = false;
                this.btnMendelevio.Enabled = false;
                this.btnNobelio.Enabled = false;
                this.btnLawrencio.Enabled = false;
            }
        }
        private void btn_ClickMetaloides(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("Metaloide");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnBoro.BackgroundImage = global::TablaPeriodica.Properties.Resources.Boro; this.btnBoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnSilicio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Silicio; this.btnSilicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnGermanio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Germanio; this.btnGermanio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnArsenico.BackgroundImage = global::TablaPeriodica.Properties.Resources.Arsenico; this.btnArsenico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnAntimonio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Antimonio; this.btnAntimonio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTelurio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Telurio; this.btnTelurio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnPolonio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Polonio; this.btnPolonio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("Metaloide");
                descripcion.ShowDialog();
                btnMetaloides.Enabled = true;
                this.btnBoro.Enabled = false;
                this.btnSilicio.Enabled = false;
                this.btnGermanio.Enabled = false;
                this.btnArsenico.Enabled = false;
                this.btnAntimonio.Enabled = false;
                this.btnTelurio.Enabled = false;
                this.btnPolonio.Enabled = false;
            }
        }
        private void btn_ClickHalogenos(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("Halogenos");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnFluor.BackgroundImage = global::TablaPeriodica.Properties.Resources.Fluor; this.btnFluor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnCloro.BackgroundImage = global::TablaPeriodica.Properties.Resources.Cloro; this.btnCloro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnBromo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Bromo; this.btnBromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnYodo.BackgroundImage = global::TablaPeriodica.Properties.Resources.Yodo; this.btnYodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnAstato.BackgroundImage = global::TablaPeriodica.Properties.Resources.Astato; this.btnAstato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnTeneso.BackgroundImage = global::TablaPeriodica.Properties.Resources.Teneso; this.btnTeneso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("Halogenos");
                descripcion.ShowDialog();
                btnHalogenos.Enabled = true;
                this.btnFluor.Enabled = false;
                this.btnCloro.Enabled = false;
                this.btnBromo.Enabled = false;
                this.btnYodo.Enabled = false;
                this.btnAstato.Enabled = false;
                this.btnTeneso.Enabled = false;
            }
        }
        private void btn_ClickGasesNobles(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //Form Info = new Informacion(button.Name);
            //Info.ShowDialog();
            Form cuestionario = new Cuestionario("GasesNobles");
            cuestionario.ShowDialog();
            if (Respuesta.respuesta)
            {
                this.btnHelio.BackgroundImage = global::TablaPeriodica.Properties.Resources.Helio; this.btnHelio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnNeon.BackgroundImage = global::TablaPeriodica.Properties.Resources.Neon; this.btnNeon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnArgon.BackgroundImage = global::TablaPeriodica.Properties.Resources.Argon; this.btnArgon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnKripton.BackgroundImage = global::TablaPeriodica.Properties.Resources.Kripton; this.btnKripton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnXenon.BackgroundImage = global::TablaPeriodica.Properties.Resources.Xenon; this.btnXenon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnRadon.BackgroundImage = global::TablaPeriodica.Properties.Resources.Radon; this.btnRadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                this.btnOganeson.BackgroundImage = global::TablaPeriodica.Properties.Resources.Oganeson; this.btnOganeson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;

                Respuesta.respuesta = false;
                Form descripcion = new Descripcion("GasesNobles");
                descripcion.ShowDialog();
                btnGasesNobles.Enabled = true;
                this.btnHelio.Enabled = false;
                this.btnNeon.Enabled = false;
                this.btnArgon.Enabled = false;
                this.btnKripton.Enabled = false;
                this.btnXenon.Enabled = false;
                this.btnRadon.Enabled = false;
                this.btnOganeson.Enabled = false;

            }
        }



        private void btnOtrosNoMetales_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("OtrosNoMetales");
            descripcion.ShowDialog();
        }
        private void btnAlcalinos_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("Alcalinos");
            descripcion.ShowDialog();
        }
        private void btnAlcalinoterreos_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("Alcalinoterreo");
            descripcion.ShowDialog();
        }
        private void btnMetalesTransicion_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("MetalesTransicion");
            descripcion.ShowDialog();
        }
        private void btnOtrosMetales_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("OtrosMetales");
            descripcion.ShowDialog();
        }
        private void btnLantani_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("Lantanidos");
            descripcion.ShowDialog();
        }
        private void btnActini_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("Actinidos");
            descripcion.ShowDialog();
        }
        private void btnMetaloide_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("Metaloide");
            descripcion.ShowDialog();
        }

        private void btnHalogenos_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("Halogenos");
            descripcion.ShowDialog();
        }
        private void btnGasesNobles_Click(object sender, EventArgs e)
        {
            Form descripcion = new Descripcion("GasesNobles");
            descripcion.ShowDialog();
        }

    }
}

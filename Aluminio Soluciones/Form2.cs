using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Aluminio_Soluciones
{
    public partial class Form2a : Form
    {
        List<int> PrecioAberturaGuardadas = new List<int>();
        List<int> PrecioPremarcosGuardados = new List<int>();
        public Form2a()
        {
            InitializeComponent();
            Diseño();
        }
        private string aberturaSeleccionada { get; set; }
        private string cantidadSeleccionada { get; set; }
        private string PorcentajeManoDeObra { get; set; }
        public object ListView1 { get; private set; }

        private class Perfiles
        {
            public double Perfil200 = 1.266;
            public double Perfil201 = 0.675;
            public double Perfil203 = 0.66;
            public double Perfil207 = 0.613;
            public double Perfil204 = 0.705;
            public double Perfil209 = 1.258;
            public double Perfil206 = 0.181;
            public double Perfil216 = 0.726;
            public double Perfil215 = 0.864;//hoja de abrir recta
            public double Perfil214 = 1.088;//parante puerta
            public double Perfil219 = 1.647; //zocalo puerta;
            public double Perfil241 = 0.975;//Parante marco guia triple
            public double Perfil240 = 1.823;//Guia triple
            public double Perfil235 = 0.902;//Hoja ventana
            public double Perfil230 = 0.213;//Contravidrio VS
            public double Perfil224 = 0.8;//Encuentro de puerta de dos hojas
            public double Perfil237 = 0.181;//Contravidrio obligatorio puerta
            public double Perfil218 = 1.150;//Travesaño puerta
            public double Perfil995 = 0.932;//Revestimiento tubular
        }
        private void cbxAberturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            aberturaSeleccionada = cbxAberturas.SelectedItem.ToString();
            switch (aberturaSeleccionada)
            {
                case "Puerta de abrir simple":
                case "Puerta de abrir doble":
                    checkTravesaños.Visible = true;
                    checkBoxCiega.Visible = true;
                    checkBoxMitadMitad.Visible = true;
                    labelPuerta.Visible = true;
                    panelPuerta.Visible = true;
                    break;
                default:
                    checkTravesaños.Visible = false;
                    checkBoxCiega.Visible = false;
                    checkBoxMitadMitad.Visible = false;
                    labelPuerta.Visible = false;
                    panelPuerta.Visible = false;
                    break;
            }
        }
        private void cbxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            cantidadSeleccionada = cbxCantidad.SelectedItem.ToString();
        }
        private void cbxManoDeObra_SelectedIndexChanged(object sender, EventArgs e)
        {
            PorcentajeManoDeObra = cbxManoDeObra.SelectedItem.ToString();
        }
        private void Diseño()
        {
            checkTravesaños.Visible = false;
            checkBoxCiega.Visible = false;
            checkBoxMitadMitad.Visible = false;
            txbPrecioPremarcos.Visible = false;
            label8Premarcos.Visible = false;
            listView2.Visible = false;
            labelPuerta.Visible = false;
            panelPuerta.Visible = false;
        }
        //Calculo de aberturas
        private void CalcularVentanaCorrediza()
        {
            try
            {
                string EntradaNombre = (txbNombre.Text);
            }
            catch (FormatException)
            {
                txbNombre.Text = Convert.ToString("");

            }
            try
            {
                int EntradaAncho = Convert.ToInt32(txbAncho.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida del ancho", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAncho.Text = Convert.ToString("0");



            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAccesorios.Text = Convert.ToString("0");
            }
            Perfiles perfilpeso = new Perfiles();
            double AnchoIn = Convert.ToDouble(txbAncho.Text);
            double AltoIn = Convert.ToDouble(txbAlto.Text);
            double AluminioIn = Convert.ToDouble(txbPrecioAluminio.Text);
            double AnchoInM = AnchoIn / 1000;
            double AltoInM = AltoIn / 1000;
            double final200 = (AnchoInM * perfilpeso.Perfil200) * 2;
            double final201 = (AltoInM * perfilpeso.Perfil201) * 2;
            double final203 = ((AltoInM - 0.08) * perfilpeso.Perfil203) * 2;
            double final207 = ((AltoInM - 0.08) * perfilpeso.Perfil207) * 2;
            double final204 = ((AnchoInM - 0.048) * perfilpeso.Perfil204) * 2;
            double totalPesoPerfiles = final200 + final201 + final203 + final204 + final207;
            int TotalAluminio = Convert.ToInt32(AluminioIn * totalPesoPerfiles);
            txbAluminioOut.Text = Convert.ToString(TotalAluminio);
            //vidrio
            int PrecioVidrioIn = Convert.ToInt32(txbPrecioVidrio.Text);
            double Perimetro = AnchoInM * AltoInM;
            int TotalVidrio = Convert.ToInt32(PrecioVidrioIn * Perimetro);
            txbVidrioOut.Text = Convert.ToString(TotalVidrio);
            //accesorios
            int AccesoriosIn = Convert.ToInt32(txbPrecioAccesorios.Text);
            txbAccesoriosOut.Text = Convert.ToString(AccesoriosIn);
            CalculoPorcentaje();//Metodo
            //Mano de obra
            int TotalManoDeObra = Convert.ToInt32(txbManodeobraout.Text);
            int AluminioConContra = Convert.ToInt32(txbAluminioOut.Text);
            int TotalAbertura = Convert.ToInt32(AluminioConContra + TotalVidrio + AccesoriosIn + TotalManoDeObra);
            totalAbertura.Text = Convert.ToString(TotalAbertura);
        }
        private void CalcularPuertaBalcon()
        {
            try
            {
                string EntradaNombre = (txbNombre.Text);
            }
            catch (FormatException)
            {
                txbNombre.Text = Convert.ToString("");
            }
            try
            {
                int EntradaAncho = Convert.ToInt32(txbAncho.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida del ancho", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida del alto", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAccesorios.Text = Convert.ToString("0");
            }
            Perfiles PerfilesPeso = new Perfiles();
            double AnchoIn = Convert.ToDouble(txbAncho.Text);
            double AltoIn = Convert.ToDouble(txbAlto.Text);
            double AluminioIn = Convert.ToDouble(txbPrecioAluminio.Text);
            double AnchoInM = AnchoIn / 1000;
            double AltoInM = AltoIn / 1000;
            double final200 = (AnchoInM * PerfilesPeso.Perfil200) * 2;
            double final201 = (AltoInM * PerfilesPeso.Perfil201) * 2;
            double final203 = ((AltoInM - 0.08) * PerfilesPeso.Perfil203) * 2;
            double final207 = ((AltoInM - 0.08) * PerfilesPeso.Perfil207) * 2;
            double final204 = ((AnchoInM / 2 - 0.024) * PerfilesPeso.Perfil204) * 2;
            double final209 = ((AnchoInM / 2 - 0.024) * PerfilesPeso.Perfil209) * 2;
            double totalPesoPerfiles = final200 + final201 + final203 + final204 + final207 + final209;
            int PesoPerfilMasAluminio = Convert.ToInt32(AluminioIn * totalPesoPerfiles);
            txbAluminioOut.Text = Convert.ToString(PesoPerfilMasAluminio);
            CalculoVidrios();//Metodo
            int TotalVidrio = Convert.ToInt32(txbVidrioOut.Text);
            //accesorios
            int AccesoriosIn = Convert.ToInt32(txbPrecioAccesorios.Text);
            txbAccesoriosOut.Text = Convert.ToString(AccesoriosIn);
            CalculoPorcentaje();//Metodo
            //Mano de obra
            int TotalManoDeObra = Convert.ToInt32(txbManodeobraout.Text);
            int AluminioConContra = Convert.ToInt32(txbAluminioOut.Text);
            int TotalAbertura = Convert.ToInt32(AluminioConContra + TotalVidrio + AccesoriosIn + TotalManoDeObra);
            totalAbertura.Text = Convert.ToString(TotalAbertura);
        }
        private void CalcularGuiaTriple()
        {
            try
            {
                string EntradaNombre = (txbNombre.Text);
            }
            catch (FormatException)
            {
                txbNombre.Text = Convert.ToString("");
            }
            try
            {
                int EntradaAncho = Convert.ToInt32(txbAncho.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida del ancho", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAccesorios.Text = Convert.ToString("0");
            }
            Perfiles PerfilesPeso = new Perfiles();
            double AnchoIn = Convert.ToDouble(txbAncho.Text);
            double AltoIn = Convert.ToDouble(txbAlto.Text);
            double AluminioIn = Convert.ToDouble(txbPrecioAluminio.Text);
            double AnchoInM = AnchoIn / 1000;
            double AltoInM = AltoIn / 1000;
            double final241 = (AnchoInM * 2) * PerfilesPeso.Perfil241;
            double final240 = (AltoInM * 2) * PerfilesPeso.Perfil240;
            double final203 = ((AltoInM - 0.08) * 2) * PerfilesPeso.Perfil203;
            double final207 = ((AltoInM - 0.08) * 2) * PerfilesPeso.Perfil207;
            double final204lat = ((AnchoInM / 3 - 0.007) * 2) * PerfilesPeso.Perfil204;
            double final204central = (AnchoInM / 3 ) * PerfilesPeso.Perfil204;
            double final209central = (AnchoInM / 3 ) * PerfilesPeso.Perfil209;
            double final209lat = ((AnchoInM / 3 ) * 2) * PerfilesPeso.Perfil209;
            double totalPesoPerfiles = final240 + final241 + final203 + final207 + final204lat + final204central + final209lat
                + final209central;
            int PesoPerfilMasAluminio = Convert.ToInt32(AluminioIn * totalPesoPerfiles);
            txbAluminioOut.Text = Convert.ToString(PesoPerfilMasAluminio);
            CalculoVidrios();//Metodo
            int TotalVidrio = Convert.ToInt32(txbVidrioOut.Text);
            //accesorios
            int AccesoriosIn = Convert.ToInt32(txbPrecioAccesorios.Text);
            txbAccesoriosOut.Text = Convert.ToString(AccesoriosIn);
            CalculoPorcentaje();//Metodo
                                //Mano de obra
            int TotalManoDeObra = Convert.ToInt32(txbManodeobraout.Text);
            int AluminioConContra = Convert.ToInt32(txbAluminioOut.Text);
            int TotalAbertura = Convert.ToInt32(AluminioConContra + TotalVidrio + AccesoriosIn + TotalManoDeObra);
            totalAbertura.Text = Convert.ToString(TotalAbertura);
        }
        private void CalcularVentanaRevatible()
        {
            try
            {
                string EntradaNombre = (txbNombre.Text);
            }
            catch (FormatException)
            {
                txbNombre.Text = Convert.ToString("");
            }
            try
            {
                int EntradaAncho = Convert.ToInt32(txbAncho.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida del ancho", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAccesorios.Text = Convert.ToString("0");
            }
            Perfiles PerfilesPeso = new Perfiles();
            double AnchoIn = Convert.ToDouble(txbAncho.Text);
            double AltoIn = Convert.ToDouble(txbAlto.Text);
            double AluminioIn = Convert.ToDouble(txbPrecioAluminio.Text);
            double AnchoInM = AnchoIn / 1000;
            double AltoInM = AltoIn / 1000;
            double final216 = ((AnchoInM + AltoInM) * 2) * PerfilesPeso.Perfil216;
            double final235 = ((AnchoInM + AltoInM) * 2) * PerfilesPeso.Perfil235;
            double final230 = ((AnchoInM + AltoInM) * 2) * PerfilesPeso.Perfil230;
            double totalPesoPerfiles = final216 + final235 + final230;
            int PesoPerfilMasAluminio = Convert.ToInt32(AluminioIn * totalPesoPerfiles);
            txbAluminioOut.Text = Convert.ToString(PesoPerfilMasAluminio);
            CalculoVidrios();//Metodo
            int TotalVidrio = Convert.ToInt32(txbVidrioOut.Text);
            txbVidrioOut.Text = Convert.ToString(TotalVidrio);
            //accesorios
            int AccesoriosIn = Convert.ToInt32(txbPrecioAccesorios.Text);
            txbAccesoriosOut.Text = Convert.ToString(AccesoriosIn);
            CalculoPorcentaje();//Metodo
                                //Mano de obra
            int TotalManoDeObra = Convert.ToInt32(txbManodeobraout.Text);
            int AluminioConContra = Convert.ToInt32(txbAluminioOut.Text);
            int TotalAbertura = Convert.ToInt32(AluminioConContra + TotalVidrio + AccesoriosIn + TotalManoDeObra);
            totalAbertura.Text = Convert.ToString(TotalAbertura);

        }
        private void CalcularPuertaDeAbrirSimple()
        {
            try
            {
                string EntradaNombre = (txbNombre.Text);
            }
            catch (FormatException)
            {
                txbNombre.Text = Convert.ToString("");
            }
            try
            {
                int EntradaAncho = Convert.ToInt32(txbAncho.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida del ancho", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAccesorios.Text = Convert.ToString("0");
            }
            Perfiles PerfilesPeso = new Perfiles();
            double AnchoIn = Convert.ToDouble(txbAncho.Text);
            double AltoIn = Convert.ToDouble(txbAlto.Text);
            double AluminioIn = Convert.ToDouble(txbPrecioAluminio.Text);
            double AnchoInM = AnchoIn / 1000;
            double AltoInM = AltoIn / 1000;
            double perfil216final = ((AltoInM * 2) + AnchoInM) * PerfilesPeso.Perfil216;
            double perfil214final = ((AltoInM * 2) + AnchoInM) * PerfilesPeso.Perfil214;
            double perfil219final = AnchoInM * PerfilesPeso.Perfil219;
            double perfil230final = ((AnchoInM * 2) + (AltoInM * 2)) * PerfilesPeso.Perfil230;
            double perfil237final = ((AnchoInM * 2) + (AltoInM * 2)) * PerfilesPeso.Perfil237;
            double totalPesoPerfiles = perfil216final + perfil214final + perfil219final + perfil230final + perfil237final;
            int PesoPerfilMasAluminio = Convert.ToInt32(AluminioIn * totalPesoPerfiles);
            CalculoVidrios();
            CalculoTravesañosCiegaMitad();
            int travesañoPrecio = Convert.ToInt32(txbTravesaño.Text);
            int revestimientoPrecio = Convert.ToInt32(txbCiega.Text);
            txbAluminioOut.Text = Convert.ToString(PesoPerfilMasAluminio + travesañoPrecio + revestimientoPrecio);
            //Vidrio
            int TotalVidrio = Convert.ToInt32(txbVidrioOut.Text);
            //accesorios
            int AccesoriosIn = Convert.ToInt32(txbPrecioAccesorios.Text);
            txbAccesoriosOut.Text = Convert.ToString(AccesoriosIn);
            CalculoPorcentaje();//Metodo
            //Mano de obra
            int TotalManoDeObra = Convert.ToInt32(txbManodeobraout.Text);
            int AluminioConContra = Convert.ToInt32(txbAluminioOut.Text);
            int TotalAbertura = Convert.ToInt32(AluminioConContra + TotalVidrio + AccesoriosIn + TotalManoDeObra);
            totalAbertura.Text = Convert.ToString(TotalAbertura);
        }
        private void CalcularPuertaDeAbrirDoble()
        {
            try
            {
                string EntradaNombre = (txbNombre.Text);
            }
            catch (FormatException)
            {
                txbNombre.Text = Convert.ToString("");
            }
            try
            {
                int EntradaAncho = Convert.ToInt32(txbAncho.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida del ancho", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAccesorios.Text = Convert.ToString("0");
            }
            Perfiles PerfilesPeso = new Perfiles();
            double AnchoIn = Convert.ToDouble(txbAncho.Text);
            double AltoIn = Convert.ToDouble(txbAlto.Text);
            double AluminioIn = Convert.ToDouble(txbPrecioAluminio.Text);
            double AnchoInM = AnchoIn / 1000;
            double AltoInM = AltoIn / 1000;
            double final216 = ((AltoInM * 2) + AnchoInM) * PerfilesPeso.Perfil216;
            double final214 = ((AltoInM * 4) + AnchoInM) * PerfilesPeso.Perfil214;
            double final219 = AnchoInM * PerfilesPeso.Perfil219;
            double final224 = AltoInM * PerfilesPeso.Perfil224;
            double final230 = ((AnchoInM * 2) + (AltoInM * 4)) * PerfilesPeso.Perfil230;
            double final237 = ((AnchoInM * 2) + (AltoInM * 4)) * PerfilesPeso.Perfil237;
            double totalPesoPerfiles = final216 + final214 + final219 + final224 + final230 + final237;
            int PesoPerfilMasAluminio = Convert.ToInt32(AluminioIn * totalPesoPerfiles);
            CalculoVidrios();//Metodo
            CalculoTravesañosCiegaMitad();
            int travesañoPrecio = Convert.ToInt32(txbTravesaño.Text);
            int revestimientoPrecio = Convert.ToInt32(txbCiega.Text);
            txbAluminioOut.Text = Convert.ToString(PesoPerfilMasAluminio + revestimientoPrecio + travesañoPrecio);
            //vidrio
            int TotalVidrio = Convert.ToInt32(txbVidrioOut.Text);
            //accesorios
            int AccesoriosIn = Convert.ToInt32(txbPrecioAccesorios.Text);
            txbAccesoriosOut.Text = Convert.ToString(AccesoriosIn);
            CalculoPorcentaje();//Metodo
            //Mano de obra
            int TotalManoDeObra = Convert.ToInt32(txbManodeobraout.Text);
            int AluminioConContra = Convert.ToInt32(txbAluminioOut.Text);
            int TotalAbertura = Convert.ToInt32(AluminioConContra + TotalVidrio + AccesoriosIn + TotalManoDeObra);
            totalAbertura.Text = Convert.ToString(TotalAbertura);
        }
        private void CalcularPañoFijo()
        {
            try
            {
                string EntradaNombre = (txbNombre.Text);
            }
            catch (FormatException)
            {
                txbNombre.Text = Convert.ToString("");
            }
            try
            {
                int EntradaAncho = Convert.ToInt32(txbAncho.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida del ancho", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPrecioAccesorios.Text = Convert.ToString("0");
            }
            Perfiles PerfilesPeso = new Perfiles();
            double AnchoIn = Convert.ToDouble(txbAncho.Text);
            double AltoIn = Convert.ToDouble(txbAlto.Text);
            double AluminioIn = Convert.ToDouble(txbPrecioAluminio.Text);
            double AnchoInM = AnchoIn / 1000;
            double AltoInM = AltoIn / 1000;
            double final216 = ((AnchoInM * 2) + (AltoInM * 2)) * PerfilesPeso.Perfil216;
            double final230 = ((AnchoInM * 2) + (AltoInM * 2)) * PerfilesPeso.Perfil230;
            double totalPesoPerfiles = final216 + final230;
            int PesoPerfilMasAluminio = Convert.ToInt32(AluminioIn * totalPesoPerfiles);
            txbAluminioOut.Text = Convert.ToString(PesoPerfilMasAluminio);
            CalculoVidrios();//Metodo
            int TotalVidrio = Convert.ToInt32(txbVidrioOut.Text);
            //accesorios
            int AccesoriosIn = Convert.ToInt32(txbPrecioAccesorios.Text);
            txbAccesoriosOut.Text = Convert.ToString(AccesoriosIn);
            CalculoPorcentaje();//Metodo
            //Mano de obra
            int TotalManoDeObra = Convert.ToInt32(txbManodeobraout.Text);
            int AluminioConContra = Convert.ToInt32(txbAluminioOut.Text);
            int TotalAbertura = Convert.ToInt32(AluminioConContra + TotalVidrio + AccesoriosIn + TotalManoDeObra);
            totalAbertura.Text = Convert.ToString(TotalAbertura);

        }
        //Calculos adicionales
        private void CalculoPorcentaje()
        {
            switch (PorcentajeManoDeObra)
            {
                case "40%":
                    if (checkContramarcos.Checked == true)
                    {
                        switch (aberturaSeleccionada)
                        {
                            case "Ventana corrediza":
                            case "Ventana rebatible":
                            case "Ventana dezplazable":
                            case "Ventana banderola":
                            case "Paño fijo":
                                CalculoContramarcosVentanas();
                                int AluminioParaManoDeObra = Convert.ToInt32(txbAluminioOut.Text);
                                int VidrioParaManoDeObra = Convert.ToInt32(txbVidrioOut.Text);
                                int AccesoriosParaManoDeObra = Convert.ToInt32(txbAccesoriosOut.Text);
                                int TotalParaCalcularPorcentaje = Convert.ToInt32(AluminioParaManoDeObra + VidrioParaManoDeObra
                                    + AccesoriosParaManoDeObra);
                                double Porcentaje40 = (TotalParaCalcularPorcentaje * 40) / 100;
                                txbManodeobraout.Text = Convert.ToString(Porcentaje40);
                                break;
                            case "Puerta balcon":
                            case "Guia triple":
                            case "Puerta de abrir simple":
                            case "Puerta de abrir doble":
                                CalculoContramarcoBalcon();
                                int AluminioParaManoDeObra2 = Convert.ToInt32(txbAluminioOut.Text);
                                int VidrioParaManoDeObra2 = Convert.ToInt32(txbVidrioOut.Text);
                                int AccesoriosParaManoDeObra2 = Convert.ToInt32(txbAccesoriosOut.Text);
                                int TotalParaCalcularPorcentaje2 = Convert.ToInt32(AluminioParaManoDeObra2 + VidrioParaManoDeObra2
                                    + AccesoriosParaManoDeObra2);
                                double Porcentaje402 = (TotalParaCalcularPorcentaje2 * 40) / 100;
                                txbManodeobraout.Text = Convert.ToString(Porcentaje402);
                                break;
                        }
                    }
                    else
                    {
                        int AluminioParaManoDeObra = Convert.ToInt32(txbAluminioOut.Text);
                        int VidrioParaManoDeObra = Convert.ToInt32(txbVidrioOut.Text);
                        int AccesoriosParaManoDeObra = Convert.ToInt32(txbAccesoriosOut.Text);
                        int TotalParaCalcularPorcentaje = Convert.ToInt32(AluminioParaManoDeObra + VidrioParaManoDeObra
                            + AccesoriosParaManoDeObra);
                        double Porcentaje40 = (TotalParaCalcularPorcentaje * 40) / 100;
                        txbManodeobraout.Text = Convert.ToString(Porcentaje40);
                    }
                    break;
                case "50%":
                    if (checkContramarcos.Checked == true)
                    {
                        switch (aberturaSeleccionada)
                        {
                            case "Ventana corrediza":
                            case "Ventana rebatible":
                            case "Ventana dezplazable":
                            case "Ventana banderola":
                            case "Paño fijo":
                                CalculoContramarcosVentanas();
                                int AluminioParaManoDeObra50 = Convert.ToInt32(txbAluminioOut.Text);
                                int VidrioParaManoDeObra50 = Convert.ToInt32(txbVidrioOut.Text);
                                int AccesoriosParaManoDeObra50 = Convert.ToInt32(txbAccesoriosOut.Text);
                                int TotalParaCalcularPorcentaje50 = Convert.ToInt32(AluminioParaManoDeObra50 + VidrioParaManoDeObra50
                                    + AccesoriosParaManoDeObra50);
                                double Porcentaje50 = (TotalParaCalcularPorcentaje50 * 50) / 100;
                                txbManodeobraout.Text = Convert.ToString(Porcentaje50);
                                break;
                            case "Puerta balcon":
                            case "Guia triple":
                            case "Puerta de abrir simple":
                            case "Puerta de abrir doble":
                                CalculoContramarcoBalcon();
                                int AluminioParaManoDeObra2 = Convert.ToInt32(txbAluminioOut.Text);
                                int VidrioParaManoDeObra2 = Convert.ToInt32(txbVidrioOut.Text);
                                int AccesoriosParaManoDeObra2 = Convert.ToInt32(txbAccesoriosOut.Text);
                                int TotalParaCalcularPorcentaje2 = Convert.ToInt32(AluminioParaManoDeObra2 + VidrioParaManoDeObra2
                                    + AccesoriosParaManoDeObra2);
                                double Porcentaje402 = (TotalParaCalcularPorcentaje2 * 50) / 100;
                                txbManodeobraout.Text = Convert.ToString(Porcentaje402);
                                break;
                        }
                    }
                    else
                    {
                        int AluminioParaManoDeObra50 = Convert.ToInt32(txbAluminioOut.Text);
                        int VidrioParaManoDeObra50 = Convert.ToInt32(txbVidrioOut.Text);
                        int AccesoriosParaManoDeObra50 = Convert.ToInt32(txbAccesoriosOut.Text);
                        int TotalParaCalcularPorcentaje50 = Convert.ToInt32(AluminioParaManoDeObra50 + VidrioParaManoDeObra50
                            + AccesoriosParaManoDeObra50);
                        double Porcentaje50 = (TotalParaCalcularPorcentaje50 * 50) / 100;
                        txbManodeobraout.Text = Convert.ToString(Porcentaje50);
                    }
                    break;
                case "60%":
                    if (checkContramarcos.Checked == true)
                    {
                        switch (aberturaSeleccionada)
                        {
                            case "Ventana corrediza":
                            case "Ventana rebatible":
                            case "Ventana dezplazable":
                            case "Ventana banderola":
                            case "Paño fijo":
                                CalculoContramarcosVentanas();
                                int AluminioParaManoDeObra50 = Convert.ToInt32(txbAluminioOut.Text);
                                int VidrioParaManoDeObra50 = Convert.ToInt32(txbVidrioOut.Text);
                                int AccesoriosParaManoDeObra50 = Convert.ToInt32(txbAccesoriosOut.Text);
                                int TotalParaCalcularPorcentaje50 = Convert.ToInt32(AluminioParaManoDeObra50 + VidrioParaManoDeObra50
                                    + AccesoriosParaManoDeObra50);
                                double Porcentaje50 = (TotalParaCalcularPorcentaje50 * 60) / 100;
                                txbManodeobraout.Text = Convert.ToString(Porcentaje50);
                                break;
                            case "Puerta balcon":
                            case "Guia triple":
                            case "Puerta de abrir simple":
                            case "Puerta de abrir doble":
                                CalculoContramarcoBalcon();
                                int AluminioParaManoDeObra2 = Convert.ToInt32(txbAluminioOut.Text);
                                int VidrioParaManoDeObra2 = Convert.ToInt32(txbVidrioOut.Text);
                                int AccesoriosParaManoDeObra2 = Convert.ToInt32(txbAccesoriosOut.Text);
                                int TotalParaCalcularPorcentaje2 = Convert.ToInt32(AluminioParaManoDeObra2 + VidrioParaManoDeObra2
                                    + AccesoriosParaManoDeObra2);
                                double Porcentaje402 = (TotalParaCalcularPorcentaje2 * 60) / 100;
                                txbManodeobraout.Text = Convert.ToString(Porcentaje402);
                                break;
                        }
                    }
                    else
                    {
                        int AluminioParaManoDeObra60 = Convert.ToInt32(txbAluminioOut.Text);
                        int VidrioParaManoDeObra60 = Convert.ToInt32(txbVidrioOut.Text);
                        int AccesoriosParaManoDeObra60 = Convert.ToInt32(txbAccesoriosOut.Text);
                        int TotalParaCalcularPorcentaje60 = Convert.ToInt32(AluminioParaManoDeObra60 + VidrioParaManoDeObra60
                            + AccesoriosParaManoDeObra60);
                        double Porcentaje60 = (TotalParaCalcularPorcentaje60 * 60) / 100;
                        txbManodeobraout.Text = Convert.ToString(Porcentaje60);
                    }
                    break;
                default:
                    if (checkContramarcos.Checked == true)
                    {
                        switch (aberturaSeleccionada)
                        {
                            case "Ventana corrediza":
                            case "Ventana rebatible":
                            case "Ventana dezplazable":
                            case "Ventana banderola":
                            case "Paño fijo":
                                CalculoContramarcosVentanas();
                                int AluminioParaManoDeObra50 = Convert.ToInt32(txbAluminioOut.Text);
                                int VidrioParaManoDeObra50 = Convert.ToInt32(txbVidrioOut.Text);
                                int AccesoriosParaManoDeObra50 = Convert.ToInt32(txbAccesoriosOut.Text);
                                int TotalParaCalcularPorcentaje50 = Convert.ToInt32(AluminioParaManoDeObra50 + VidrioParaManoDeObra50
                                    + AccesoriosParaManoDeObra50);
                                double Porcentaje50 = (TotalParaCalcularPorcentaje50 * 70) / 100;
                                txbManodeobraout.Text = Convert.ToString(Porcentaje50);
                                break;
                            case "Puerta balcon":
                            case "Guia triple":
                            case "Puerta de abrir simple":
                            case "Puerta de abrir doble":
                                CalculoContramarcoBalcon();
                                int AluminioParaManoDeObra2 = Convert.ToInt32(txbAluminioOut.Text);
                                int VidrioParaManoDeObra2 = Convert.ToInt32(txbVidrioOut.Text);
                                int AccesoriosParaManoDeObra2 = Convert.ToInt32(txbAccesoriosOut.Text);
                                int TotalParaCalcularPorcentaje2 = Convert.ToInt32(AluminioParaManoDeObra2 + VidrioParaManoDeObra2
                                    + AccesoriosParaManoDeObra2);
                                double Porcentaje402 = (TotalParaCalcularPorcentaje2 * 70) / 100;
                                txbManodeobraout.Text = Convert.ToString(Porcentaje402);
                                break;
                        }
                    }
                    else
                    {
                        int AluminioParaManoDeObra70 = Convert.ToInt32(txbAluminioOut.Text);
                        int VidrioParaManoDeObra70 = Convert.ToInt32(txbVidrioOut.Text);
                        int AccesoriosParaManoDeObra70 = Convert.ToInt32(txbAccesoriosOut.Text);
                        int TotalParaCalcularPorcentaje70 = Convert.ToInt32(AluminioParaManoDeObra70 + VidrioParaManoDeObra70
                            + AccesoriosParaManoDeObra70);
                        double Porcentaje70 = (TotalParaCalcularPorcentaje70 * 70) / 100;
                        txbManodeobraout.Text = Convert.ToString(Porcentaje70);
                    }
                    break;
            }

        }
        private void CalculoContramarcosVentanas()
        {
            double ancho = Convert.ToDouble(txbAncho.Text);
            double alto = Convert.ToDouble(txbAlto.Text);
            double anchoD = ancho / 1000;
            double altoD = alto / 1000;
            double calculoContramarcoPerimetral = ((anchoD * 2) + (altoD * 2)) * 0.181;
            int PrecioAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            int calculo = Convert.ToInt32(calculoContramarcoPerimetral * PrecioAluminio);
            int TotalAluminio = Convert.ToInt32(txbAluminioOut.Text);
            txbAluminioOut.Text = Convert.ToString(calculo + TotalAluminio);
        }
        private void CalculoContramarcoBalcon()
        {
            double ancho = Convert.ToDouble(txbAncho.Text);
            double alto = Convert.ToDouble(txbAlto.Text);
            double anchoD = ancho / 1000;
            double altoD = alto / 1000;
            double calculoContramarcoPerimetral = ((altoD * 2) + anchoD) * 0.181;
            int PrecioAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            int calculo = Convert.ToInt32(calculoContramarcoPerimetral * PrecioAluminio);
            int TotalAluminio = Convert.ToInt32(txbAluminioOut.Text);
            txbAluminioOut.Text = Convert.ToString(calculo + TotalAluminio);
        }
        private void CalculoVidrios()
        {
            double AnchoIn = Convert.ToDouble(txbAncho.Text);
            double AltoIn = Convert.ToDouble(txbAlto.Text);
            double AnchoInM = AnchoIn / 1000;
            double AltoInM = AltoIn / 1000;
            int PrecioVidrioIn = Convert.ToInt32(txbPrecioVidrio.Text);
            double Perimetro = AnchoInM * AltoInM;
            int TotalVidrio = Convert.ToInt32(PrecioVidrioIn * Perimetro);
            txbVidrioOut.Text = Convert.ToString(TotalVidrio);

        }
        private void CalculoTravesañosCiegaMitad()
        {
            if (checkTravesaños.Checked == true)
            {
                Perfiles PerfilesPeso = new Perfiles();
                double AnchoIn = Convert.ToDouble(txbAncho.Text);
                double AluminioIn = Convert.ToDouble(txbPrecioAluminio.Text);
                double AnchoInM = AnchoIn / 1000;
                double precioTravesaño = (AnchoInM * PerfilesPeso.Perfil218) * AluminioIn;
                int precioTravesaño1 = Convert.ToInt32(precioTravesaño);
                txbTravesaño.Text = Convert.ToString(precioTravesaño1);
            }
            else
            {
                int cero = 0;
                txbTravesaño.Text = Convert.ToString(cero);
            }
            if (checkBoxCiega.Checked == true)
            {
                Perfiles PerfilesPeso = new Perfiles();
                double AnchoIn = Convert.ToDouble(txbAncho.Text);
                double AltoIn = Convert.ToDouble(txbAlto.Text);
                int AluminioIn = Convert.ToInt32(txbPrecioAluminio.Text);
                double AnchoInM = AnchoIn / 1000;
                
                double CantidadDePedazos = Convert.ToInt32(AltoIn / 110);
                double TotalLineal = CantidadDePedazos * AnchoInM;
                double precioXkilo = AluminioIn * PerfilesPeso.Perfil995;
                int precioFinalRevestimiento = Convert.ToInt32(TotalLineal * precioXkilo);
                txbCiega.Text = Convert.ToString(precioFinalRevestimiento);
                int vidrioCero = 0;
                txbVidrioOut.Text = Convert.ToString(vidrioCero);
            }
            else
            {
                int cero = 0;
                txbCiega.Text = Convert.ToString(cero);
            }
            if (checkBoxMitadMitad.Checked == true)
            {
                Perfiles PerfilesPeso = new Perfiles();
                double AnchoIn = Convert.ToDouble(txbAncho.Text);
                double AltoIn = Convert.ToDouble(txbAlto.Text);
                int AluminioIn = Convert.ToInt32(txbPrecioAluminio.Text);
                double AnchoInM = AnchoIn / 1000;
                double AltoInM = AltoIn / 1000;
                double Perimetro = AnchoInM * AltoInM;
                int vidrioIn = Convert.ToInt32(txbPrecioVidrio.Text);
                int VidrioMitad = Convert.ToInt32(Perimetro * vidrioIn) / 2;
                txbVidrioOut.Text = Convert.ToString(VidrioMitad);
                double precioTravesaño = (AnchoInM * PerfilesPeso.Perfil218) * AluminioIn;
                int precioTravesaño1 = Convert.ToInt32(precioTravesaño);
                txbTravesaño.Text = Convert.ToString(precioTravesaño1);
                double CantidadDePedazos = Convert.ToInt32(AltoIn / 110);
                double TotalLineal = CantidadDePedazos * AnchoInM;
                double precioXkilo = AluminioIn * PerfilesPeso.Perfil995;
                int precioFinalRevestimiento = Convert.ToInt32(TotalLineal * precioXkilo);
                txbCiega.Text = Convert.ToString(precioFinalRevestimiento / 2);
            }

        }
        private void CalcularPremarcos()
        {
            if (checkBoxPremarcos.Checked == true)
            {
                try
                {
                    int PrecioPremarcos = Convert.ToInt32(txbPrecioPremarcos.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Ingrese el Valor de los premarcos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    int cero = 0;
                    txbPrecioPremarcos.Text = Convert.ToString(cero);
                }
                try
                {
                    int TotalPremarcos = Convert.ToInt32(txbPremarcosOut.Text);
                    int TotalPremarcos1 = Convert.ToInt32(TxbTotalPremarcos.Text);

                }
                catch (FormatException)
                {
                    int cero = 0;
                    txbPremarcosOut.Text = Convert.ToString(cero);
                    TxbTotalPremarcos.Text = Convert.ToString(cero);
                }
                switch (aberturaSeleccionada)
                {
                    case "Ventana corrediza":
                    case "Ventana rebatible":
                    case "Ventana dezplazable":
                    case "Ventana banderola":
                    case "Paño fijo":
                        double ancho = Convert.ToDouble(txbAncho.Text);
                        double alto = Convert.ToDouble(txbAlto.Text);
                        double anchoD = ancho / 1000;
                        double altoD = alto / 1000;
                        double calculoPremarcoPerimetral = ((anchoD * 2) + (altoD * 2)) * 0.405;
                        int PrecioPremarcos = Convert.ToInt32(txbPrecioPremarcos.Text);
                        int cantidadDePremarcos = Convert.ToInt32(txbCantidadSeleccionada.Text);
                        int calculo = Convert.ToInt32((calculoPremarcoPerimetral * PrecioPremarcos)* 1.8);
                        txbPremarcosValorUnitario.Text = Convert.ToString(calculo);
                        int calculoPorCantidad = calculo * cantidadDePremarcos;
                        int TotalPremarcos = Convert.ToInt32(TxbTotalPremarcos.Text);
                        txbPremarcosOut.Text = Convert.ToString(calculoPorCantidad);
                        TxbTotalPremarcos.Text = Convert.ToString(TotalPremarcos + calculoPorCantidad);
                        break;
                    case "Puerta balcon":
                    case "Guia triple":
                    case "Puerta de abrir simple":
                    case "Puerta de abrir doble":
                        double ancho1 = Convert.ToDouble(txbAncho.Text);
                        double alto1 = Convert.ToDouble(txbAlto.Text);
                        double anchoD1 = ancho1 / 1000;
                        double altoD1 = alto1 / 1000;
                        double calculoPremarcoPerimetral1 = ((altoD1 * 2) + anchoD1) * 0.405;
                        int PrecioPremarcos1 = Convert.ToInt32(txbPrecioPremarcos.Text);
                        int cantidadDePremarcos1 = Convert.ToInt32(txbCantidadSeleccionada.Text);
                        int calculo1 = Convert.ToInt32((calculoPremarcoPerimetral1 * PrecioPremarcos1) * 1.8);
                        txbPremarcosValorUnitario.Text = Convert.ToString(calculo1);
                        int calculoPorCantidad1 = calculo1 * cantidadDePremarcos1;
                        int TotalPremarcos1 = Convert.ToInt32(TxbTotalPremarcos.Text);
                        txbPremarcosOut.Text = Convert.ToString(calculoPorCantidad1);
                        TxbTotalPremarcos.Text = Convert.ToString(TotalPremarcos1 + calculoPorCantidad1);
                        break;
                }
                ListViewItem Lista2 = new ListViewItem(txbNombre.Text);
                Lista2.SubItems.Add(txbAncho.Text + "mm X " + txbAlto.Text + "mm");
                Lista2.SubItems.Add(aberturaSeleccionada);
                Lista2.SubItems.Add(cantidadSeleccionada);
                Lista2.SubItems.Add(txbPremarcosValorUnitario.Text);
                //int PremarcosValorUnitario = Convert.ToInt32(txbPremarcosOut.Text);
                //int CantidadSeleccionada1 = Convert.ToInt32(txbCantidadSeleccionada.Text);
                //int calculoPremarcos = PremarcosValorUnitario;
                Lista2.SubItems.Add(txbPremarcosOut.Text);
                listView2.Items.Add(Lista2);
            }
            else
            {
                //try
                //{
                //    int PrecioPremarcos = Convert.ToInt32(txbPrecioPremarcos.Text);
                //}
                //catch (FormatException)
                //{
                //    MessageBox.Show("Ingrese el Valor de los premarcos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    int cero = 0;
                //    txbPrecioPremarcos.Text = Convert.ToString(cero);
                //}
                try
                {
                    int TotalPremarcos = Convert.ToInt32(txbPremarcosOut.Text);
                    int TotalPremarcos1 = Convert.ToInt32(TxbTotalPremarcos.Text);

                }
                catch (FormatException)
                {
                    int cero = 0;
                    txbPremarcosOut.Text = Convert.ToString(cero);
                    TxbTotalPremarcos.Text = Convert.ToString(cero);
                }
            }
        }
        private void PresupuestoTotal()
        {
            //if (checkBoxPremarcos.Checked==true)
            //{
            //    try
            //    {
            //        int presupuesTotalPremarcos = Convert.ToInt32(TxbTotalPremarcos.Text);
            //    }
            //    catch (FormatException)
            //    {
            //        int cero = 0;
            //        TxbTotalPremarcos.Text = Convert.ToString(cero);
            //    }
            //    try
            //    {
            //        int PremarcosIn1 = Convert.ToInt32(txbPremarcosOut.Text);
            //    }
            //    catch (FormatException)
            //    {
            //        int cero = 0;
            //        txbPremarcosOut.Text = Convert.ToString(cero);
            //    }
            //    int PremarcosIn = Convert.ToInt32(txbPremarcosOut.Text);
            //    int cantidadPremarcos = Convert.ToInt32(txbCantidadSeleccionada.Text);
            //    int presupuestoTotalPremarcos = Convert.ToInt32(TxbTotalPremarcos.Text);
            //    int presuTotalMasPremarcosIn = (presupuestoTotalPremarcos + PremarcosIn) * cantidadPremarcos;
            //    TxbTotalPremarcos.Text = Convert.ToString(presuTotalMasPremarcosIn);
            //}
            try
            {
                int presupuestoTotal1 = Convert.ToInt32(txbPresupuestoTotal.Text);
            }
            catch (FormatException)
            {
                int cero = 0;
                txbPresupuestoTotal.Text = Convert.ToString(cero);
            }
            
            int AberturaIn = Convert.ToInt32(totalAbertura.Text);
            int cantidad = Convert.ToInt32(txbCantidadSeleccionada.Text);
            int presupuestoTotal = Convert.ToInt32(txbPresupuestoTotal.Text);
            int presuTotalMasAberturaIn = (AberturaIn * cantidad) + presupuestoTotal;
            txbPresupuestoTotal.Text = Convert.ToString(presuTotalMasAberturaIn);
        }
        //Buttons
        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (cantidadSeleccionada)
            {
                case "2":
                    txbCantidadSeleccionada.Text = "2";
                    break;
                case "3":
                    txbCantidadSeleccionada.Text = "3";
                    break;
                case "4":
                    txbCantidadSeleccionada.Text = "4";
                    break;
                case "5":
                    txbCantidadSeleccionada.Text = "5";
                    break;
                case "6":
                    txbCantidadSeleccionada.Text = "6";
                    break;
                case "7":
                    txbCantidadSeleccionada.Text = "7";
                    break;
                case "8":
                    txbCantidadSeleccionada.Text = "8";
                    break;
                case "9":
                    txbCantidadSeleccionada.Text = "9";
                    break;
                case "10":
                    txbCantidadSeleccionada.Text = "10";
                    break;
                default:
                    txbCantidadSeleccionada.Text = "1";
                    break;
            }
            if (cbxAberturas.SelectedItem == null)
            {
                cbxAberturas.SelectedItem = "Ventana corrediza";
            }
            switch (aberturaSeleccionada)
            {
                case "Ventana corrediza":
                    CalcularVentanaCorrediza();
                    break;
                case "Puerta balcon":
                    CalcularPuertaBalcon();
                    break;
                case "Guia triple":
                    CalcularGuiaTriple();
                    break;
                case "Ventana rebatible":
                    CalcularVentanaRevatible();
                    break;
                case "Ventana dezplazable":
                    CalcularVentanaRevatible();
                    break;
                case "Ventana banderola":
                    CalcularVentanaRevatible();
                    break;
                case "Puerta de abrir simple":
                    CalcularPuertaDeAbrirSimple();
                    break;
                case "Puerta de abrir doble":
                    CalcularPuertaDeAbrirDoble();
                    break;
                default:
                    CalcularPañoFijo();
                    break;
            }
            CalcularPremarcos();
            //List View
            ListViewItem lista = new ListViewItem(txbNombre.Text);
            lista.SubItems.Add(txbAncho.Text + "mm X " + txbAlto.Text + "mm");
            lista.SubItems.Add(aberturaSeleccionada);
            lista.SubItems.Add(cantidadSeleccionada);
            lista.SubItems.Add("$" + totalAbertura.Text);
            int Abertura = Convert.ToInt32(totalAbertura.Text);
            int cantidad = Convert.ToInt32(txbCantidadSeleccionada.Text);
            int PrecioPorCantidad = Convert.ToInt32(Abertura * cantidad);
            txbPrecioPorCantidad.Text = Convert.ToString("$" + PrecioPorCantidad);
            lista.SubItems.Add(txbPrecioPorCantidad.Text);
            listView1.Items.Add(lista);
            PresupuestoTotal();
            PrecioAberturaGuardadas.Add(PrecioPorCantidad);
            int premarcos = Convert.ToInt32(txbPremarcosOut.Text);
            PrecioPremarcosGuardados.Add(premarcos);
        }
        //Botones adicionales
        private void btnBorrarItemListView_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceDelListView1 = listView1.SelectedIndices[0];
                txbIndiceListView1.Text = Convert.ToString(indiceDelListView1);

                int PrecioAberturasGuardadoEnIndice = PrecioAberturaGuardadas[indiceDelListView1];
                txbIndiceListAbertura.Text = Convert.ToString(PrecioAberturasGuardadoEnIndice);
                int TotalAberturas = Convert.ToInt32(txbPresupuestoTotal.Text);
                int resultadoAberturas = TotalAberturas - PrecioAberturasGuardadoEnIndice;
                txbPresupuestoTotal.Text = Convert.ToString(resultadoAberturas);
                foreach (ListViewItem lista in listView1.SelectedItems)
                {
                    lista.Remove();
                }

                PrecioAberturaGuardadas.RemoveAt(indiceDelListView1);

                if (checkBoxPremarcos.Checked == true)
                {
                    //int indiceDelListView2 = listView1.SelectedIndices[0];
                    txbIndiceListView2.Text = Convert.ToString(indiceDelListView1);

                    int PrecioPremarcosGuardadoEnIndicePremarcos = PrecioPremarcosGuardados[indiceDelListView1];
                    txbIndiceListPremarcos.Text = Convert.ToString(PrecioPremarcosGuardadoEnIndicePremarcos);
                    int TotalPremarcos = Convert.ToInt32(TxbTotalPremarcos.Text);//ver el presupeuesto total de los premarcos
                    int resultadoPremarcos = TotalPremarcos - PrecioPremarcosGuardadoEnIndicePremarcos;
                    TxbTotalPremarcos.Text = Convert.ToString(resultadoPremarcos);

                    listView2.Items.RemoveAt(indiceDelListView1);
                    
                   
                    PrecioPremarcosGuardados.RemoveAt(indiceDelListView1);
                }
                
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Marque un item de la lista para eliminar");
            }
        }
        private void btnLimpiarListView_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            int cero = 0;
            txbPresupuestoTotal.Text = Convert.ToString(cero);
            TxbTotalPremarcos.Text = Convert.ToString(cero);
            int Count1 = PrecioAberturaGuardadas.Count;
            int Count2 = PrecioPremarcosGuardados.Count;
            PrecioAberturaGuardadas.RemoveRange(0, Count1);
            PrecioPremarcosGuardados.RemoveRange(0, Count2);
        }
        private void btnOcultarPanelDetalles_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            buttonOcultar.Visible = true;
            btnOcultarPanelDetalles.Visible = false;
        } 
        private void buttonOcultar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            buttonOcultar.Visible = false;
            btnOcultarPanelDetalles.Visible = true;
        }
        private void btnSolapaAberturas_Click(object sender, EventArgs e)
        {
            listView1.Visible = true;
            listView2.Visible = false;
        }
        private void btnListViewPremarcos_Click(object sender, EventArgs e)
        {
            listView1.Visible = false;
            listView2.Visible = true;
            
        }
        private void btnEditarListView_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[0].Text = txbNombre.Text;
            listView1.SelectedItems[0].SubItems[1].Text = txbAncho.Text + "mm" + "x" + txbAlto.Text + "mm";
            listView1.SelectedItems[0].SubItems[2].Text = aberturaSeleccionada;
            switch (aberturaSeleccionada)
            {
                case "Ventana corrediza":
                    CalcularVentanaCorrediza();
                    break;
                case "Puerta balcon":
                    CalcularPuertaBalcon();
                    break;
                case "Guia triple":
                    CalcularGuiaTriple();
                    break;
                case "Ventana rebatible":
                    CalcularVentanaRevatible();
                    break;
                case "Ventana dezplazable":
                    CalcularVentanaRevatible();
                    break;
                case "Ventana banderola":
                    CalcularVentanaRevatible();
                    break;
                case "Puerta de abrir simple":
                    CalcularPuertaDeAbrirSimple();
                    break;
                case "Puerta de abrir doble":
                    CalcularPuertaDeAbrirDoble();
                    break;
                default:
                    CalcularPañoFijo();
                    break;
            }
            listView1.SelectedItems[0].SubItems[3].Text = cantidadSeleccionada;
            switch (cantidadSeleccionada)
            {
                case "2":
                    txbCantidadSeleccionada.Text = "2";
                    break;
                case "3":
                    txbCantidadSeleccionada.Text = "3";
                    break;
                case "4":
                    txbCantidadSeleccionada.Text = "4";
                    break;
                case "5":
                    txbCantidadSeleccionada.Text = "5";
                    break;
                case "6":
                    txbCantidadSeleccionada.Text = "6";
                    break;
                case "7":
                    txbCantidadSeleccionada.Text = "7";
                    break;
                case "8":
                    txbCantidadSeleccionada.Text = "8";
                    break;
                case "9":
                    txbCantidadSeleccionada.Text = "9";
                    break;
                case "10":
                    txbCantidadSeleccionada.Text = "10";
                    break;
                default:
                    txbCantidadSeleccionada.Text = "1";
                    break;
            }
            listView1.SelectedItems[0].SubItems[4].Text = "$" + totalAbertura.Text;
            int Abertura = Convert.ToInt32(totalAbertura.Text);
            int cantidad = Convert.ToInt32(txbCantidadSeleccionada.Text);
            int PrecioPorCantidad = Convert.ToInt32(Abertura * cantidad);
            listView1.SelectedItems[0].SubItems[5].Text = "$" + PrecioPorCantidad;
            //listView1.SelectedItems[0].SubItems[6].Text = txbPrecioPorCantidad.Text;



            try
            {
                int presupuestoTotal1 = Convert.ToInt32(txbPresupuestoTotal.Text);
            }
            catch (FormatException)
            {
                int cero = 0;
                txbPresupuestoTotal.Text = Convert.ToString(cero);
            }
            int AberturaIn = Convert.ToInt32(totalAbertura.Text);
            int CantidadDeAberturas = Convert.ToInt32(txbCantidadSeleccionada.Text);
            int presupuestoTotal = Convert.ToInt32(txbPresupuestoTotal.Text);
            int presuTotalMasAberturaIn = (presupuestoTotal + AberturaIn) * CantidadDeAberturas;
            txbPresupuestoTotal.Text = Convert.ToString(presuTotalMasAberturaIn);

        }

        //Check box
        private void checkBoxTravesaño_Click(object sender, EventArgs e)
        {
            checkBoxCiega.Checked = false;
            checkBoxMitadMitad.Checked = false;
        }
        private void checkBoxMitadMitad_Click(object sender, EventArgs e)
        {
            checkBoxCiega.Checked = false;
            checkTravesaños.Checked = false;
        }
        private void checkBoxCiega_Click(object sender, EventArgs e)
        {
            checkTravesaños.Checked = false;
            checkBoxMitadMitad.Checked = false;
        }
        private void btnAutocompletar_Click(object sender, EventArgs e)
        {
            txbAncho.Text = Convert.ToString("1200");
            txbAlto.Text = Convert.ToString("1000");
            txbPrecioAluminio.Text = Convert.ToString("800");
            txbPrecioVidrio.Text = Convert.ToString("1500");
            txbPrecioAccesorios.Text = Convert.ToString("2500");
        }

        private void checkBoxPremarcos_Click(object sender, EventArgs e)
        {
            if (checkBoxPremarcos.Checked == true)
            {
                MessageBox.Show("Recuerde ingresar el valor de los premarcos", "Cuidado!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //listView1.Columns.Add("Premarcos", width: 100);
                txbPrecioPremarcos.Visible = true;
                label8Premarcos.Visible = true;

                
            }
            else
            {
                txbPrecioPremarcos.Visible = false;
                label8Premarcos.Visible = false;
                
                //listView1.Columns.RemoveAt(6);

            }
        }
    }
}

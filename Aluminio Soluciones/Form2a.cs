using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aluminio_Soluciones
{
    public partial class Form2a : Form
    {
        public Form2a()
        {
            InitializeComponent();
            checkTravesaños.Visible = false;
        }
        private string aberturaSeleccionada { get; set; }
        private string cantidadSeleccionada { get; set; }
        private string PorcentajeManoDeObra { get; set; }

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
        }
        private void cbxAberturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            aberturaSeleccionada = cbxAberturas.SelectedItem.ToString();
            switch (aberturaSeleccionada)
            {
                case "Puerta de abrir simple":
                case "Puerta de abrir doble":
                    checkTravesaños.Visible = true;
                    break;
                default:
                    checkTravesaños.Visible = false;
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
        //Calculo de aberturas
        private void calcularVentanaCorrediza()
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
                MessageBox.Show("Ingrese la medida del ancho");
                txbAncho.Text = Convert.ToString("0");



            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura");
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio");
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio");
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios");
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
            double final204 = ((AnchoInM / 2 - 0.024) * perfilpeso.Perfil204) * 4;
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
                MessageBox.Show("Ingrese la medida del ancho");
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura");
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio");
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio");
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios");
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
                MessageBox.Show("Ingrese la medida del ancho");
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura");
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio");
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio");
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios");
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
                double final204central = (AnchoInM / 3 + 0.001) * PerfilesPeso.Perfil204;
                double final209central = (AnchoInM / 3 + 0.001) * PerfilesPeso.Perfil209;
                double final209lat = ((AnchoInM / 3 - 0.007) * 2) * PerfilesPeso.Perfil209;
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
                MessageBox.Show("Ingrese la medida del ancho");
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura");
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio");
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio");
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios");
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
                MessageBox.Show("Ingrese la medida del ancho");
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura");
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio");
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio");
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios");
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
                MessageBox.Show("Ingrese la medida del ancho");
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura");
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio");
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio");
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios");
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
        private void calcularPañoFijo()
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
                MessageBox.Show("Ingrese la medida del ancho");
                txbAncho.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAlto = Convert.ToInt32(txbAlto.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese la medida de la altura");
                txbAlto.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAluminio = Convert.ToInt32(txbPrecioAluminio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del aluminio");
                txbPrecioAluminio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaVidrio = Convert.ToInt32(txbPrecioVidrio.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor del vidrio");
                txbPrecioVidrio.Text = Convert.ToString("0");
            }
            try
            {
                int EntradaAccesorios = Convert.ToInt32(txbPrecioAccesorios.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese el valor de los accesorios");
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
            //int Alum = Convert.ToInt32(txbAluminioOut.Text);
            //int Vidrio = Convert.ToInt32(txbVidrioOut.Text);
            //int Acc = Convert.ToInt32(txbAccesoriosOut.Text);
            //int MdO = (Alum + Vidrio + Acc) * 40 / 100;
            //txbManodeobraout.Text = Convert.ToString(MdO);
            //int totalConContramarcos = Alum + Vidrio + Acc + MdO;
            //totalAbertura.Text = Convert.ToString(totalConContramarcos);
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
            //int Vidrio = Convert.ToInt32(txbVidrioOut.Text);
            //int Acc = Convert.ToInt32(txbAccesoriosOut.Text);
            //int MdO = Convert.ToInt32(txbManodeobraout.Text);
            //int Alum = Convert.ToInt32(txbAluminioOut.Text);
            //int totalConContramarcos = Alum + Vidrio + Acc + MdO;
            //totalAbertura.Text = Convert.ToString(totalConContramarcos);
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
            switch (aberturaSeleccionada)
            {
                case "Ventana corrediza":
                    calcularVentanaCorrediza();
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
                    calcularPañoFijo();
                    break;
            }

            //List View
            ListViewItem lista = new ListViewItem(txbNombre.Text);
            lista.SubItems.Add(txbAncho.Text + "x" + txbAlto.Text);
            lista.SubItems.Add(aberturaSeleccionada);
            lista.SubItems.Add(cantidadSeleccionada);
            lista.SubItems.Add("$" + totalAbertura.Text);
            int Abertura = Convert.ToInt32(totalAbertura.Text);
            int cantidad = Convert.ToInt32(txbCantidadSeleccionada.Text);
            int PrecioPorCantidad = Convert.ToInt32(Abertura * cantidad);
            txbPrecioPorCantidad.Text = Convert.ToString("$" + PrecioPorCantidad);
            lista.SubItems.Add(txbPrecioPorCantidad.Text);
            listView1.Items.Add(lista);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView1.SelectedItems)
            {
                lista.Remove();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            buttonOcultar.Visible = true;
            button5.Visible = false;
        }
        private void buttonOcultar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            buttonOcultar.Visible = false;
            button5.Visible = true;
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1.PerformClick();
            }
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}

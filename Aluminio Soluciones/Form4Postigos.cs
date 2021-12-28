using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aluminio_Soluciones
{
    public partial class Form4Postigos : Form
    {
        public Form4Postigos()
        {
            InitializeComponent();
        }
        private string PostigoSeleccionado { get; set; }
        private string CantidadSeleccionada { get; set; }

        private void cbxPostigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PostigoSeleccionado = cbxPostigos.SelectedItem.ToString();
        }

        private void cbxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CantidadSeleccionada = cbxCantidad.SelectedItem.ToString();
        }
        

        private class CalculoDePostigos
        {
            double anchoInDouble, altoInDouble, resultado;
            double marco = 0.440;
            double hojaParante = 0.495;
            double hojaConstante = 0.445;
            double tablilla = 0.280;

            public void postigoDeAbrir(int AnchoAr, int AltoAr)
            {

                int calculoMarco = (AnchoAr * 2) + (AltoAr * 2);
                double calculoMarcoDouble = calculoMarco * marco;
                int resultadoMarco = Convert.ToInt32(calculoMarcoDouble);
                
                

                int calculoHojaParante = AltoAr * 4;


            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Ancho = Convert.ToInt32(txbAncho.Text);
            int Alto = Convert.ToInt32(txbAlto.Text);


            switch (PostigoSeleccionado)
            {
                case "Postigo de abrir de una hoja":
                    break;
                case "Postigo de abrir de dos hojas":
                    break;
                default:
                    break;
            }
            switch (CantidadSeleccionada)
            {
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
                case "10":
                    break;
                default:
                    break;
            }
            CalculoDePostigos calculo1 = new CalculoDePostigos();


            calculo1.postigoDeAbrir(Ancho, Alto);

            ListViewItem Lista1 = new ListViewItem();
            listView1.Items.Add(Lista1);

        }
    }
}

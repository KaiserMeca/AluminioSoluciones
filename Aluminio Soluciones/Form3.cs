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
    public partial class Form3 : Form
    {
        List<int> AnchoIn = new List<int>();
        List<int> AltoIn = new List<int>();
        public Form3()
        {
            InitializeComponent();
        }
        public string CantidadSeleccionada { get; set; }
        public string AberturaSeleccionada { get; set; }
        private void cbxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            CantidadSeleccionada = cbxCantidad.SelectedItem.ToString();
        }

        private void cbxAberturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            AberturaSeleccionada = cbxAberturas.SelectedItem.ToString();
        }
        //Cargar button
        private void button1_Click(object sender, EventArgs e)
        {
            

            ListViewItem Lista = new ListViewItem();
            Lista.SubItems.Add(textBox1.Text + "mm X " + textBox2.Text + "mm");
            Lista.SubItems.Add(AberturaSeleccionada);
            Lista.SubItems.Add(CantidadSeleccionada);
            listView1.Items.Add(Lista);
        }
         
        //List button
        private void button2_Click(object sender, EventArgs e)
        {
            //Ancho
            int Ancho;
            int Alto;
            Ancho = Convert.ToInt32(textBox1.Text);
            Alto = Convert.ToInt32(textBox2.Text);
            AnchoIn.Add(Ancho);
            AltoIn.Add(Alto);
            listBox1.DataSource = null;
            listBox1.DataSource = AnchoIn;
            //listBox1.DataSource = AltoIn;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

        }
        

    }


}

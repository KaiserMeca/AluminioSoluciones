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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PersonalizarDiseño();
        }
        private void PersonalizarDiseño()
        {
          panelSubMenuPresupuesto.Visible = false;
            panelSubMenuPremarcos.Visible = false;
            panelSubMenuAyuda.Visible = false;
        }
        private void OcultarSubMenu()
        {
            if (panelSubMenuPresupuesto.Visible == true)
                panelSubMenuPresupuesto.Visible = false;
            if (panelSubMenuPremarcos.Visible == true)
                panelSubMenuPremarcos.Visible = false;
            if (panelSubMenuAyuda.Visible == true)
                panelSubMenuAyuda.Visible = false;
        }
        private void MostrarMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void btnpresupuesto_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelSubMenuPresupuesto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm1(new Form2a());
            OcultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();

        }

        private void btnPremarcos_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelSubMenuPremarcos);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm1(new Form3());
            OcultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void btnAberturas_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MostrarMenu(panelSubMenuAyuda);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }
        private Form FormularioActivo = null;
        private void AbrirForm1(Form FormularioHijo)
        {
            if (FormularioActivo != null)
                FormularioActivo.Close();
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panelFormbtn2.Controls.Add(FormularioHijo);
            panelFormbtn2.Tag = FormularioHijo ;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();



                    
        }
    }
}


namespace Aluminio_Soluciones
{
    partial class Form2a
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2a));
            this.cbxAberturas = new System.Windows.Forms.ComboBox();
            this.cbxCantidad = new System.Windows.Forms.ComboBox();
            this.txbAncho = new System.Windows.Forms.TextBox();
            this.txbAlto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txbPrecioAluminio = new System.Windows.Forms.TextBox();
            this.txbPrecioVidrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbPrecioAccesorios = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxManoDeObra = new System.Windows.Forms.ComboBox();
            this.totalAbertura = new System.Windows.Forms.TextBox();
            this.txbManodeobraout = new System.Windows.Forms.TextBox();
            this.txbVidrioOut = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txbAccesoriosOut = new System.Windows.Forms.TextBox();
            this.txbAluminioOut = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.txbCantidadSeleccionada = new System.Windows.Forms.TextBox();
            this.txbPrecioPorCantidad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonOcultar = new System.Windows.Forms.Button();
            this.txbContramarcos = new System.Windows.Forms.TextBox();
            this.checkTravesaños = new System.Windows.Forms.CheckBox();
            this.checkContramarcos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxAberturas
            // 
            this.cbxAberturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAberturas.FormattingEnabled = true;
            this.cbxAberturas.Items.AddRange(new object[] {
            "Ventana corrediza",
            "Puerta balcon",
            "Guia triple",
            "Ventana rebatible",
            "Ventana dezplazable",
            "Ventana banderola",
            "Puerta de abrir simple",
            "Puerta de abrir doble",
            "Paño fijo"});
            this.cbxAberturas.Location = new System.Drawing.Point(29, 76);
            this.cbxAberturas.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAberturas.Name = "cbxAberturas";
            this.cbxAberturas.Size = new System.Drawing.Size(160, 26);
            this.cbxAberturas.TabIndex = 0;
            this.cbxAberturas.TabStop = false;
            this.cbxAberturas.Text = "Aberturas";
            this.cbxAberturas.SelectedIndexChanged += new System.EventHandler(this.cbxAberturas_SelectedIndexChanged);
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCantidad.FormattingEnabled = true;
            this.cbxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxCantidad.Location = new System.Drawing.Point(29, 31);
            this.cbxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(160, 28);
            this.cbxCantidad.TabIndex = 0;
            this.cbxCantidad.TabStop = false;
            this.cbxCantidad.Text = "Cantidad";
            this.cbxCantidad.SelectedIndexChanged += new System.EventHandler(this.cbxCantidad_SelectedIndexChanged);
            // 
            // txbAncho
            // 
            this.txbAncho.Location = new System.Drawing.Point(265, 76);
            this.txbAncho.Margin = new System.Windows.Forms.Padding(1);
            this.txbAncho.Name = "txbAncho";
            this.txbAncho.Size = new System.Drawing.Size(72, 27);
            this.txbAncho.TabIndex = 0;
            // 
            // txbAlto
            // 
            this.txbAlto.Location = new System.Drawing.Point(448, 76);
            this.txbAlto.Margin = new System.Windows.Forms.Padding(1);
            this.txbAlto.Name = "txbAlto";
            this.txbAlto.Size = new System.Drawing.Size(72, 27);
            this.txbAlto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(262, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ancho en mm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(445, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alto en mm";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(1)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(265, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(614, 30);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button1_KeyUp);
            // 
            // txbPrecioAluminio
            // 
            this.txbPrecioAluminio.Location = new System.Drawing.Point(631, 76);
            this.txbPrecioAluminio.Margin = new System.Windows.Forms.Padding(1);
            this.txbPrecioAluminio.Name = "txbPrecioAluminio";
            this.txbPrecioAluminio.Size = new System.Drawing.Size(72, 27);
            this.txbPrecioAluminio.TabIndex = 2;
            // 
            // txbPrecioVidrio
            // 
            this.txbPrecioVidrio.Location = new System.Drawing.Point(797, 76);
            this.txbPrecioVidrio.Margin = new System.Windows.Forms.Padding(1);
            this.txbPrecioVidrio.Name = "txbPrecioVidrio";
            this.txbPrecioVidrio.Size = new System.Drawing.Size(72, 27);
            this.txbPrecioVidrio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(628, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Precio Aluminio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(794, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio Vidrio";
            // 
            // txbPrecioAccesorios
            // 
            this.txbPrecioAccesorios.Location = new System.Drawing.Point(1509, 140);
            this.txbPrecioAccesorios.Margin = new System.Windows.Forms.Padding(1);
            this.txbPrecioAccesorios.Name = "txbPrecioAccesorios";
            this.txbPrecioAccesorios.Size = new System.Drawing.Size(380, 27);
            this.txbPrecioAccesorios.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(1500, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Precio Accesorios";
            // 
            // cbxManoDeObra
            // 
            this.cbxManoDeObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxManoDeObra.FormattingEnabled = true;
            this.cbxManoDeObra.Items.AddRange(new object[] {
            "40%",
            "50%",
            "60%",
            "70%"});
            this.cbxManoDeObra.Location = new System.Drawing.Point(29, 119);
            this.cbxManoDeObra.Margin = new System.Windows.Forms.Padding(4);
            this.cbxManoDeObra.Name = "cbxManoDeObra";
            this.cbxManoDeObra.Size = new System.Drawing.Size(160, 28);
            this.cbxManoDeObra.TabIndex = 0;
            this.cbxManoDeObra.TabStop = false;
            this.cbxManoDeObra.Text = "Mano de Obra";
            this.cbxManoDeObra.SelectedIndexChanged += new System.EventHandler(this.cbxManoDeObra_SelectedIndexChanged);
            // 
            // totalAbertura
            // 
            this.totalAbertura.BackColor = System.Drawing.Color.White;
            this.totalAbertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAbertura.Location = new System.Drawing.Point(66, 246);
            this.totalAbertura.Margin = new System.Windows.Forms.Padding(1);
            this.totalAbertura.Multiline = true;
            this.totalAbertura.Name = "totalAbertura";
            this.totalAbertura.ReadOnly = true;
            this.totalAbertura.Size = new System.Drawing.Size(95, 27);
            this.totalAbertura.TabIndex = 4;
            this.totalAbertura.TabStop = false;
            // 
            // txbManodeobraout
            // 
            this.txbManodeobraout.BackColor = System.Drawing.Color.White;
            this.txbManodeobraout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbManodeobraout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbManodeobraout.Location = new System.Drawing.Point(53, 191);
            this.txbManodeobraout.Margin = new System.Windows.Forms.Padding(1);
            this.txbManodeobraout.Multiline = true;
            this.txbManodeobraout.Name = "txbManodeobraout";
            this.txbManodeobraout.ReadOnly = true;
            this.txbManodeobraout.Size = new System.Drawing.Size(108, 27);
            this.txbManodeobraout.TabIndex = 5;
            this.txbManodeobraout.TabStop = false;
            // 
            // txbVidrioOut
            // 
            this.txbVidrioOut.BackColor = System.Drawing.Color.White;
            this.txbVidrioOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbVidrioOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVidrioOut.Location = new System.Drawing.Point(53, 81);
            this.txbVidrioOut.Margin = new System.Windows.Forms.Padding(1);
            this.txbVidrioOut.Multiline = true;
            this.txbVidrioOut.Name = "txbVidrioOut";
            this.txbVidrioOut.ReadOnly = true;
            this.txbVidrioOut.Size = new System.Drawing.Size(108, 27);
            this.txbVidrioOut.TabIndex = 6;
            this.txbVidrioOut.TabStop = false;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(1, 246);
            this.textBox11.Margin = new System.Windows.Forms.Padding(1);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(63, 31);
            this.textBox11.TabIndex = 7;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "TOTAL";
            // 
            // txbAccesoriosOut
            // 
            this.txbAccesoriosOut.BackColor = System.Drawing.Color.White;
            this.txbAccesoriosOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAccesoriosOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAccesoriosOut.Location = new System.Drawing.Point(53, 136);
            this.txbAccesoriosOut.Margin = new System.Windows.Forms.Padding(1);
            this.txbAccesoriosOut.Multiline = true;
            this.txbAccesoriosOut.Name = "txbAccesoriosOut";
            this.txbAccesoriosOut.Size = new System.Drawing.Size(108, 27);
            this.txbAccesoriosOut.TabIndex = 12;
            this.txbAccesoriosOut.TabStop = false;
            // 
            // txbAluminioOut
            // 
            this.txbAluminioOut.BackColor = System.Drawing.Color.White;
            this.txbAluminioOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAluminioOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAluminioOut.Location = new System.Drawing.Point(53, 26);
            this.txbAluminioOut.Margin = new System.Windows.Forms.Padding(1);
            this.txbAluminioOut.Multiline = true;
            this.txbAluminioOut.Name = "txbAluminioOut";
            this.txbAluminioOut.Size = new System.Drawing.Size(108, 27);
            this.txbAluminioOut.TabIndex = 13;
            this.txbAluminioOut.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Medida,
            this.Abertura,
            this.Cantidad,
            this.PrecioU,
            this.PrecioF});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(263, 217);
            this.listView1.Margin = new System.Windows.Forms.Padding(1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(649, 676);
            this.listView1.TabIndex = 14;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Etiqueta";
            this.Nombre.Width = 100;
            // 
            // Medida
            // 
            this.Medida.Text = "Medida";
            this.Medida.Width = 100;
            // 
            // Abertura
            // 
            this.Abertura.Text = "Abertura";
            this.Abertura.Width = 180;
            // 
            // Cantidad
            // 
            this.Cantidad.Text = "Cantidad";
            this.Cantidad.Width = 85;
            // 
            // PrecioU
            // 
            this.PrecioU.Text = "Unitario";
            this.PrecioU.Width = 100;
            // 
            // PrecioF
            // 
            this.PrecioF.Text = "Total";
            this.PrecioF.Width = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(838, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(666, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(0, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1586, 23);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(21, 26);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(21, 193);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(21, 83);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(21, 138);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(140, 163);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(1);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(0, 27);
            this.txbNombre.TabIndex = 1;
            this.txbNombre.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(31, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Etiqueta";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(302, 30);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(0, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(478, 30);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(0, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // txbCantidadSeleccionada
            // 
            this.txbCantidadSeleccionada.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbCantidadSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCantidadSeleccionada.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbCantidadSeleccionada.Location = new System.Drawing.Point(391, 14);
            this.txbCantidadSeleccionada.Margin = new System.Windows.Forms.Padding(1);
            this.txbCantidadSeleccionada.Name = "txbCantidadSeleccionada";
            this.txbCantidadSeleccionada.ReadOnly = true;
            this.txbCantidadSeleccionada.Size = new System.Drawing.Size(95, 20);
            this.txbCantidadSeleccionada.TabIndex = 1;
            this.txbCantidadSeleccionada.TabStop = false;
            // 
            // txbPrecioPorCantidad
            // 
            this.txbPrecioPorCantidad.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbPrecioPorCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPrecioPorCantidad.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbPrecioPorCantidad.Location = new System.Drawing.Point(133, 14);
            this.txbPrecioPorCantidad.Margin = new System.Windows.Forms.Padding(1);
            this.txbPrecioPorCantidad.Name = "txbPrecioPorCantidad";
            this.txbPrecioPorCantidad.ReadOnly = true;
            this.txbPrecioPorCantidad.Size = new System.Drawing.Size(15, 20);
            this.txbPrecioPorCantidad.TabIndex = 1;
            this.txbPrecioPorCantidad.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(1509, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 59);
            this.button2.TabIndex = 16;
            this.button2.TabStop = false;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(1579, 350);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 59);
            this.button3.TabIndex = 16;
            this.button3.Text = "R";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(1645, 350);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 59);
            this.button4.TabIndex = 16;
            this.button4.Text = "E";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbAluminioOut);
            this.panel1.Controls.Add(this.txbAccesoriosOut);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.txbVidrioOut);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.txbManodeobraout);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.totalAbertura);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Location = new System.Drawing.Point(28, 236);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 461);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(29, 204);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "Detalles";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonOcultar
            // 
            this.buttonOcultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonOcultar.FlatAppearance.BorderSize = 0;
            this.buttonOcultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOcultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOcultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOcultar.Location = new System.Drawing.Point(28, 204);
            this.buttonOcultar.Margin = new System.Windows.Forms.Padding(1);
            this.buttonOcultar.Name = "buttonOcultar";
            this.buttonOcultar.Size = new System.Drawing.Size(107, 30);
            this.buttonOcultar.TabIndex = 18;
            this.buttonOcultar.Text = "Ocultar";
            this.buttonOcultar.UseVisualStyleBackColor = false;
            this.buttonOcultar.Visible = false;
            this.buttonOcultar.Click += new System.EventHandler(this.buttonOcultar_Click);
            // 
            // txbContramarcos
            // 
            this.txbContramarcos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txbContramarcos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContramarcos.ForeColor = System.Drawing.SystemColors.Window;
            this.txbContramarcos.Location = new System.Drawing.Point(59, 14);
            this.txbContramarcos.Margin = new System.Windows.Forms.Padding(1);
            this.txbContramarcos.Name = "txbContramarcos";
            this.txbContramarcos.ReadOnly = true;
            this.txbContramarcos.Size = new System.Drawing.Size(15, 20);
            this.txbContramarcos.TabIndex = 1;
            this.txbContramarcos.TabStop = false;
            // 
            // checkTravesaños
            // 
            this.checkTravesaños.AutoSize = true;
            this.checkTravesaños.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkTravesaños.Location = new System.Drawing.Point(266, 165);
            this.checkTravesaños.Margin = new System.Windows.Forms.Padding(1);
            this.checkTravesaños.Name = "checkTravesaños";
            this.checkTravesaños.Size = new System.Drawing.Size(109, 24);
            this.checkTravesaños.TabIndex = 20;
            this.checkTravesaños.Text = "Travesaño";
            this.checkTravesaños.UseVisualStyleBackColor = true;
            // 
            // checkContramarcos
            // 
            this.checkContramarcos.AutoSize = true;
            this.checkContramarcos.Checked = true;
            this.checkContramarcos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkContramarcos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkContramarcos.Location = new System.Drawing.Point(266, 191);
            this.checkContramarcos.Margin = new System.Windows.Forms.Padding(1);
            this.checkContramarcos.Name = "checkContramarcos";
            this.checkContramarcos.Size = new System.Drawing.Size(137, 24);
            this.checkContramarcos.TabIndex = 20;
            this.checkContramarcos.Text = "Contramarcos";
            this.checkContramarcos.UseVisualStyleBackColor = true;
            // 
            // Form2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(732, 453);
            this.Controls.Add(this.checkContramarcos);
            this.Controls.Add(this.checkTravesaños);
            this.Controls.Add(this.buttonOcultar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbPrecioAccesorios);
            this.Controls.Add(this.txbPrecioVidrio);
            this.Controls.Add(this.txbAlto);
            this.Controls.Add(this.txbPrecioAluminio);
            this.Controls.Add(this.txbContramarcos);
            this.Controls.Add(this.txbPrecioPorCantidad);
            this.Controls.Add(this.txbCantidadSeleccionada);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbAncho);
            this.Controls.Add(this.cbxManoDeObra);
            this.Controls.Add(this.cbxCantidad);
            this.Controls.Add(this.cbxAberturas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2a";
            this.Text = "Form2a";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAberturas;
        private System.Windows.Forms.ComboBox cbxCantidad;
        private System.Windows.Forms.TextBox txbAncho;
        private System.Windows.Forms.TextBox txbAlto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbPrecioAluminio;
        private System.Windows.Forms.TextBox txbPrecioVidrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbPrecioAccesorios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxManoDeObra;
        private System.Windows.Forms.TextBox totalAbertura;
        private System.Windows.Forms.TextBox txbManodeobraout;
        private System.Windows.Forms.TextBox txbVidrioOut;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txbAccesoriosOut;
        private System.Windows.Forms.TextBox txbAluminioOut;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Medida;
        private System.Windows.Forms.ColumnHeader Abertura;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader PrecioU;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox txbCantidadSeleccionada;
        private System.Windows.Forms.ColumnHeader PrecioF;
        private System.Windows.Forms.TextBox txbPrecioPorCantidad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonOcultar;
        private System.Windows.Forms.TextBox txbContramarcos;
        private System.Windows.Forms.CheckBox checkTravesaños;
        private System.Windows.Forms.CheckBox checkContramarcos;
    }
}
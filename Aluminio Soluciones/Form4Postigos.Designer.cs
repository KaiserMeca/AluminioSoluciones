
namespace Aluminio_Soluciones
{
    partial class Form4Postigos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAlto = new System.Windows.Forms.TextBox();
            this.txbAncho = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medida = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxCantidad = new System.Windows.Forms.ComboBox();
            this.cbxPostigos = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbPrecioAluminio = new System.Windows.Forms.TextBox();
            this.labelPrecioAluminio = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelPrecioAccesorios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Alto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ancho";
            // 
            // txbAlto
            // 
            this.txbAlto.Location = new System.Drawing.Point(102, 76);
            this.txbAlto.Name = "txbAlto";
            this.txbAlto.Size = new System.Drawing.Size(80, 22);
            this.txbAlto.TabIndex = 19;
            // 
            // txbAncho
            // 
            this.txbAncho.Location = new System.Drawing.Point(102, 37);
            this.txbAncho.Name = "txbAncho";
            this.txbAncho.Size = new System.Drawing.Size(80, 22);
            this.txbAncho.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(80)))), ((int)(((byte)(25)))));
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Medida,
            this.Abertura,
            this.Cantidad,
            this.PrecioU,
            this.PrecioF});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(237, 106);
            this.listView1.Margin = new System.Windows.Forms.Padding(1);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(675, 317);
            this.listView1.TabIndex = 20;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 70;
            // 
            // Medida
            // 
            this.Medida.Text = "Medida";
            this.Medida.Width = 140;
            // 
            // Abertura
            // 
            this.Abertura.Text = "Postigo";
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
            this.cbxCantidad.Location = new System.Drawing.Point(237, 36);
            this.cbxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(160, 25);
            this.cbxCantidad.TabIndex = 23;
            this.cbxCantidad.TabStop = false;
            this.cbxCantidad.Text = "Cantidad";
            this.cbxCantidad.SelectedIndexChanged += new System.EventHandler(this.cbxCantidad_SelectedIndexChanged);
            // 
            // cbxPostigos
            // 
            this.cbxPostigos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPostigos.FormattingEnabled = true;
            this.cbxPostigos.Items.AddRange(new object[] {
            "Postigo de abrir de una hoja",
            "Postigo de abrir de dos hojas",
            "Postigo corredizo"});
            this.cbxPostigos.Location = new System.Drawing.Point(237, 74);
            this.cbxPostigos.Margin = new System.Windows.Forms.Padding(4);
            this.cbxPostigos.Name = "cbxPostigos";
            this.cbxPostigos.Size = new System.Drawing.Size(160, 24);
            this.cbxPostigos.TabIndex = 24;
            this.cbxPostigos.TabStop = false;
            this.cbxPostigos.Text = "Postigos";
            this.cbxPostigos.SelectedIndexChanged += new System.EventHandler(this.cbxPostigos_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.CausesValidation = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 24);
            this.button2.TabIndex = 25;
            this.button2.Text = "lIst";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(32, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 24);
            this.button1.TabIndex = 26;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbPrecioAluminio
            // 
            this.txbPrecioAluminio.Location = new System.Drawing.Point(32, 140);
            this.txbPrecioAluminio.Name = "txbPrecioAluminio";
            this.txbPrecioAluminio.Size = new System.Drawing.Size(80, 22);
            this.txbPrecioAluminio.TabIndex = 19;
            // 
            // labelPrecioAluminio
            // 
            this.labelPrecioAluminio.AutoSize = true;
            this.labelPrecioAluminio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioAluminio.Location = new System.Drawing.Point(29, 121);
            this.labelPrecioAluminio.Name = "labelPrecioAluminio";
            this.labelPrecioAluminio.Size = new System.Drawing.Size(116, 16);
            this.labelPrecioAluminio.TabIndex = 21;
            this.labelPrecioAluminio.Text = "Precio Aluminio";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 200);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 22);
            this.textBox3.TabIndex = 19;
            // 
            // labelPrecioAccesorios
            // 
            this.labelPrecioAccesorios.AutoSize = true;
            this.labelPrecioAccesorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioAccesorios.Location = new System.Drawing.Point(29, 181);
            this.labelPrecioAccesorios.Name = "labelPrecioAccesorios";
            this.labelPrecioAccesorios.Size = new System.Drawing.Size(143, 16);
            this.labelPrecioAccesorios.TabIndex = 21;
            this.labelPrecioAccesorios.Text = "Precio Accsesorios";
            // 
            // Form4Postigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxCantidad);
            this.Controls.Add(this.cbxPostigos);
            this.Controls.Add(this.labelPrecioAccesorios);
            this.Controls.Add(this.labelPrecioAluminio);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPrecioAluminio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAlto);
            this.Controls.Add(this.txbAncho);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4Postigos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form4Postigos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAlto;
        private System.Windows.Forms.TextBox txbAncho;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Medida;
        private System.Windows.Forms.ColumnHeader Abertura;
        private System.Windows.Forms.ColumnHeader Cantidad;
        private System.Windows.Forms.ColumnHeader PrecioU;
        private System.Windows.Forms.ColumnHeader PrecioF;
        private System.Windows.Forms.ComboBox cbxCantidad;
        private System.Windows.Forms.ComboBox cbxPostigos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbPrecioAluminio;
        private System.Windows.Forms.Label labelPrecioAluminio;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelPrecioAccesorios;
    }
}
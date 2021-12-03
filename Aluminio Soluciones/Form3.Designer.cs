
namespace Aluminio_Soluciones
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.ListaDeAberturas1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaDeAberturas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 297);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListaDeAberturas1
            // 
            this.ListaDeAberturas1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ListaDeAberturas1.HideSelection = false;
            this.ListaDeAberturas1.Location = new System.Drawing.Point(9, 10);
            this.ListaDeAberturas1.Margin = new System.Windows.Forms.Padding(2);
            this.ListaDeAberturas1.Name = "ListaDeAberturas1";
            this.ListaDeAberturas1.Size = new System.Drawing.Size(333, 239);
            this.ListaDeAberturas1.TabIndex = 16;
            this.ListaDeAberturas1.UseCompatibleStateImageBehavior = false;
            this.ListaDeAberturas1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Abertura";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ancho";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Alto";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Mt Lineal";
            // 
            // ListaDeAberturas
            // 
            this.ListaDeAberturas.FormattingEnabled = true;
            this.ListaDeAberturas.Items.AddRange(new object[] {
            "caca",
            "pis"});
            this.ListaDeAberturas.Location = new System.Drawing.Point(368, 10);
            this.ListaDeAberturas.Margin = new System.Windows.Forms.Padding(2);
            this.ListaDeAberturas.Name = "ListaDeAberturas";
            this.ListaDeAberturas.Size = new System.Drawing.Size(92, 21);
            this.ListaDeAberturas.TabIndex = 17;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 368);
            this.Controls.Add(this.ListaDeAberturas);
            this.Controls.Add(this.ListaDeAberturas1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView ListaDeAberturas1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox ListaDeAberturas;
    }
}
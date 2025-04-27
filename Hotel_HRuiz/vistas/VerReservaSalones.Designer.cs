using System.Windows.Forms;
using bbdd;

namespace Hotel_HRuiz.vistas
{
    partial class VerReservaSalones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.botonActualles = new System.Windows.Forms.Button();
            this.botonHis = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.botonMostrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 82);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_HRuiz.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(766, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservas de Salones";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 20);
            this.panel2.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(29, 166);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Reservas actuales";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtrar por fecha";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(149, 101);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(213, 20);
            this.fecha.TabIndex = 18;
            // 
            // botonActualles
            // 
            this.botonActualles.Location = new System.Drawing.Point(529, 101);
            this.botonActualles.Name = "botonActualles";
            this.botonActualles.Size = new System.Drawing.Size(116, 23);
            this.botonActualles.TabIndex = 19;
            this.botonActualles.Text = "Consultas actuales";
            this.botonActualles.UseVisualStyleBackColor = true;
            this.botonActualles.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonHis
            // 
            this.botonHis.Location = new System.Drawing.Point(680, 101);
            this.botonHis.Name = "botonHis";
            this.botonHis.Size = new System.Drawing.Size(116, 23);
            this.botonHis.TabIndex = 20;
            this.botonHis.Text = "Consultas históricas";
            this.botonHis.UseVisualStyleBackColor = true;
            this.botonHis.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(35, 202);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(761, 229);
            this.Tabla.TabIndex = 21;
            // 
            // botonMostrar
            // 
            this.botonMostrar.Location = new System.Drawing.Point(420, 102);
            this.botonMostrar.Name = "botonMostrar";
            this.botonMostrar.Size = new System.Drawing.Size(75, 23);
            this.botonMostrar.TabIndex = 22;
            this.botonMostrar.Text = "Mostrar";
            this.botonMostrar.UseVisualStyleBackColor = true;
            this.botonMostrar.Click += new System.EventHandler(this.botonMostrar_Click);
            // 
            // VerReservaSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.botonMostrar);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.botonHis);
            this.Controls.Add(this.botonActualles);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label13);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "VerReservaSalones";
            this.Text = "Ver reservas de salones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button botonActualles;
        private System.Windows.Forms.Button botonHis;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Button botonMostrar;

        private void CargarReservasPorFecha()
        {
            if (fecha == null)
            {
                MessageBox.Show("Debes seleccionar una fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Tabla.DataSource = null;

            Tabla.DataSource = ConsultasSalones.ListadoSalonesFecha(fecha.Value);
        }

        private void CargarReservasActuales()
        {
            Tabla.DataSource = null;
            Tabla.DataSource = ConsultasSalones.ListadoSalonesActual();
        }
        private void CargarReservasHistorico()
        {
            Tabla.DataSource = null;
            Tabla.DataSource = ConsultasSalones.ListadoSalonesHis();
        }

        
    }
}
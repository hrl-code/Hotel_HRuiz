using bbdd;
using Hotel_HRuiz.bbdd;
using Hotel_HRuiz.modelo;
using System.Windows.Forms;
using System;

namespace Hotel_HRuiz.vistas
{
    partial class ReservaSalones
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
            this.botonRegistrarReserva_RS = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboCatering_RS = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateEntrada_RS = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Factura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBoxDatosReserva_RS = new System.Windows.Forms.GroupBox();
            this.campoNumPersonas_RS = new System.Windows.Forms.TextBox();
            this.botonRegistrarCliente_RS = new System.Windows.Forms.Button();
            this.campoLocalidad_RS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.campoCP_RS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.campoDireccion_RS = new System.Windows.Forms.TextBox();
            this.campoEmail_RS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoTelefono_RS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoApellidos_RS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.campoNombre_RS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.campoDni_RS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDatosCliente_RS = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxDatosReserva_RS.SuspendLayout();
            this.groupBoxDatosCliente_RS.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRegistrarReserva_RS
            // 
            this.botonRegistrarReserva_RS.BackColor = System.Drawing.Color.White;
            this.botonRegistrarReserva_RS.Location = new System.Drawing.Point(120, 501);
            this.botonRegistrarReserva_RS.Name = "botonRegistrarReserva_RS";
            this.botonRegistrarReserva_RS.Size = new System.Drawing.Size(257, 23);
            this.botonRegistrarReserva_RS.TabIndex = 12;
            this.botonRegistrarReserva_RS.Text = "Registrar Reserva";
            this.botonRegistrarReserva_RS.UseVisualStyleBackColor = false;
            this.botonRegistrarReserva_RS.Click += new System.EventHandler(this.botonRegistrarReserva_RS_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 20);
            this.panel2.TabIndex = 9;
            // 
            // comboCatering_RS
            // 
            this.comboCatering_RS.FormattingEnabled = true;
            this.comboCatering_RS.Items.AddRange(new object[] {
            "Seleccione",
            "Almuerzo",
            "Comida",
            "Desayuno",
            "Cena"});
            this.comboCatering_RS.Location = new System.Drawing.Point(174, 71);
            this.comboCatering_RS.Name = "comboCatering_RS";
            this.comboCatering_RS.Size = new System.Drawing.Size(121, 21);
            this.comboCatering_RS.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(44, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Caterin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(44, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Número de personas";
            // 
            // dateEntrada_RS
            // 
            this.dateEntrada_RS.Location = new System.Drawing.Point(173, 14);
            this.dateEntrada_RS.Name = "dateEntrada_RS";
            this.dateEntrada_RS.Size = new System.Drawing.Size(200, 20);
            this.dateEntrada_RS.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(43, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fecha";
            // 
            // Factura
            // 
            this.Factura.Location = new System.Drawing.Point(533, 112);
            this.Factura.Multiline = true;
            this.Factura.Name = "Factura";
            this.Factura.Size = new System.Drawing.Size(308, 383);
            this.Factura.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(530, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Detalle de la última reserva registrada";
            // 
            // groupBoxDatosReserva_RS
            // 
            this.groupBoxDatosReserva_RS.Controls.Add(this.campoNumPersonas_RS);
            this.groupBoxDatosReserva_RS.Controls.Add(this.comboCatering_RS);
            this.groupBoxDatosReserva_RS.Controls.Add(this.label12);
            this.groupBoxDatosReserva_RS.Controls.Add(this.label11);
            this.groupBoxDatosReserva_RS.Controls.Add(this.dateEntrada_RS);
            this.groupBoxDatosReserva_RS.Controls.Add(this.label10);
            this.groupBoxDatosReserva_RS.Location = new System.Drawing.Point(32, 386);
            this.groupBoxDatosReserva_RS.Name = "groupBoxDatosReserva_RS";
            this.groupBoxDatosReserva_RS.Size = new System.Drawing.Size(418, 109);
            this.groupBoxDatosReserva_RS.TabIndex = 11;
            this.groupBoxDatosReserva_RS.TabStop = false;
            this.groupBoxDatosReserva_RS.Text = "DATOS DE LA RESERVA";
            // 
            // campoNumPersonas_RS
            // 
            this.campoNumPersonas_RS.Location = new System.Drawing.Point(174, 42);
            this.campoNumPersonas_RS.Name = "campoNumPersonas_RS";
            this.campoNumPersonas_RS.Size = new System.Drawing.Size(100, 20);
            this.campoNumPersonas_RS.TabIndex = 6;
            // 
            // botonRegistrarCliente_RS
            // 
            this.botonRegistrarCliente_RS.Location = new System.Drawing.Point(156, 263);
            this.botonRegistrarCliente_RS.Name = "botonRegistrarCliente_RS";
            this.botonRegistrarCliente_RS.Size = new System.Drawing.Size(150, 23);
            this.botonRegistrarCliente_RS.TabIndex = 17;
            this.botonRegistrarCliente_RS.Text = "Registrar Cliente";
            this.botonRegistrarCliente_RS.UseVisualStyleBackColor = true;
            this.botonRegistrarCliente_RS.Click += new System.EventHandler(this.botonRegistrarCliente_RS_Click);
            // 
            // campoLocalidad_RS
            // 
            this.campoLocalidad_RS.Enabled = false;
            this.campoLocalidad_RS.Location = new System.Drawing.Point(123, 226);
            this.campoLocalidad_RS.Name = "campoLocalidad_RS";
            this.campoLocalidad_RS.Size = new System.Drawing.Size(183, 20);
            this.campoLocalidad_RS.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(40, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Localidad";
            // 
            // campoCP_RS
            // 
            this.campoCP_RS.Enabled = false;
            this.campoCP_RS.Location = new System.Drawing.Point(123, 200);
            this.campoCP_RS.Name = "campoCP_RS";
            this.campoCP_RS.Size = new System.Drawing.Size(128, 20);
            this.campoCP_RS.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(40, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "CP";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(638, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Generar Factura";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // campoDireccion_RS
            // 
            this.campoDireccion_RS.Enabled = false;
            this.campoDireccion_RS.Location = new System.Drawing.Point(123, 174);
            this.campoDireccion_RS.Name = "campoDireccion_RS";
            this.campoDireccion_RS.Size = new System.Drawing.Size(231, 20);
            this.campoDireccion_RS.TabIndex = 12;
            // 
            // campoEmail_RS
            // 
            this.campoEmail_RS.Enabled = false;
            this.campoEmail_RS.Location = new System.Drawing.Point(123, 148);
            this.campoEmail_RS.Name = "campoEmail_RS";
            this.campoEmail_RS.Size = new System.Drawing.Size(183, 20);
            this.campoEmail_RS.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(40, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // campoTelefono_RS
            // 
            this.campoTelefono_RS.Enabled = false;
            this.campoTelefono_RS.Location = new System.Drawing.Point(123, 122);
            this.campoTelefono_RS.Name = "campoTelefono_RS";
            this.campoTelefono_RS.Size = new System.Drawing.Size(128, 20);
            this.campoTelefono_RS.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(40, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Teléfono";
            // 
            // campoApellidos_RS
            // 
            this.campoApellidos_RS.Enabled = false;
            this.campoApellidos_RS.Location = new System.Drawing.Point(123, 96);
            this.campoApellidos_RS.Name = "campoApellidos_RS";
            this.campoApellidos_RS.Size = new System.Drawing.Size(183, 20);
            this.campoApellidos_RS.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(40, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellidos";
            // 
            // campoNombre_RS
            // 
            this.campoNombre_RS.Enabled = false;
            this.campoNombre_RS.Location = new System.Drawing.Point(123, 70);
            this.campoNombre_RS.Name = "campoNombre_RS";
            this.campoNombre_RS.Size = new System.Drawing.Size(114, 20);
            this.campoNombre_RS.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(40, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(290, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Comprobar DNI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // campoDni_RS
            // 
            this.campoDni_RS.Location = new System.Drawing.Point(123, 24);
            this.campoDni_RS.Name = "campoDni_RS";
            this.campoDni_RS.Size = new System.Drawing.Size(148, 20);
            this.campoDni_RS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(40, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // groupBoxDatosCliente_RS
            // 
            this.groupBoxDatosCliente_RS.Controls.Add(this.botonRegistrarCliente_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.campoLocalidad_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.label9);
            this.groupBoxDatosCliente_RS.Controls.Add(this.campoCP_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.label8);
            this.groupBoxDatosCliente_RS.Controls.Add(this.campoDireccion_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.label7);
            this.groupBoxDatosCliente_RS.Controls.Add(this.campoEmail_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.label6);
            this.groupBoxDatosCliente_RS.Controls.Add(this.campoTelefono_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.label5);
            this.groupBoxDatosCliente_RS.Controls.Add(this.campoApellidos_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.label4);
            this.groupBoxDatosCliente_RS.Controls.Add(this.campoNombre_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.label3);
            this.groupBoxDatosCliente_RS.Controls.Add(this.button2);
            this.groupBoxDatosCliente_RS.Controls.Add(this.campoDni_RS);
            this.groupBoxDatosCliente_RS.Controls.Add(this.label2);
            this.groupBoxDatosCliente_RS.Location = new System.Drawing.Point(32, 88);
            this.groupBoxDatosCliente_RS.Name = "groupBoxDatosCliente_RS";
            this.groupBoxDatosCliente_RS.Size = new System.Drawing.Size(418, 292);
            this.groupBoxDatosCliente_RS.TabIndex = 10;
            this.groupBoxDatosCliente_RS.TabStop = false;
            this.groupBoxDatosCliente_RS.Text = "DATOS DEL CLIENTE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(40, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva de Salones";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 82);
            this.panel1.TabIndex = 8;
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
            // ReservaSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.botonRegistrarReserva_RS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Factura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBoxDatosReserva_RS);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBoxDatosCliente_RS);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ReservaSalones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReservaSalones";
            this.groupBoxDatosReserva_RS.ResumeLayout(false);
            this.groupBoxDatosReserva_RS.PerformLayout();
            this.groupBoxDatosCliente_RS.ResumeLayout(false);
            this.groupBoxDatosCliente_RS.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRegistrarReserva_RS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboCatering_RS;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateEntrada_RS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Factura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxDatosReserva_RS;
        private System.Windows.Forms.Button botonRegistrarCliente_RS;
        private System.Windows.Forms.TextBox campoLocalidad_RS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox campoCP_RS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox campoDireccion_RS;
        private System.Windows.Forms.TextBox campoEmail_RS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoTelefono_RS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoApellidos_RS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoNombre_RS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox campoDni_RS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDatosCliente_RS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox campoNumPersonas_RS;

        public void BotonRegistrarCliente()
        {
            if (Hotel_HRuiz.Utilidades.CampoVacio(campoNombre_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo nombre esta vacio");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoApellidos_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo apellidos esta vacio");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoTelefono_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo telefono esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.EnteroCorrecto(campoTelefono_RS))
            {
                Hotel_HRuiz.Utilidades.LanzarAlertaEntero(this, "El campo telefono es numerico");
            }
            else if (!Hotel_HRuiz.Utilidades.FormatoTelefono(campoTelefono_RS.Text))
            {
                Hotel_HRuiz.Utilidades.LanzarTelefono(this, "El telefono no es valido");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoEmail_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo email esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.CorreoCorrecto(campoEmail_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCorreo(this, "El email no es valido");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoDireccion_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo direccion esta vacio");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoCP_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo cp esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.EnteroCorrecto(campoCP_RS))
            {
                Hotel_HRuiz.Utilidades.LanzarAlertaEntero(this, "El campo cp es numerico");
            }
            else if (!Hotel_HRuiz.Utilidades.FormatoCP(campoCP_RS.Text))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCp(this, "El cp no es valido");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoLocalidad_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo localidad esta vacio");
            }
            else
            {
                Cliente c = new Cliente(
                    campoDni_RS.Text.ToUpper(),
                    campoNombre_RS.Text,
                    campoApellidos_RS.Text,
                    int.Parse(campoTelefono_RS.Text),
                    campoEmail_RS.Text,
                    campoDireccion_RS.Text,
                    int.Parse(campoCP_RS.Text),
                    campoLocalidad_RS.Text
                );

                if (ConsultasClientes.RegistrarCliente(c))
                {
                    MessageBox.Show("Cliente registrado correctamente");

                    campoDni_RS.Enabled = false;
                    campoNombre_RS.Enabled = false;
                    campoApellidos_RS.Enabled = false;
                    campoTelefono_RS.Enabled = false;
                    campoEmail_RS.Enabled = false;
                    campoDireccion_RS.Enabled = false;
                    campoCP_RS.Enabled = false;
                    campoLocalidad_RS.Enabled = false;
                    botonRegistrarReserva_RS.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error en el registro. Comprueba el formulario");
                    campoDni_RS.Enabled = true;
                    campoNombre_RS.Enabled = true;
                    campoApellidos_RS.Enabled = true;
                    campoTelefono_RS.Enabled = true;
                    campoEmail_RS.Enabled = true;
                    campoDireccion_RS.Enabled = true;
                    campoCP_RS.Enabled = true;
                    campoLocalidad_RS.Enabled = true;
                    botonRegistrarReserva_RS.Enabled = false;
                }
            }
        }

        public void BotonComDni()
        {
            if (Hotel_HRuiz.Utilidades.CampoVacio(campoDni_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo dni esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.FormatoDNI(campoDni_RS.Text.ToUpper()))
            {
                Hotel_HRuiz.Utilidades.LanzarFormatoDni(this, "El formato del dni no es correcto");
            }
            else if (!Hotel_HRuiz.Utilidades.DniValido(campoDni_RS.Text.ToUpper()))
            {
                Hotel_HRuiz.Utilidades.LanzarFormatoDniValido(this, "El dni no es valido");
            }
            else if (ConsultasClientes.ComprobarDni(campoDni_RS.Text.ToUpper()))
            {
                Cliente c = ConsultasClientes.RescataDatosCliente(campoDni_RS.Text.ToUpper());

                campoNombre_RS.Text = c.Nombre;
                campoApellidos_RS.Text = c.Apellidos;
                campoTelefono_RS.Text = c.Telefono.ToString();
                campoEmail_RS.Text = c.Email;
                campoDireccion_RS.Text = c.Direccion;
                campoCP_RS.Text = c.Cp.ToString();
                campoLocalidad_RS.Text = c.Localidad;
                campoNombre_RS.Enabled = false;
                campoApellidos_RS.Enabled = false;
                campoTelefono_RS.Enabled = false;
                campoEmail_RS.Enabled = false;
                campoDireccion_RS.Enabled = false;
                campoCP_RS.Enabled = false;
                campoLocalidad_RS.Enabled = false;
                botonRegistrarCliente_RS.Enabled = false;
                botonRegistrarReserva_RS.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existen clientes registrados con ese DNI");
                campoNombre_RS.Enabled = true;
                campoApellidos_RS.Enabled = true;
                campoTelefono_RS.Enabled = true;
                campoEmail_RS.Enabled = true;
                campoDireccion_RS.Enabled = true;
                campoCP_RS.Enabled = true;
                campoLocalidad_RS.Enabled = true;
                botonRegistrarCliente_RS.Enabled = true;
            }
        }

        public void BotonReserva()
        {
            DateTime d = DateTime.Now;

            if (dateEntrada_RS.Value < d)
            {
                Hotel_HRuiz.Utilidades.LanzaAlerta(this, "La fecha tiene que ser posterior a la actual");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoNumPersonas_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo numero de personas esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.EnteroCorrecto(campoNumPersonas_RS))
            {
                Hotel_HRuiz.Utilidades.LanzarAlertaEntero(this, "El campo numero de personas es numerico");
            }
            else if (Hotel_HRuiz.Utilidades.ComboSinSeleccionar(comboCatering_RS))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaComboVacio(this, comboCatering_RS);
            }
            else
            {
                 s = new Salon(
                    campoDni_RS.Text.ToUpper(),
                    dateEntrada_RS.Value,
                    int.Parse(campoNumPersonas_RS.Text),
                    comboCatering_RS.SelectedItem.ToString(),
                    ConsultasEmpleados.GuardarDNI(Login.miNombre)
                );

                Factura.Text = "";

                if (ConsultasSalones.RegistrarSalon(s))
                {
                    MessageBox.Show("Reserva registrada correctamente");
                    button3.Enabled = true; // Assuming button3 is the equivalent of botonFactura
                }
                else
                {
                    MessageBox.Show("Seleccione el tipo de catering.");
                }

            }
        }
    }
}
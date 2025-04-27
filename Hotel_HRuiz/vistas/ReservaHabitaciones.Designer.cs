using bbdd;
using Hotel_HRuiz.bbdd;
using Hotel_HRuiz.modelo;
using System.Windows.Forms;
using System;

namespace Hotel_HRuiz.vistas
{
    partial class ReservaHabitaciones
    {
        private Habitacion h;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonRegistrarCliente_RH = new System.Windows.Forms.Button();
            this.campoLocalidad_RH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.campoCP_RH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.campoDireccion_RH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.campoEmail_RH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoTelefono_RH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.campoApellidos_RH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.campoNombre_RH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botonDNI = new System.Windows.Forms.Button();
            this.campoDNI_RH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboTipo_RH = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateSalida_RH = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateEntrada_RH = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textFactura = new System.Windows.Forms.TextBox();
            this.botonFactura = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(884, 82);
            this.panel1.TabIndex = 0;
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
            this.label1.Size = new System.Drawing.Size(398, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva de habitaciones";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 20);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonRegistrarCliente_RH);
            this.groupBox1.Controls.Add(this.campoLocalidad_RH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.campoCP_RH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.campoDireccion_RH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.campoEmail_RH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.campoTelefono_RH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.campoApellidos_RH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.campoNombre_RH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.botonDNI);
            this.groupBox1.Controls.Add(this.campoDNI_RH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(32, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // botonRegistrarCliente_RH
            // 
            this.botonRegistrarCliente_RH.Location = new System.Drawing.Point(156, 263);
            this.botonRegistrarCliente_RH.Name = "botonRegistrarCliente_RH";
            this.botonRegistrarCliente_RH.Size = new System.Drawing.Size(150, 23);
            this.botonRegistrarCliente_RH.TabIndex = 17;
            this.botonRegistrarCliente_RH.Text = "Registrar Cliente";
            this.botonRegistrarCliente_RH.UseVisualStyleBackColor = true;
            this.botonRegistrarCliente_RH.Click += new System.EventHandler(this.botonRegistrarCliente_RH_Click);
            // 
            // campoLocalidad_RH
            // 
            this.campoLocalidad_RH.Location = new System.Drawing.Point(123, 226);
            this.campoLocalidad_RH.Name = "campoLocalidad_RH";
            this.campoLocalidad_RH.Size = new System.Drawing.Size(183, 20);
            this.campoLocalidad_RH.TabIndex = 16;
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
            // campoCP_RH
            // 
            this.campoCP_RH.Location = new System.Drawing.Point(123, 200);
            this.campoCP_RH.Name = "campoCP_RH";
            this.campoCP_RH.Size = new System.Drawing.Size(128, 20);
            this.campoCP_RH.TabIndex = 14;
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
            // campoDireccion_RH
            // 
            this.campoDireccion_RH.Location = new System.Drawing.Point(123, 174);
            this.campoDireccion_RH.Name = "campoDireccion_RH";
            this.campoDireccion_RH.Size = new System.Drawing.Size(231, 20);
            this.campoDireccion_RH.TabIndex = 12;
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
            // campoEmail_RH
            // 
            this.campoEmail_RH.Location = new System.Drawing.Point(123, 148);
            this.campoEmail_RH.Name = "campoEmail_RH";
            this.campoEmail_RH.Size = new System.Drawing.Size(183, 20);
            this.campoEmail_RH.TabIndex = 10;
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
            // campoTelefono_RH
            // 
            this.campoTelefono_RH.Location = new System.Drawing.Point(123, 122);
            this.campoTelefono_RH.Name = "campoTelefono_RH";
            this.campoTelefono_RH.Size = new System.Drawing.Size(128, 20);
            this.campoTelefono_RH.TabIndex = 8;
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
            // campoApellidos_RH
            // 
            this.campoApellidos_RH.Location = new System.Drawing.Point(123, 96);
            this.campoApellidos_RH.Name = "campoApellidos_RH";
            this.campoApellidos_RH.Size = new System.Drawing.Size(183, 20);
            this.campoApellidos_RH.TabIndex = 6;
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
            // campoNombre_RH
            // 
            this.campoNombre_RH.Location = new System.Drawing.Point(123, 70);
            this.campoNombre_RH.Name = "campoNombre_RH";
            this.campoNombre_RH.Size = new System.Drawing.Size(114, 20);
            this.campoNombre_RH.TabIndex = 4;
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
            // botonDNI
            // 
            this.botonDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonDNI.Location = new System.Drawing.Point(290, 22);
            this.botonDNI.Name = "botonDNI";
            this.botonDNI.Size = new System.Drawing.Size(101, 23);
            this.botonDNI.TabIndex = 2;
            this.botonDNI.Text = "Comprobar DNI";
            this.botonDNI.UseVisualStyleBackColor = true;
            this.botonDNI.Click += new System.EventHandler(this.botonDNI_Click);
            // 
            // campoDNI_RH
            // 
            this.campoDNI_RH.Location = new System.Drawing.Point(123, 24);
            this.campoDNI_RH.Name = "campoDNI_RH";
            this.campoDNI_RH.Size = new System.Drawing.Size(148, 20);
            this.campoDNI_RH.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboTipo_RH);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.dateSalida_RH);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dateEntrada_RH);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(32, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE LA RESERVA";
            // 
            // comboTipo_RH
            // 
            this.comboTipo_RH.FormattingEnabled = true;
            this.comboTipo_RH.Items.AddRange(new object[] {
            "Seleccione",
            "Sencilla",
            "Doble"});
            this.comboTipo_RH.Location = new System.Drawing.Point(174, 71);
            this.comboTipo_RH.Name = "comboTipo_RH";
            this.comboTipo_RH.Size = new System.Drawing.Size(121, 21);
            this.comboTipo_RH.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(44, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tipo de habitación";
            // 
            // dateSalida_RH
            // 
            this.dateSalida_RH.Location = new System.Drawing.Point(174, 44);
            this.dateSalida_RH.Name = "dateSalida_RH";
            this.dateSalida_RH.Size = new System.Drawing.Size(200, 20);
            this.dateSalida_RH.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(44, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Fecha de Salida";
            // 
            // dateEntrada_RH
            // 
            this.dateEntrada_RH.Location = new System.Drawing.Point(173, 14);
            this.dateEntrada_RH.Name = "dateEntrada_RH";
            this.dateEntrada_RH.Size = new System.Drawing.Size(200, 20);
            this.dateEntrada_RH.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(43, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Fecha de Entrada";
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.BackColor = System.Drawing.Color.White;
            this.botonRegistrar.Location = new System.Drawing.Point(120, 501);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(257, 23);
            this.botonRegistrar.TabIndex = 4;
            this.botonRegistrar.Text = "Registrar Reserva";
            this.botonRegistrar.UseVisualStyleBackColor = false;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(530, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Detalle de la última reserva registrada";
            // 
            // textFactura
            // 
            this.textFactura.Location = new System.Drawing.Point(533, 112);
            this.textFactura.Multiline = true;
            this.textFactura.Name = "textFactura";
            this.textFactura.Size = new System.Drawing.Size(308, 383);
            this.textFactura.TabIndex = 6;
            // 
            // botonFactura
            // 
            this.botonFactura.Location = new System.Drawing.Point(638, 501);
            this.botonFactura.Name = "botonFactura";
            this.botonFactura.Size = new System.Drawing.Size(128, 23);
            this.botonFactura.TabIndex = 7;
            this.botonFactura.Text = "Generar Factura";
            this.botonFactura.UseVisualStyleBackColor = true;
            this.botonFactura.Click += new System.EventHandler(this.botonFactura_Click);
            // 
            // ReservaHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.botonFactura);
            this.Controls.Add(this.textFactura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ReservaHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservaHabitaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botonDNI;
        private System.Windows.Forms.TextBox campoDNI_RH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Button botonRegistrarCliente_RH;
        private System.Windows.Forms.TextBox campoLocalidad_RH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox campoCP_RH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox campoDireccion_RH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox campoEmail_RH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoTelefono_RH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox campoApellidos_RH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoNombre_RH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEntrada_RH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboTipo_RH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateSalida_RH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textFactura;
        private System.Windows.Forms.Button botonFactura;

        private void ComprobarDni()
        {
            if (Hotel_HRuiz.Utilidades.CampoVacio(campoDNI_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo dni esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.FormatoDNI(campoDNI_RH.Text.ToUpper()))
            {
                Hotel_HRuiz.Utilidades.LanzarFormatoDni(this, "El formato del dni no es correcto");
            }
            else if (!Hotel_HRuiz.Utilidades.DniValido(campoDNI_RH.Text.ToUpper()))
            {
                Hotel_HRuiz.Utilidades.LanzarFormatoDniValido(this, "El dni no es valido");
            }
            else if (ConsultasClientes.ComprobarDni(campoDNI_RH.Text.ToUpper()))
            {
                Cliente c = ConsultasClientes.RescataDatosCliente(campoDNI_RH.Text.ToUpper());

                campoNombre_RH.Text = c.Nombre;
                campoApellidos_RH.Text = c.Apellidos;
                campoTelefono_RH.Text = c.Telefono.ToString();
                campoEmail_RH.Text = c.Email;
                campoDireccion_RH.Text = c.Direccion;
                campoCP_RH.Text = c.Cp.ToString();
                campoLocalidad_RH.Text = c.Localidad;
                campoNombre_RH.Enabled = false;
                campoApellidos_RH.Enabled = false;
                campoTelefono_RH.Enabled = false;
                campoEmail_RH.Enabled = false;
                campoDireccion_RH.Enabled = false;
                campoCP_RH.Enabled = false;
                campoLocalidad_RH.Enabled = false;
                botonRegistrarCliente_RH.Enabled = false;
                botonRegistrar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existen clientes registrados con ese DNI");
                campoNombre_RH.Enabled = true;
                campoApellidos_RH.Enabled = true;
                campoTelefono_RH.Enabled = true;
                campoEmail_RH.Enabled = true;
                campoDireccion_RH.Enabled = true;
                campoCP_RH.Enabled = true;
                campoLocalidad_RH.Enabled = true;
                botonRegistrarCliente_RH.Enabled = true;
            }
        }

        private void RegistrarCliente()
        {
            if (Hotel_HRuiz.Utilidades.CampoVacio(campoNombre_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo nombre esta vacio");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoApellidos_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo apellidos esta vacio");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoTelefono_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo telefono esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.EnteroCorrecto(campoTelefono_RH))
            {
                Hotel_HRuiz.Utilidades.LanzarAlertaEntero(this, "El campo telefono es numerico");
            }
            else if (!Hotel_HRuiz.Utilidades.FormatoTelefono(campoTelefono_RH.Text))
            {
                Hotel_HRuiz.Utilidades.LanzarTelefono(this, "El telefono no es valido");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoEmail_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo email esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.CorreoCorrecto(campoEmail_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCorreo(this, "El email no es valido");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoDireccion_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo direccion esta vacio");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoCP_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo cp esta vacio");
            }
            else if (!Hotel_HRuiz.Utilidades.EnteroCorrecto(campoCP_RH))
            {
                Hotel_HRuiz.Utilidades.LanzarAlertaEntero(this, "El campo cp es numerico");
            }
            else if (!Hotel_HRuiz.Utilidades.FormatoCP(campoCP_RH.Text))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCp(this, "El cp no es valido");
            }
            else if (Hotel_HRuiz.Utilidades.CampoVacio(campoLocalidad_RH))
            {
                Hotel_HRuiz.Utilidades.LanzaAlertaCampoVacio(this, "El campo localidad esta vacio");
            }
            else
            {
                Cliente c = new Cliente(
                    campoDNI_RH.Text.ToUpper(),
                    campoNombre_RH.Text,
                    campoApellidos_RH.Text,
                    int.Parse(campoTelefono_RH.Text),
                    campoEmail_RH.Text,
                    campoDireccion_RH.Text,
                    int.Parse(campoCP_RH.Text),
                    campoLocalidad_RH.Text
                );
                if (ConsultasClientes.RegistrarCliente(c))
                {
                    MessageBox.Show("Cliente registrado correctamente");

                    campoDNI_RH.Enabled = false;
                    campoNombre_RH.Enabled = false;
                    campoApellidos_RH.Enabled = false;
                    campoTelefono_RH.Enabled = false;
                    campoEmail_RH.Enabled = false;
                    campoDireccion_RH.Enabled = false;
                    campoCP_RH.Enabled = false;
                    campoLocalidad_RH.Enabled = false;
                    botonRegistrar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error en el registro. Comprueba el formulario");
                    campoDNI_RH.Enabled = true;
                    campoNombre_RH.Enabled = true;
                    campoApellidos_RH.Enabled = true;
                    campoTelefono_RH.Enabled = true;
                    campoEmail_RH.Enabled = true;
                    campoDireccion_RH.Enabled = true;
                    campoCP_RH.Enabled = true;
                    campoLocalidad_RH.Enabled = true;
                    botonRegistrar.Enabled = false;
                }
            }
        }

        private void RealizarReserva()
        {
            DateTime d = DateTime.Now.AddDays(-1);
            if (dateEntrada_RH.Value < d)
            {
                Hotel_HRuiz.Utilidades.LanzaAlerta(this, "La fecha de entrada no puede ser anterior a hoy");
                dateEntrada_RH.Value = DateTime.Now;
                dateSalida_RH.Value = DateTime.Now;
            }
            else if (dateEntrada_RH.Value > dateSalida_RH.Value)
            {
                Hotel_HRuiz.Utilidades.LanzaAlerta(this, "La fecha de salida tiene que ser mayor que la de entrada");
                dateEntrada_RH.Value = DateTime.Now;
                dateSalida_RH.Value = DateTime.Now;
            }
            else if (comboTipo_RH.SelectedItem == null)
            {
                Hotel_HRuiz.Utilidades.LanzaAlerta(this, "Selecciona un tipo de habitacion.");
            }
            else
            {
                string tipoHabitacion = comboTipo_RH.SelectedItem.ToString();

                TimeSpan diferencia = dateSalida_RH.Value - dateEntrada_RH.Value;
                int numeroNoches = diferencia.Days;

                 h = new Habitacion(
                    campoDNI_RH.Text.ToUpper(),
                    dateEntrada_RH.Value,
                    dateSalida_RH.Value,
                    tipoHabitacion,
                    numeroNoches,
                    ConsultasEmpleados.GuardarDNI(Login.miNombre)
                );

                textFactura.Text = "";

                if (ConsultasHabitaciones.RegistrarHabitacion(h))
                {
                    MessageBox.Show("Reserva registrada correctamente");
                    botonFactura.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Meh...comprueba los datos introducidos en general.");
                }
            }
        }

        public void ImprimirFactura()
        {
            String texto = h.ToString();
            textFactura.Text = texto;
        }
    }

}
using bbdd;
using Hotel_HRuiz.bbdd;
using Hotel_HRuiz.modelo;
using System.Windows.Forms;
using System;

namespace Hotel_HRuiz.vistas
{
    partial class AltaEmpleado
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
            this.botonRegistrarEmpleado_RE = new System.Windows.Forms.Button();
            this.campoSalario_RE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.campoEmail_RE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoTelefono_RE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.campoNombre_RE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.campoDni_RE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.campoPass_RE = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.campoUsuario_RE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboTurno_RE = new System.Windows.Forms.ComboBox();
            this.dateTimeContrato_RE = new System.Windows.Forms.DateTimePicker();
            this.campoApellidos_RE = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonRegistrarEmpleado_RE
            // 
            this.botonRegistrarEmpleado_RE.BackColor = System.Drawing.SystemColors.Window;
            this.botonRegistrarEmpleado_RE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botonRegistrarEmpleado_RE.Location = new System.Drawing.Point(144, 336);
            this.botonRegistrarEmpleado_RE.Name = "botonRegistrarEmpleado_RE";
            this.botonRegistrarEmpleado_RE.Size = new System.Drawing.Size(150, 23);
            this.botonRegistrarEmpleado_RE.TabIndex = 17;
            this.botonRegistrarEmpleado_RE.Text = "Registrar Empleado";
            this.botonRegistrarEmpleado_RE.UseVisualStyleBackColor = false;
            this.botonRegistrarEmpleado_RE.Click += new System.EventHandler(this.botonRegistrarEmpleado_RE_Click);
            // 
            // campoSalario_RE
            // 
            this.campoSalario_RE.Location = new System.Drawing.Point(156, 226);
            this.campoSalario_RE.Name = "campoSalario_RE";
            this.campoSalario_RE.Size = new System.Drawing.Size(128, 20);
            this.campoSalario_RE.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(40, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Salario Base";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(40, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Turno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(40, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha de Contrato";
            // 
            // campoEmail_RE
            // 
            this.campoEmail_RE.Location = new System.Drawing.Point(156, 148);
            this.campoEmail_RE.Name = "campoEmail_RE";
            this.campoEmail_RE.Size = new System.Drawing.Size(183, 20);
            this.campoEmail_RE.TabIndex = 10;
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
            // campoTelefono_RE
            // 
            this.campoTelefono_RE.Location = new System.Drawing.Point(156, 122);
            this.campoTelefono_RE.Name = "campoTelefono_RE";
            this.campoTelefono_RE.Size = new System.Drawing.Size(128, 20);
            this.campoTelefono_RE.TabIndex = 8;
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
            // campoNombre_RE
            // 
            this.campoNombre_RE.Location = new System.Drawing.Point(156, 70);
            this.campoNombre_RE.Name = "campoNombre_RE";
            this.campoNombre_RE.Size = new System.Drawing.Size(114, 20);
            this.campoNombre_RE.TabIndex = 4;
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
            // campoDni_RE
            // 
            this.campoDni_RE.Location = new System.Drawing.Point(156, 44);
            this.campoDni_RE.Name = "campoDni_RE";
            this.campoDni_RE.Size = new System.Drawing.Size(148, 20);
            this.campoDni_RE.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.campoPass_RE);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.campoUsuario_RE);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.comboTurno_RE);
            this.groupBox1.Controls.Add(this.dateTimeContrato_RE);
            this.groupBox1.Controls.Add(this.botonRegistrarEmpleado_RE);
            this.groupBox1.Controls.Add(this.campoSalario_RE);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.campoEmail_RE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.campoTelefono_RE);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.campoApellidos_RE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.campoNombre_RE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.campoDni_RE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(191, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 407);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL CLIENTE";
            // 
            // campoPass_RE
            // 
            this.campoPass_RE.Location = new System.Drawing.Point(156, 278);
            this.campoPass_RE.Name = "campoPass_RE";
            this.campoPass_RE.Size = new System.Drawing.Size(128, 20);
            this.campoPass_RE.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(40, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Contraseña";
            // 
            // campoUsuario_RE
            // 
            this.campoUsuario_RE.Location = new System.Drawing.Point(156, 252);
            this.campoUsuario_RE.Name = "campoUsuario_RE";
            this.campoUsuario_RE.Size = new System.Drawing.Size(128, 20);
            this.campoUsuario_RE.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(40, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Usuario";
            // 
            // comboTurno_RE
            // 
            this.comboTurno_RE.FormattingEnabled = true;
            this.comboTurno_RE.Location = new System.Drawing.Point(156, 201);
            this.comboTurno_RE.Name = "comboTurno_RE";
            this.comboTurno_RE.Size = new System.Drawing.Size(121, 21);
            this.comboTurno_RE.TabIndex = 19;
            // 
            // dateTimeContrato_RE
            // 
            this.dateTimeContrato_RE.Location = new System.Drawing.Point(156, 175);
            this.dateTimeContrato_RE.Name = "dateTimeContrato_RE";
            this.dateTimeContrato_RE.Size = new System.Drawing.Size(200, 20);
            this.dateTimeContrato_RE.TabIndex = 18;
            // 
            // campoApellidos_RE
            // 
            this.campoApellidos_RE.Location = new System.Drawing.Point(156, 96);
            this.campoApellidos_RE.Name = "campoApellidos_RE";
            this.campoApellidos_RE.Size = new System.Drawing.Size(183, 20);
            this.campoApellidos_RE.TabIndex = 6;
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
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(373, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de empleados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 20);
            this.panel2.TabIndex = 5;
            // 
            // AltaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "AltaEmpleado";
            this.Text = "AltaEmpleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonRegistrarEmpleado_RE;
        private System.Windows.Forms.TextBox campoSalario_RE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox campoEmail_RE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoTelefono_RE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox campoNombre_RE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoDni_RE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox campoApellidos_RE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimeContrato_RE;
        private System.Windows.Forms.TextBox campoPass_RE;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox campoUsuario_RE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboTurno_RE;

        public void RegistrarEmp()
        {
            DateTime d = DateTime.Now;

            if (Utilidades.CampoVacio(campoDni_RE))
            {
                Utilidades.LanzaAlertaCampoVacio(this, "El campo dni esta vacio");
            }
            else if (!Utilidades.FormatoDNI(campoDni_RE.Text.ToUpper()))
            {
                Utilidades.LanzarFormatoDni(this, "El formato del dni no es correcto");
            }
            else if (!Utilidades.DniValido(campoDni_RE.Text.ToUpper()))
            {
                Utilidades.LanzarFormatoDniValido(this, "El dni no es valido");
            }
            else if (Utilidades.CampoVacio(campoNombre_RE))
            {
                Utilidades.LanzaAlertaCampoVacio(this, "El campo nombre esta vacio");
            }
            else if (Utilidades.CampoVacio(campoApellidos_RE))
            {
                Utilidades.LanzaAlertaCampoVacio(this, "El campo apellidos esta vacio");
            }
            else if (Utilidades.CampoVacio(campoTelefono_RE))
            {
                Utilidades.LanzaAlertaCampoVacio(this, "El campo telefono esta vacio");
            }
            else if (!Utilidades.EnteroCorrecto(campoTelefono_RE))
            {
                Utilidades.LanzarAlertaEntero(this, "El campo telefono es numerico");
            }
            else if (!Utilidades.FormatoTelefono(campoTelefono_RE.Text))
            {
                Utilidades.LanzarTelefono(this, "El telefono no es valido");
            }
            else if (Utilidades.CampoVacio(campoEmail_RE))
            {
                Utilidades.LanzaAlertaCampoVacio(this, "El campo email esta vacio");
            }
            else if (!Utilidades.CorreoCorrecto(campoEmail_RE))
            {
                Utilidades.LanzaAlertaCorreo(this, "El email no es valido");
            }
            else if (dateTimeContrato_RE.Value < d)
            {
                Utilidades.LanzaAlerta(this, "La fecha tiene que ser posterior a la actual");
            }
            else if (Utilidades.ComboSinSeleccionar(comboTurno_RE))
            {
                Utilidades.LanzaAlertaComboVacio(this, comboTurno_RE);
            }
            else if (Utilidades.CampoVacio(campoSalario_RE))
            {
                Utilidades.LanzaAlertaCampoVacio(this, "El campo slario base esta vacio");
            }
            else if (!Utilidades.EnteroCorrecto(campoSalario_RE))
            {
                Utilidades.LanzarAlertaEntero(this, "El campo salario base es numerico");
            }
            else if (Utilidades.CampoVacio(campoUsuario_RE))
            {
                Utilidades.LanzaAlertaCampoVacio(this, "El campo usuario esta vacio");
            }
            else if (Utilidades.CampoVacio(campoPass_RE))
            {
                Utilidades.LanzaAlertaCampoVacio(this, "El campo contraseña esta vacio");
            }
            else
            {
                Empleado e = new Empleado(
                                   campoDni_RE.Text.ToUpper(),
                                   campoNombre_RE.Text,
                                   campoApellidos_RE.Text,
                                   int.Parse(campoTelefono_RE.Text),
                                   campoEmail_RE.Text,
                                   dateTimeContrato_RE.Value,
                                   comboTurno_RE.SelectedItem.ToString(),
                                   int.Parse(campoSalario_RE.Text),
                                   campoUsuario_RE.Text,
                                   campoPass_RE.Text
                               );
                if (ConsultasEmpleados.RegistrarEmpleado(e))
                {
                    MessageBox.Show("Empleado registrado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al registrar el empleado");
                }
            }
        }
    }
}
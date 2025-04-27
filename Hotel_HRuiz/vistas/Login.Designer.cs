using Hotel_HRuiz.vistas;
using System.Windows.Forms;
using Hotel_HRuiz.bbdd;
using System;

namespace Hotel_HRuiz
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonEntrar_L = new System.Windows.Forms.Button();
            this.campoPass_L = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campoUsuario_L = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(378, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 374);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hotel_HRuiz.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(96, 279);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonEntrar_L);
            this.groupBox1.Controls.Add(this.campoPass_L);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.campoUsuario_L);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(201, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // botonEntrar_L
            // 
            this.botonEntrar_L.BackColor = System.Drawing.Color.Navy;
            this.botonEntrar_L.Location = new System.Drawing.Point(50, 160);
            this.botonEntrar_L.Margin = new System.Windows.Forms.Padding(2);
            this.botonEntrar_L.Name = "botonEntrar_L";
            this.botonEntrar_L.Size = new System.Drawing.Size(87, 25);
            this.botonEntrar_L.TabIndex = 4;
            this.botonEntrar_L.Text = "ENTRAR";
            this.botonEntrar_L.UseVisualStyleBackColor = false;
            this.botonEntrar_L.Click += new System.EventHandler(this.botonEntrar_L_Click);
            // 
            // campoPass_L
            // 
            this.campoPass_L.Location = new System.Drawing.Point(88, 104);
            this.campoPass_L.Margin = new System.Windows.Forms.Padding(2);
            this.campoPass_L.Name = "campoPass_L";
            this.campoPass_L.Size = new System.Drawing.Size(91, 20);
            this.campoPass_L.TabIndex = 3;
            this.campoPass_L.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // campoUsuario_L
            // 
            this.campoUsuario_L.Location = new System.Drawing.Point(89, 57);
            this.campoUsuario_L.Margin = new System.Windows.Forms.Padding(2);
            this.campoUsuario_L.Name = "campoUsuario_L";
            this.campoUsuario_L.Size = new System.Drawing.Size(90, 20);
            this.campoUsuario_L.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Hotel_HRuiz.Properties.Resources.hotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 413);
            this.MinimumSize = new System.Drawing.Size(650, 413);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox campoUsuario_L;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button botonEntrar_L;
        private System.Windows.Forms.TextBox campoPass_L;
        private System.Windows.Forms.Label label2;

        public static String miNombre;
        public static String miPass;

        public void Entrar()
        {
             miNombre = campoUsuario_L.Text;
             miPass = campoPass_L.Text;


            if (Conexion.Acceder(miNombre, miPass))
            {
                Principal p = new Principal();
                p.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecto", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                campoPass_L.Text = "";
                campoUsuario_L.Text = "";
            }
        }
    }
}


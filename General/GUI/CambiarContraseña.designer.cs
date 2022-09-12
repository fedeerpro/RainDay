namespace General.GUI
{
    partial class CambiarContraseña
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContraseña));
            this.txbRepiteClave = new System.Windows.Forms.TextBox();
            this.lblRepClave = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.chbMostrarPass = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCoincidencia = new System.Windows.Forms.Label();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not2)).BeginInit();
            this.SuspendLayout();
            // 
            // txbRepiteClave
            // 
            this.txbRepiteClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRepiteClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRepiteClave.Location = new System.Drawing.Point(64, 207);
            this.txbRepiteClave.Name = "txbRepiteClave";
            this.txbRepiteClave.PasswordChar = '*';
            this.txbRepiteClave.Size = new System.Drawing.Size(224, 22);
            this.txbRepiteClave.TabIndex = 24;
            this.txbRepiteClave.TextChanged += new System.EventHandler(this.txbRepiteClave_TextChanged);
            // 
            // lblRepClave
            // 
            this.lblRepClave.AutoSize = true;
            this.lblRepClave.BackColor = System.Drawing.Color.Transparent;
            this.lblRepClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRepClave.Location = new System.Drawing.Point(61, 174);
            this.lblRepClave.Name = "lblRepClave";
            this.lblRepClave.Size = new System.Drawing.Size(113, 16);
            this.lblRepClave.TabIndex = 23;
            this.lblRepClave.Text = "Repita la clave";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblClave.Location = new System.Drawing.Point(61, 94);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(97, 16);
            this.lblClave.TabIndex = 21;
            this.lblClave.Text = "Nueva Clave";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl.Location = new System.Drawing.Point(12, 42);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(63, 15);
            this.lbl.TabIndex = 25;
            this.lbl.Text = "Usuario:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(28, 15);
            this.label.TabIndex = 26;
            this.label.Text = "ID:";
            // 
            // chbMostrarPass
            // 
            this.chbMostrarPass.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbMostrarPass.AutoSize = true;
            this.chbMostrarPass.Image = ((System.Drawing.Image)(resources.GetObject("chbMostrarPass.Image")));
            this.chbMostrarPass.Location = new System.Drawing.Point(28, 120);
            this.chbMostrarPass.Name = "chbMostrarPass";
            this.chbMostrarPass.Size = new System.Drawing.Size(30, 30);
            this.chbMostrarPass.TabIndex = 27;
            this.chbMostrarPass.UseVisualStyleBackColor = true;
            this.chbMostrarPass.CheckedChanged += new System.EventHandler(this.chbMostrarPass_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(186, 292);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 35);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(71, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 35);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // Not2
            // 
            this.Not2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Not2.ContainerControl = this;
            // 
            // lblCoincidencia
            // 
            this.lblCoincidencia.AutoSize = true;
            this.lblCoincidencia.BackColor = System.Drawing.Color.Transparent;
            this.lblCoincidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoincidencia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCoincidencia.Location = new System.Drawing.Point(-3, 247);
            this.lblCoincidencia.MinimumSize = new System.Drawing.Size(380, 0);
            this.lblCoincidencia.Name = "lblCoincidencia";
            this.lblCoincidencia.Size = new System.Drawing.Size(380, 16);
            this.lblCoincidencia.TabIndex = 30;
            this.lblCoincidencia.Text = "Escriba las contraseñas correctamente";
            this.lblCoincidencia.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbClave
            // 
            this.txbClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClave.Location = new System.Drawing.Point(64, 125);
            this.txbClave.Multiline = true;
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '*';
            this.txbClave.Size = new System.Drawing.Size(224, 22);
            this.txbClave.TabIndex = 31;
            this.txbClave.TextChanged += new System.EventHandler(this.txbClave_TextChanged_1);
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblIDUsuario.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblIDUsuario.Location = new System.Drawing.Point(47, 9);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(63, 15);
            this.lblIDUsuario.TabIndex = 32;
            this.lblIDUsuario.Text = "00012345";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblUsuario.Location = new System.Drawing.Point(81, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 15);
            this.lblUsuario.TabIndex = 33;
            this.lblUsuario.Text = "Usuario000001";
            // 
            // CambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(364, 339);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.lblCoincidencia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chbMostrarPass);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txbRepiteClave);
            this.Controls.Add(this.lblRepClave);
            this.Controls.Add(this.lblClave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.CambiarContraseña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbRepiteClave;
        private System.Windows.Forms.Label lblRepClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.CheckBox chbMostrarPass;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Label lbl;
        public System.Windows.Forms.Label label;
        private System.Windows.Forms.ErrorProvider Notificador;
        private System.Windows.Forms.ErrorProvider Not2;
        private System.Windows.Forms.Label lblCoincidencia;
        private System.Windows.Forms.TextBox txbClave;
        public System.Windows.Forms.Label lblUsuario;
        public System.Windows.Forms.Label lblIDUsuario;
    }
}
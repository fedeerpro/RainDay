namespace General.GUI
{
    partial class UsuariosEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosEdicion));
            this.label1 = new System.Windows.Forms.Label();
            this.txbIDUsuario = new System.Windows.Forms.TextBox();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txbIDEmpleado = new System.Windows.Forms.TextBox();
            this.lblOpcEmp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEmpleado = new System.Windows.Forms.TextBox();
            this.txbRepiteClave = new System.Windows.Forms.TextBox();
            this.lblRepClave = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Notificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbbRol = new System.Windows.Forms.ComboBox();
            this.lblCoincidencia = new System.Windows.Forms.Label();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.Not2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chbMostrarPass = new System.Windows.Forms.CheckBox();
            this.txbClave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Usuario";
            // 
            // txbIDUsuario
            // 
            this.txbIDUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDUsuario.Location = new System.Drawing.Point(23, 56);
            this.txbIDUsuario.Name = "txbIDUsuario";
            this.txbIDUsuario.ReadOnly = true;
            this.txbIDUsuario.Size = new System.Drawing.Size(82, 22);
            this.txbIDUsuario.TabIndex = 1;
            // 
            // txbUsuario
            // 
            this.txbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(23, 106);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(224, 22);
            this.txbUsuario.TabIndex = 3;
            this.txbUsuario.TextChanged += new System.EventHandler(this.txbUsuario_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblClave.Location = new System.Drawing.Point(26, 171);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(43, 16);
            this.lblClave.TabIndex = 4;
            this.lblClave.Text = "Clave";
            // 
            // txbIDEmpleado
            // 
            this.txbIDEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIDEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDEmpleado.Location = new System.Drawing.Point(315, 77);
            this.txbIDEmpleado.Name = "txbIDEmpleado";
            this.txbIDEmpleado.ReadOnly = true;
            this.txbIDEmpleado.Size = new System.Drawing.Size(77, 22);
            this.txbIDEmpleado.TabIndex = 7;
            this.txbIDEmpleado.TextChanged += new System.EventHandler(this.txbIDEmpleado_TextChanged);
            // 
            // lblOpcEmp
            // 
            this.lblOpcEmp.AutoSize = true;
            this.lblOpcEmp.BackColor = System.Drawing.Color.Transparent;
            this.lblOpcEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpcEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblOpcEmp.Location = new System.Drawing.Point(318, 59);
            this.lblOpcEmp.Name = "lblOpcEmp";
            this.lblOpcEmp.Size = new System.Drawing.Size(71, 16);
            this.lblOpcEmp.TabIndex = 6;
            this.lblOpcEmp.Text = "Empleado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(318, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rol";
            // 
            // txbEmpleado
            // 
            this.txbEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmpleado.Location = new System.Drawing.Point(315, 106);
            this.txbEmpleado.Name = "txbEmpleado";
            this.txbEmpleado.ReadOnly = true;
            this.txbEmpleado.Size = new System.Drawing.Size(305, 22);
            this.txbEmpleado.TabIndex = 10;
            this.txbEmpleado.TextChanged += new System.EventHandler(this.txbEmpleado_TextChanged);
            // 
            // txbRepiteClave
            // 
            this.txbRepiteClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbRepiteClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbRepiteClave.Location = new System.Drawing.Point(23, 281);
            this.txbRepiteClave.Name = "txbRepiteClave";
            this.txbRepiteClave.PasswordChar = '*';
            this.txbRepiteClave.Size = new System.Drawing.Size(224, 22);
            this.txbRepiteClave.TabIndex = 15;
            this.txbRepiteClave.TextChanged += new System.EventHandler(this.txbRepiteClave_TextChanged_1);
            // 
            // lblRepClave
            // 
            this.lblRepClave.AutoSize = true;
            this.lblRepClave.BackColor = System.Drawing.Color.Transparent;
            this.lblRepClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblRepClave.Location = new System.Drawing.Point(26, 263);
            this.lblRepClave.Name = "lblRepClave";
            this.lblRepClave.Size = new System.Drawing.Size(98, 16);
            this.lblRepClave.TabIndex = 14;
            this.lblRepClave.Text = "Repita la clave";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(430, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 35);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(545, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 35);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Notificador
            // 
            this.Notificador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Notificador.ContainerControl = this;
            // 
            // cbbRol
            // 
            this.cbbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbRol.FormattingEnabled = true;
            this.cbbRol.Location = new System.Drawing.Point(315, 200);
            this.cbbRol.Name = "cbbRol";
            this.cbbRol.Size = new System.Drawing.Size(305, 24);
            this.cbbRol.TabIndex = 18;
            // 
            // lblCoincidencia
            // 
            this.lblCoincidencia.AutoSize = true;
            this.lblCoincidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoincidencia.Location = new System.Drawing.Point(26, 237);
            this.lblCoincidencia.Name = "lblCoincidencia";
            this.lblCoincidencia.Size = new System.Drawing.Size(0, 16);
            this.lblCoincidencia.TabIndex = 20;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.Image")));
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(545, 77);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(75, 22);
            this.btnBuscarEmpleado.TabIndex = 21;
            this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // Not2
            // 
            this.Not2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Not2.ContainerControl = this;
            // 
            // Not3
            // 
            this.Not3.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Not3.ContainerControl = this;
            // 
            // Not4
            // 
            this.Not4.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Not4.ContainerControl = this;
            // 
            // Not5
            // 
            this.Not5.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.Not5.ContainerControl = this;
            // 
            // chbMostrarPass
            // 
            this.chbMostrarPass.Appearance = System.Windows.Forms.Appearance.Button;
            this.chbMostrarPass.AutoSize = true;
            this.chbMostrarPass.Image = ((System.Drawing.Image)(resources.GetObject("chbMostrarPass.Image")));
            this.chbMostrarPass.Location = new System.Drawing.Point(75, 164);
            this.chbMostrarPass.Name = "chbMostrarPass";
            this.chbMostrarPass.Size = new System.Drawing.Size(30, 30);
            this.chbMostrarPass.TabIndex = 22;
            this.chbMostrarPass.UseVisualStyleBackColor = true;
            this.chbMostrarPass.CheckedChanged += new System.EventHandler(this.chbMostrarPass_CheckedChanged_1);
            // 
            // txbClave
            // 
            this.txbClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClave.Location = new System.Drawing.Point(23, 202);
            this.txbClave.Multiline = true;
            this.txbClave.Name = "txbClave";
            this.txbClave.PasswordChar = '*';
            this.txbClave.Size = new System.Drawing.Size(224, 22);
            this.txbClave.TabIndex = 32;
            this.txbClave.TextChanged += new System.EventHandler(this.txbClave_TextChanged_1);
            // 
            // UsuariosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(680, 356);
            this.Controls.Add(this.txbClave);
            this.Controls.Add(this.chbMostrarPass);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.lblCoincidencia);
            this.Controls.Add(this.cbbRol);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbRepiteClave);
            this.Controls.Add(this.lblRepClave);
            this.Controls.Add(this.txbEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbIDEmpleado);
            this.Controls.Add(this.lblOpcEmp);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txbUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIDUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UsuariosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Usuarios";
            this.Load += new System.EventHandler(this.UsuariosEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Notificador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblOpcEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRepClave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider Notificador;
        public System.Windows.Forms.TextBox txbIDUsuario;
        public System.Windows.Forms.TextBox txbUsuario;
        public System.Windows.Forms.TextBox txbIDEmpleado;
        public System.Windows.Forms.TextBox txbEmpleado;
        public System.Windows.Forms.TextBox txbRepiteClave;
        public System.Windows.Forms.ComboBox cbbRol;
        private System.Windows.Forms.Label lblCoincidencia;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.ErrorProvider Not2;
        private System.Windows.Forms.ErrorProvider Not3;
        private System.Windows.Forms.ErrorProvider Not4;
        private System.Windows.Forms.ErrorProvider Not5;
        private System.Windows.Forms.CheckBox chbMostrarPass;
        private System.Windows.Forms.TextBox txbClave;
    }
}
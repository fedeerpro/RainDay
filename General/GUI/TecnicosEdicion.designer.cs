namespace General.GUI
{
    partial class TecnicosEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TecnicosEdicion));
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbGenero = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txbNombres = new System.Windows.Forms.TextBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDUI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNIT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Not = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Not7 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Not)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not7)).BeginInit();
            this.SuspendLayout();
            // 
            // txbDireccion
            // 
            this.txbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.Location = new System.Drawing.Point(15, 277);
            this.txbDireccion.Multiline = true;
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(620, 22);
            this.txbDireccion.TabIndex = 76;
            this.txbDireccion.TextChanged += new System.EventHandler(this.txbDireccion_TextChanged);
            this.txbDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDireccion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(15, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Direccion";
            // 
            // txbApellidos
            // 
            this.txbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellidos.Location = new System.Drawing.Point(269, 110);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(224, 22);
            this.txbApellidos.TabIndex = 74;
            this.txbApellidos.TextChanged += new System.EventHandler(this.txbApellidos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 73;
            this.label2.Text = "Nombres";
            // 
            // cbbGenero
            // 
            this.cbbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGenero.FormattingEnabled = true;
            this.cbbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbbGenero.Location = new System.Drawing.Point(526, 204);
            this.cbbGenero.Name = "cbbGenero";
            this.cbbGenero.Size = new System.Drawing.Size(109, 24);
            this.cbbGenero.TabIndex = 72;
            this.cbbGenero.SelectedIndexChanged += new System.EventHandler(this.cbbGenero_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(532, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 35);
            this.btnCancelar.TabIndex = 71;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(417, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(92, 35);
            this.btnGuardar.TabIndex = 70;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl1.Location = new System.Drawing.Point(529, 185);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 16);
            this.lbl1.TabIndex = 69;
            this.lbl1.Text = "Genero";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl.Location = new System.Drawing.Point(272, 90);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(65, 16);
            this.lbl.TabIndex = 68;
            this.lbl.Text = "Apellidos";
            // 
            // txbNombres
            // 
            this.txbNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombres.Location = new System.Drawing.Point(15, 110);
            this.txbNombres.Name = "txbNombres";
            this.txbNombres.Size = new System.Drawing.Size(224, 22);
            this.txbNombres.TabIndex = 67;
            this.txbNombres.TextChanged += new System.EventHandler(this.txbNombres_TextChanged);
            // 
            // txbID
            // 
            this.txbID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbID.Enabled = false;
            this.txbID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(12, 26);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(84, 23);
            this.txbID.TabIndex = 66;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 65;
            this.label1.Text = "ID";
            // 
            // txbDUI
            // 
            this.txbDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDUI.Location = new System.Drawing.Point(526, 110);
            this.txbDUI.MaxLength = 9;
            this.txbDUI.Name = "txbDUI";
            this.txbDUI.Size = new System.Drawing.Size(109, 22);
            this.txbDUI.TabIndex = 78;
            this.txbDUI.TextChanged += new System.EventHandler(this.txbDUI_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(529, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "DUI";
            // 
            // txbNIT
            // 
            this.txbNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNIT.Location = new System.Drawing.Point(15, 206);
            this.txbNIT.MaxLength = 14;
            this.txbNIT.Name = "txbNIT";
            this.txbNIT.Size = new System.Drawing.Size(109, 22);
            this.txbNIT.TabIndex = 80;
            this.txbNIT.TextChanged += new System.EventHandler(this.txbNIT_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(18, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "NIT";
            // 
            // txbTelefono
            // 
            this.txbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.Location = new System.Drawing.Point(269, 206);
            this.txbTelefono.MaxLength = 8;
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(224, 22);
            this.txbTelefono.TabIndex = 82;
            this.txbTelefono.TextChanged += new System.EventHandler(this.txbTelefono_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(272, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 81;
            this.label6.Text = "Telefono";
            // 
            // Not
            // 
            this.Not.ContainerControl = this;
            // 
            // Not2
            // 
            this.Not2.ContainerControl = this;
            // 
            // Not3
            // 
            this.Not3.ContainerControl = this;
            // 
            // Not4
            // 
            this.Not4.ContainerControl = this;
            // 
            // Not5
            // 
            this.Not5.ContainerControl = this;
            // 
            // Not6
            // 
            this.Not6.ContainerControl = this;
            // 
            // Not7
            // 
            this.Not7.ContainerControl = this;
            // 
            // TecnicosEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(42)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(651, 380);
            this.Controls.Add(this.txbTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbNIT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDUI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbGenero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txbNombres);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TecnicosEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TecnicosEdicion";
            this.Load += new System.EventHandler(this.TecnicosEdicion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Not)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Not7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox cbbGenero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl;
        public System.Windows.Forms.TextBox txbNombres;
        public System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbDUI;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txbNIT;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider Not;
        private System.Windows.Forms.ErrorProvider Not2;
        private System.Windows.Forms.ErrorProvider Not3;
        private System.Windows.Forms.ErrorProvider Not4;
        private System.Windows.Forms.ErrorProvider Not5;
        private System.Windows.Forms.ErrorProvider Not6;
        private System.Windows.Forms.ErrorProvider Not7;
    }
}
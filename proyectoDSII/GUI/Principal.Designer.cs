namespace proyectoDSII.GUI
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ctrGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.opcMisIncidencias = new System.Windows.Forms.ToolStripMenuItem();
            this.opcGestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeTecnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeIncidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrControl = new System.Windows.Forms.ToolStripMenuItem();
            this.opcPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteGenerIncidenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteIncidenciaPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteIncidenciaPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteIncidenciaPorTecnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrGeneral,
            this.ctrControl,
            this.ctrInformes,
            this.ctrSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // ctrGeneral
            // 
            this.ctrGeneral.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcMisIncidencias,
            this.opcGestionUsuarios,
            this.gestionDeEmpleadosToolStripMenuItem,
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeTecnicosToolStripMenuItem,
            this.gestionDeEquiposToolStripMenuItem,
            this.gestionDeIncidenciasToolStripMenuItem});
            this.ctrGeneral.Name = "ctrGeneral";
            this.ctrGeneral.Size = new System.Drawing.Size(59, 20);
            this.ctrGeneral.Text = "General";
            this.ctrGeneral.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // opcMisIncidencias
            // 
            this.opcMisIncidencias.Name = "opcMisIncidencias";
            this.opcMisIncidencias.Size = new System.Drawing.Size(192, 22);
            this.opcMisIncidencias.Text = "Ver mis incidencias";
            this.opcMisIncidencias.Click += new System.EventHandler(this.opcMisIncidencias_Click);
            // 
            // opcGestionUsuarios
            // 
            this.opcGestionUsuarios.Name = "opcGestionUsuarios";
            this.opcGestionUsuarios.Size = new System.Drawing.Size(192, 22);
            this.opcGestionUsuarios.Text = "Gestion de usuarios";
            this.opcGestionUsuarios.Click += new System.EventHandler(this.gestionDeUsuariosToolStripMenuItem_Click);
            // 
            // gestionDeEmpleadosToolStripMenuItem
            // 
            this.gestionDeEmpleadosToolStripMenuItem.Name = "gestionDeEmpleadosToolStripMenuItem";
            this.gestionDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionDeEmpleadosToolStripMenuItem.Text = "Gestion de empleados";
            this.gestionDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEmpleadosToolStripMenuItem_Click_1);
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de clientes";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // gestionDeTecnicosToolStripMenuItem
            // 
            this.gestionDeTecnicosToolStripMenuItem.Name = "gestionDeTecnicosToolStripMenuItem";
            this.gestionDeTecnicosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionDeTecnicosToolStripMenuItem.Text = "Gestion de tecnicos";
            this.gestionDeTecnicosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeTecnicosToolStripMenuItem_Click_1);
            // 
            // gestionDeEquiposToolStripMenuItem
            // 
            this.gestionDeEquiposToolStripMenuItem.Name = "gestionDeEquiposToolStripMenuItem";
            this.gestionDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionDeEquiposToolStripMenuItem.Text = "Gestion de equipos";
            this.gestionDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEquiposToolStripMenuItem_Click_1);
            // 
            // gestionDeIncidenciasToolStripMenuItem
            // 
            this.gestionDeIncidenciasToolStripMenuItem.Name = "gestionDeIncidenciasToolStripMenuItem";
            this.gestionDeIncidenciasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionDeIncidenciasToolStripMenuItem.Text = "Gestion de incidencias";
            this.gestionDeIncidenciasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeIncidenciasToolStripMenuItem_Click);
            // 
            // ctrControl
            // 
            this.ctrControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcPermisos,
            this.gestionDeOpcionesToolStripMenuItem,
            this.gestionDeRolesToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.ctrControl.Name = "ctrControl";
            this.ctrControl.Size = new System.Drawing.Size(59, 20);
            this.ctrControl.Text = "Control";
            // 
            // opcPermisos
            // 
            this.opcPermisos.Name = "opcPermisos";
            this.opcPermisos.Size = new System.Drawing.Size(181, 22);
            this.opcPermisos.Text = "Gestion de permisos";
            this.opcPermisos.Click += new System.EventHandler(this.opcPermisos_Click);
            // 
            // gestionDeOpcionesToolStripMenuItem
            // 
            this.gestionDeOpcionesToolStripMenuItem.Name = "gestionDeOpcionesToolStripMenuItem";
            this.gestionDeOpcionesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gestionDeOpcionesToolStripMenuItem.Text = "Gestion de opciones";
            this.gestionDeOpcionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeOpcionesToolStripMenuItem_Click);
            // 
            // gestionDeRolesToolStripMenuItem
            // 
            this.gestionDeRolesToolStripMenuItem.Name = "gestionDeRolesToolStripMenuItem";
            this.gestionDeRolesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gestionDeRolesToolStripMenuItem.Text = "Gestion de roles";
            this.gestionDeRolesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeRolesToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // ctrInformes
            // 
            this.ctrInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteGenerIncidenciasToolStripMenuItem,
            this.reporteIncidenciaPorEmpleadoToolStripMenuItem,
            this.reporteIncidenciaPorClienteToolStripMenuItem,
            this.reporteIncidenciaPorTecnicoToolStripMenuItem});
            this.ctrInformes.Name = "ctrInformes";
            this.ctrInformes.Size = new System.Drawing.Size(66, 20);
            this.ctrInformes.Text = "Informes";
            // 
            // reporteGenerIncidenciasToolStripMenuItem
            // 
            this.reporteGenerIncidenciasToolStripMenuItem.Name = "reporteGenerIncidenciasToolStripMenuItem";
            this.reporteGenerIncidenciasToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.reporteGenerIncidenciasToolStripMenuItem.Text = "Reporte general de incidencias";
            this.reporteGenerIncidenciasToolStripMenuItem.Click += new System.EventHandler(this.reporteGenerIncidenciasToolStripMenuItem_Click);
            // 
            // reporteIncidenciaPorEmpleadoToolStripMenuItem
            // 
            this.reporteIncidenciaPorEmpleadoToolStripMenuItem.Name = "reporteIncidenciaPorEmpleadoToolStripMenuItem";
            this.reporteIncidenciaPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.reporteIncidenciaPorEmpleadoToolStripMenuItem.Text = "Reporte de incidencias por empleado";
            this.reporteIncidenciaPorEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.reporteIncidenciaPorEmpleadoToolStripMenuItem_Click);
            // 
            // reporteIncidenciaPorClienteToolStripMenuItem
            // 
            this.reporteIncidenciaPorClienteToolStripMenuItem.Name = "reporteIncidenciaPorClienteToolStripMenuItem";
            this.reporteIncidenciaPorClienteToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.reporteIncidenciaPorClienteToolStripMenuItem.Text = "Reporte de incidencias por cliente";
            this.reporteIncidenciaPorClienteToolStripMenuItem.Click += new System.EventHandler(this.reporteIncidenciaPorClienteToolStripMenuItem_Click);
            // 
            // reporteIncidenciaPorTecnicoToolStripMenuItem
            // 
            this.reporteIncidenciaPorTecnicoToolStripMenuItem.Name = "reporteIncidenciaPorTecnicoToolStripMenuItem";
            this.reporteIncidenciaPorTecnicoToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.reporteIncidenciaPorTecnicoToolStripMenuItem.Text = "Reporte de incidencias por tecnico";
            this.reporteIncidenciaPorTecnicoToolStripMenuItem.Click += new System.EventHandler(this.reporteIncidenciaPorTecnicoToolStripMenuItem_Click);
            // 
            // ctrSalir
            // 
            this.ctrSalir.Name = "ctrSalir";
            this.ctrSalir.Size = new System.Drawing.Size(87, 20);
            this.ctrSalir.Text = "Cerrar sesion";
            this.ctrSalir.Click += new System.EventHandler(this.ctrSalir_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1004, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblRol});
            this.statusStrip.Location = new System.Drawing.Point(0, 576);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1004, 33);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(75, 28);
            this.lblUsuario.Text = "Usuario";
            // 
            // lblRol
            // 
            this.lblRol.Image = ((System.Drawing.Image)(resources.GetObject("lblRol.Image")));
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(48, 28);
            this.lblRol.Text = "Rol";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 609);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel lblRol;
        private System.Windows.Forms.ToolStripMenuItem ctrGeneral;
        private System.Windows.Forms.ToolStripMenuItem opcGestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem ctrControl;
        private System.Windows.Forms.ToolStripMenuItem ctrInformes;
        private System.Windows.Forms.ToolStripMenuItem ctrSalir;
        private System.Windows.Forms.ToolStripMenuItem opcPermisos;
        private System.Windows.Forms.ToolStripMenuItem opcMisIncidencias;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeTecnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeIncidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeRolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteGenerIncidenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteIncidenciaPorTecnicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteIncidenciaPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteIncidenciaPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
    }
}




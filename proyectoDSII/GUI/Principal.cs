using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoDSII.GUI
{
    public partial class Principal : Form
    {
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;

        void VerificiarPermisos()
        {
            int contCtrControl = 0, contCtrInformes = 0;
            try
            {
                for (int i = 0; i < ctrGeneral.DropDownItems.Count; i++)
                {
                    if (!oSesion.VerificarPermisos(ctrGeneral.DropDownItems[i].Text))
                    {
                        ctrGeneral.DropDownItems[i].Visible = false;
                    }
                }

                for (int i = 0; i < ctrControl.DropDownItems.Count; i++)
                {
                    if (!oSesion.VerificarPermisos(ctrControl.DropDownItems[i].Text))
                    {
                        ctrControl.DropDownItems[i].Visible = false;
                        contCtrControl++;
                    }
                }
                
                for (int i = 0; i < ctrInformes.DropDownItems.Count; i++)
                {
                    if (!oSesion.VerificarPermisos(ctrInformes.DropDownItems[i].Text))
                    {
                        ctrInformes.DropDownItems[i].Visible = false;
                        contCtrInformes++;
                    }
                }

                if (ctrControl.DropDownItems.Count == contCtrControl)
                {
                    ctrControl.Visible = false;
                }

                if (ctrInformes.DropDownItems.Count == contCtrInformes)
                {
                    ctrInformes.Visible = false;
                }

            }
            catch (Exception)
            {

            }

        }

        public Principal()
        {
            InitializeComponent();
            lblUsuario.Text = oSesion.Usuario;
            lblRol.Text = oSesion.Rol;
            VerificiarPermisos();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oSesion.VerificarPermisos(opcGestionUsuarios.Text))
            {
                General.GUI.UsuariosGestion f = new General.GUI.UsuariosGestion();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void ctrSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesion?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        
        private void gestionDeEmpleadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (oSesion.VerificarPermisos(gestionDeEmpleadosToolStripMenuItem.Text))
            {
                General.GUI.EmpleadosGestion f = new General.GUI.EmpleadosGestion();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oSesion.VerificarPermisos(gestionDeClientesToolStripMenuItem.Text))
            {
                General.GUI.ClientesGestion f = new General.GUI.ClientesGestion();
                f.MdiParent = this;
                f.Show();
            }
        }
        

        private void gestionDeTecnicosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (oSesion.VerificarPermisos(gestionDeTecnicosToolStripMenuItem.Text))
            {
                General.GUI.TecnicosGestion f = new General.GUI.TecnicosGestion();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void gestionDeEquiposToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (oSesion.VerificarPermisos(gestionDeEquiposToolStripMenuItem.Text))
            {
                General.GUI.EquiposGestion f = new General.GUI.EquiposGestion();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void gestionDeIncidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            General.GUI.GestionDeIncidencias f = new General.GUI.GestionDeIncidencias();
            f.MdiParent = this;
            f.Rol = oSesion.Rol;
            f.ID = oSesion.IDEmpleado;
            f.OpcEmp = oSesion.OpcEmpleado;
            f.Show();
        }

        private void opcMisIncidencias_Click(object sender, EventArgs e)
        {
            General.GUI.GestionDeIncidencias f = new General.GUI.GestionDeIncidencias();
            f.MdiParent = this;
            f.OpcEmp = oSesion.OpcEmpleado;
            f.ID = oSesion.IDEmpleado;
            f.Rol = oSesion.Rol;
            f.Show();
        }

        private void opcPermisos_Click(object sender, EventArgs e)
        {
            Controles.GUI.Permisos f = new Controles.GUI.Permisos();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controles.GUI.OpcionesGestion f = new Controles.GUI.OpcionesGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void gestionDeRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controles.GUI.RolesGestion f = new Controles.GUI.RolesGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void reporteEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void reporteGenerIncidenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes.GUI.VisorIncidenciasGeneral f = new Informes.GUI.VisorIncidenciasGeneral();
            f.MdiParent = this;
            f.Show();
        }

        private void reporteIncidenciaPorTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes.GUI.VisorIncidenciasPorTecnico f = new Informes.GUI.VisorIncidenciasPorTecnico();
            f.MdiParent = this;
            f.Show();
        }

        private void reporteIncidenciaPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes.GUI.VisorIncidenciasPorEmpleado f = new Informes.GUI.VisorIncidenciasPorEmpleado();
            f.MdiParent = this;
            f.Show();
        }

        private void reporteIncidenciaPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes.GUI.VisorIncidenciasPorCliente f = new Informes.GUI.VisorIncidenciasPorCliente();
            f.MdiParent = this;
            f.Show();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controles.GUI.LogsGestion f = new Controles.GUI.LogsGestion();
            f.MdiParent = this;
            f.Show();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            CLS.Logs log = new CLS.Logs();
            log.User = lblUsuario.Text;
            log.Detalle = "El usuario " + log.User + " cerro la sesion";
            log.Agregar();
        }
    }
}

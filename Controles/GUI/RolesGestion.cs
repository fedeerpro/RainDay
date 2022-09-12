using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles.GUI
{
    public partial class RolesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDRolSeleccionado;
        String _RolSeleccionado;
        Boolean _Seleccionado = false;
        Boolean _SELECCION = false;

        public string IDRolSeleccionado
        {
            get
            {
                return _IDRolSeleccionado;
            }

            set
            {
                _IDRolSeleccionado = value;
            }
        }

        public string RolSeleccionado
        {
            get
            {
                return _RolSeleccionado;
            }

            set
            {
                _RolSeleccionado = value;
            }
        }

        public bool Seleccionado
        {
            get
            {
                return _Seleccionado;
            }

            set
            {
                _Seleccionado = value;
            }
        }

        public bool SELECCION
        {
            get
            {
                return _SELECCION;
            }

            set
            {
                _SELECCION = value;
            }
        }

        private void Ventana()
        {
            if (!this.SELECCION)
            {
                btnSeleccionar.Visible = false;
                toolStripSeparator5.Visible = false;
            }
            else
            {
                btnAgregar.Visible = false;
                btnEditar.Visible = false;
                btnEliminar.Visible = false;
                toolStripSeparator1.Visible = false;
                toolStripSeparator2.Visible = false;
                toolStripSeparator3.Visible = false;
            }
        }

        
        public RolesGestion()
        {
            InitializeComponent();
        }
        private void OpcionesGestion_Load(object sender, EventArgs e)
        {
            Ventana();
            CargarDatos();
        }
        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_ROLES2();
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;
                lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                IDRolSeleccionado = dtgDatos.CurrentRow.Cells["IDRol"].Value.ToString();
                RolSeleccionado= dtgDatos.CurrentRow.Cells["Rol"].Value.ToString();
                Seleccionado = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GUI.RolesEdicion v = new GUI.RolesEdicion();
            v.ShowDialog();
            CargarDatos();
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.RolesEdicion v = new RolesEdicion();
                    v.txbID.Text = dtgDatos.CurrentRow.Cells["IDRol"].Value.ToString();
                    v.txbRol.Text = dtgDatos.CurrentRow.Cells["Rol"].Value.ToString();
                    v.ShowDialog();
                    CargarDatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Roles opc = new CLS.Roles();
                opc.IDRol= dtgDatos.CurrentRow.Cells["IDRol"].Value.ToString();

                if (opc.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class EquiposGestion : Form
    {
        DataTable _Prueba = new DataTable();
        BindingSource _DATOS = new BindingSource();
        String _IDEquipoSeleccionado;
        String _EquipoSeleccionado;
        Boolean _Seleccionado = false;
        Boolean _SELECCION = false;

        public string IDEquipoSeleccionado
        {
            get
            {
                return _IDEquipoSeleccionado;
            }

            set
            {
                _IDEquipoSeleccionado = value;
            }
        }

        public string EquipoSeleccionado
        {
            get
            {
                return _EquipoSeleccionado;
            }

            set
            {
                _EquipoSeleccionado = value;
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
        
        String ObtenerUltimaPC()
        {
            String PC = "";
            int cont = 0;

            _Prueba = DataSource.Consultas.TODOS_LOS_EQUIPOS();
            cont = _Prueba.Rows.Count;
            if (cont > 0)
            {
                PC = _Prueba.Rows[cont - 1]["Equipo"].ToString();
            }
            else
            {
                PC = "VACIO";
            }

            return PC;
        }

        private void Ventana()
        {
            if (!this._SELECCION)
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

        private void Filtrar()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = "Equipo LIKE '%" + txbFiltro.Text + "%'";
                }
                else
                {
                    _DATOS.RemoveFilter();
                }
                dtgDatos.AutoGenerateColumns = false;
                dtgDatos.DataSource = _DATOS;
                lblRegistros.Text = dtgDatos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_EQUIPOS();
                Filtrar();
            }
            catch (Exception)
            {

            }
        }

        public EquiposGestion()
        {
            InitializeComponent();
        }

        private void EquiposGestion_Load(object sender, EventArgs e)
        {
            Ventana();
            CargarDatos();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDEquipoSeleccionado = dtgDatos.CurrentRow.Cells["IDEquipo"].Value.ToString();
                _EquipoSeleccionado = dtgDatos.CurrentRow.Cells["Equipo"].Value.ToString();
                _Seleccionado = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Equipos Eq = new CLS.Equipos();
                Eq.IDEquipo = dtgDatos.CurrentRow.Cells["IDEquipo"].Value.ToString();

                if (Eq.BuscarEquipo_EnIncidencias())
                {

                    if (Eq.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Este equipo no se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {   
            EquipoEdicion v = new EquipoEdicion();
            v.PC = ObtenerUltimaPC();
            v.ShowDialog();
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.EquipoEdicion v = new EquipoEdicion();
                    v.txbID.Text = dtgDatos.CurrentRow.Cells["IDEquipo"].Value.ToString();
                    v.lblInfo.Text = "";
                    v.txbEquipo.Text = dtgDatos.CurrentRow.Cells["Equipo"].Value.ToString();
                    v.txbDetalles.Text = dtgDatos.CurrentRow.Cells["Detalles"].Value.ToString();
                    v.ShowDialog();
                    CargarDatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}

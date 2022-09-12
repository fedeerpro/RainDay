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
    public partial class EmpleadosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDEmpleadoSeleccionado;
        String _EmpleadoSeleccionado;
        Boolean _Seleccionado = false;
        Boolean _SELECCION = false;

        String _Genero = "";
        public string IDEmpleadoSeleccionado
        {
            get
            {
                return _IDEmpleadoSeleccionado;
            }
            
        }

        public string EmpleadoSeleccionado
        {
            get
            {
                return _EmpleadoSeleccionado;
            }
        }

        public bool Seleccionado
        {
            get
            {
                return _Seleccionado;
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

        private String ObtenerGenero(String dato)
        {
            String g = "";

            if (dato.Equals("M") || dato.Equals("m"))
            {
                g = "Masculino";
            }
            else
            {
                g = "Femenino";
            }


            return g;
        }

        private String ObtenerGenero2()
        {
            String G = "";

            if (cbbFiltroGenero.Text.Equals("Masculino"))
            {
                G = "M";
            }
            else
            {
                G = "F";
            }

            return G;
        }

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_EMPLEADOS();
                if (cbbFiltroGenero.Text != "Todos")
                {
                    FiltrarGenero();
                }
                else
                {
                    Filtrar();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Filtrar()
        {
            try
            {
                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = "Nombres LIKE '%" + txbFiltro.Text + "%' OR Apellidos LIKE '%" + txbFiltro.Text + "%'";
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

        private void FiltrarGenero()
        {
            try
            {
                if (cbbFiltroGenero.Text.Length > 0)
                {
                    _DATOS.Filter = "Genero LIKE '%"+ ObtenerGenero2() + "%'";
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

        public EmpleadosGestion()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDEmpleadoSeleccionado = dtgDatos.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                _EmpleadoSeleccionado = dtgDatos.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                _Seleccionado = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void EmpleadosGestion_Load(object sender, EventArgs e)
        {
            Ventana();
            CargarDatos();
            cbbFiltroGenero.SelectedItem = "Todos";
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            cbbFiltroGenero.Text = "Todos";
            Filtrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GUI.EmpleadosEdicion v = new EmpleadosEdicion();
            v.ShowDialog();
            //cbbFiltroGenero.Text = "Todos";
            CargarDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.EmpleadosEdicion v = new EmpleadosEdicion();
                    v.txbID.Text = dtgDatos.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                    v.txbNombres.Text = dtgDatos.CurrentRow.Cells["Nombres"].Value.ToString();
                    v.txbApellidos.Text = dtgDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                    _Genero = dtgDatos.CurrentRow.Cells["Genero"].Value.ToString();

                    v.cbbGenero.Text = ObtenerGenero(_Genero); 
                    v.ShowDialog();
                    //cbbFiltroGenero.Text = "Todos";
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
                CLS.Empleados Emp = new CLS.Empleados();
                Emp.IDEmpleado = dtgDatos.CurrentRow.Cells["IDEmpleado"].Value.ToString();

                if (Emp.BuscarEmp_EnUsuarios())
                {

                    if (Emp.Eliminar())
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                        //cbbFiltroGenero.Text = "Todos";
                    }
                    else
                    {
                        MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Este empleado no se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //cbbFiltroGenero.Text = "Todos";
                }

            }
        }

        private void EmpleadosGestion_Enter(object sender, EventArgs e)
        {

        }

        private void cbbFiltroGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbFiltroGenero.Text != "Todos")
            {
                FiltrarGenero();
            }
            else
            {
                Filtrar();
            }
            
        }

        private void cbbFiltroGenero_Click(object sender, EventArgs e)
        {

        }
    }
}

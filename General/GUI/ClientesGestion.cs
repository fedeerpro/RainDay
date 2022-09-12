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
    public partial class ClientesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDClienteSeleccionado;
        String _ClienteSeleccionado;
        Boolean _Seleccionado = false;
        Boolean _SELECCION = false;
        String _Genero = "";

        public string IDClienteSeleccionado
        {
            get
            {
                return _IDClienteSeleccionado;
            }
        }

        public string ClienteSeleccionado
        {
            get
            {
                return _ClienteSeleccionado;
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
                _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_CLIENTES();
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
                    _DATOS.Filter = "Nombres LIKE '%" + txbFiltro.Text + "%' OR Apellidos LIKE '%" + txbFiltro.Text + "%' OR Direccion LIKE '%" + txbFiltro + "%'";
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
                    _DATOS.Filter = "Genero LIKE '%" + ObtenerGenero2() + "%'";
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
        
        public ClientesGestion()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                _IDClienteSeleccionado = dtgDatos.CurrentRow.Cells["IDCliente"].Value.ToString();
                _ClienteSeleccionado = dtgDatos.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                _Seleccionado = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void ClientesGestion_Load(object sender, EventArgs e)
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
            GUI.ClienteEdicion v = new GUI.ClienteEdicion();
            v.ShowDialog();
            CargarDatos();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.ClienteEdicion v = new ClienteEdicion();
                    v.txbID.Text = dtgDatos.CurrentRow.Cells["IDCliente"].Value.ToString();
                    v.txbNombres.Text = dtgDatos.CurrentRow.Cells["Nombres"].Value.ToString();
                    v.txbApellidos.Text = dtgDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                    v.txbDireccion.Text = dtgDatos.CurrentRow.Cells["Direccion"].Value.ToString();
                    _Genero = dtgDatos.CurrentRow.Cells["Genero"].Value.ToString();

                    v.cbbGenero.Text = ObtenerGenero(_Genero);
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
            try
            {
                if (MessageBox.Show("¿Está seguro de ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CLS.Clientes Emp = new CLS.Clientes();
                    Emp.IDCliente = dtgDatos.CurrentRow.Cells["IDCliente"].Value.ToString();

                    if (Emp.BuscarCliente_EnUsuariosCliente())
                    {

                        if (Emp.Eliminar())
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
                        MessageBox.Show("Este cliente no se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            catch (Exception)
            {
            }
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

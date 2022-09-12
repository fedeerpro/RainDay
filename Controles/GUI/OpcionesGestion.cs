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
    public partial class OpcionesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();
        String _IDOpcionSeleccionada;
        String _OpcionSeleccionada;
        Boolean _Seleccionado = false;
        Boolean _SELECCION = false;

        public string IDOpcionSeleccionada
        {
            get
            {
                return _IDOpcionSeleccionada;
            }

            set
            {
                _IDOpcionSeleccionada = value;
            }
        }

        public string OpcionSeleccionada
        {
            get
            {
                return _OpcionSeleccionada;
            }

            set
            {
                _OpcionSeleccionada = value;
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

        
        public OpcionesGestion()
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
                _DATOS.DataSource = DataSource.Consultas.TODAS_LAS_OPCIONES();
                //dtgDatos.AutoGenerateColumns = false;
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
                _IDOpcionSeleccionada = dtgDatos.CurrentRow.Cells["IDOpcion"].Value.ToString();
                _OpcionSeleccionada= dtgDatos.CurrentRow.Cells["Opcion"].Value.ToString();
                _Seleccionado = true;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar el registro");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GUI.OpcionEdicion v = new GUI.OpcionEdicion();
            v.ShowDialog();
            CargarDatos();
        }
        
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.OpcionEdicion v = new OpcionEdicion();
                    v.txbID.Text = dtgDatos.CurrentRow.Cells["IDOpcion"].Value.ToString();
                    v.txbOpcion.Text = dtgDatos.CurrentRow.Cells["Opcion"].Value.ToString();
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
                CLS.Opciones opc = new CLS.Opciones ();
                opc.IDOpcion= dtgDatos.CurrentRow.Cells["IDOpcion"].Value.ToString();

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

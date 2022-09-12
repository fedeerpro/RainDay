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
    public partial class UsuariosGestion : Form
    {

        BindingSource _DATOS = new BindingSource();
        
        private void CargarDatos()
        {
            try
            {
                switch (cbbVerUsuarios.Text)
                {
                    case "Empleado":
                        {
                            _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_USUARIOS();
                        }
                        break;

                    case "Cliente":
                        { 
                            _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_USUARIOS_CLIENTE();
                        }
                        break;

                    case "Tecnico":
                        {

                            _DATOS.DataSource = DataSource.Consultas.TODOS_LOS_USUARIOS_TECNICO();

                        }
                        break;
                }

                Filtrar();



            }
            catch (Exception)
            {
                MessageBox.Show("Excepcion");
            }
        }

        private void Filtrar()
        {
            try
            {

                if (txbFiltro.TextLength > 0)
                {
                    _DATOS.Filter = "Usuario LIKE '%" + txbFiltro.Text + "%' OR Nombres LIKE '%" + txbFiltro.Text + "%' OR Apellidos LIKE '%" + txbFiltro.Text + "%'";
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

        private void DesactivarControles()
        {
            if (cbbVerUsuarios.Text.Length == 0)
            {
                btnAgregar.Enabled = false;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCambiarContraseña.Enabled = false;
                txbFiltro.Enabled = false;
            }
        }

        private void ActivarControles()
        {
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCambiarContraseña.Enabled = true;
            txbFiltro.Enabled = true;
        }

        public UsuariosGestion()
        {
            InitializeComponent();
        }

        private void UsuariosGestion_Load(object sender, EventArgs e)
        {
            DesactivarControles();
            
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                GUI.UsuariosEdicion f = new UsuariosEdicion();
                f.VerUsuarios = cbbVerUsuarios.Text;
                f.ShowDialog();
                CargarDatos();

            }
            catch (Exception)
            {


            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    switch (cbbVerUsuarios.Text)
                    {
                        case "Empleado":
                            {
                                CLS.Usuarios oUsuario = new CLS.Usuarios();
                                oUsuario.IDUsuario = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();
                                if (oUsuario.Eliminar())
                                {
                                    MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            break;

                        case "Cliente":
                            {
                                CLS.Usuarios oUsuario = new CLS.Usuarios();
                                oUsuario.IDUsuario = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();
                                if (oUsuario.Usuarios_Cliente_Eliminar())
                                {
                                    MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            break;

                        case "Tecnico":
                            {
                                CLS.Usuarios oUsuario = new CLS.Usuarios();
                                oUsuario.IDUsuario = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();
                                if (oUsuario.Usuarios_Tecnico_Eliminar())
                                {
                                    MessageBox.Show("Registro eliminado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CargarDatos();
                                }
                                else
                                {
                                    MessageBox.Show("El registro no fue eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                            break;
                    }






                    

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.UsuariosEdicion f = new UsuariosEdicion();
                    f.Usuario = dtgDatos.CurrentRow.Cells["Usuario"].Value.ToString();
                    f.txbIDUsuario.Text = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();
                    f.txbUsuario.Text = dtgDatos.CurrentRow.Cells["Usuario"].Value.ToString();
                    f.txbIDEmpleado.Text = dtgDatos.CurrentRow.Cells["IDEmpleado"].Value.ToString();
                    f.txbEmpleado.Text = dtgDatos.CurrentRow.Cells["Nombres"].Value.ToString() + " " + dtgDatos.CurrentRow.Cells["Apellidos"].Value.ToString();
                    f.cbbRol.Text = dtgDatos.CurrentRow.Cells["Rol"].Value.ToString();
                    f.VerUsuarios = cbbVerUsuarios.Text;
                    f.ShowDialog();
                    CargarDatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro de cambiar la contraseña del registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GUI.CambiarContraseña v = new CambiarContraseña();

                    v.lblIDUsuario.Text = dtgDatos.CurrentRow.Cells["IDUsuario"].Value.ToString();
                    v.lblUsuario.Text = dtgDatos.CurrentRow.Cells["Usuario"].Value.ToString();
                    v.VerUsuarios = cbbVerUsuarios.Text;                    
                    v.ShowDialog();
                    CargarDatos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una fila válida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void cbbVerUsuarios_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbbVerUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            c++;
            CargarDatos();

            if (c == 1)
            {
                ActivarControles();
            }
        }
    }
}
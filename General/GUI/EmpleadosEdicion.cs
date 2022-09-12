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
    public partial class EmpleadosEdicion : Form
    {
        
        public EmpleadosEdicion()
        {
            InitializeComponent();
        }

        private String ObtenerGenero()
        {
            String G ="";

            if (cbbGenero.Text.Equals("Masculino"))
            {
                G = "M";
            }
            else
            {
                G = "F";
            }

            return G;
        }

        private bool Validar()
        {
            bool Valido = true;

            Not.Clear();
            Not2.Clear();
            Not3.Clear();
            if (txbNombres.TextLength == 0)
            {
                Not2.SetError(txbNombres, "Escriba los nombres");
                Valido = false;
            }

            if(txbApellidos.TextLength == 0)
            {
                Not3.SetError(txbApellidos,"Escriba los apellidos");
                Valido = false;
            }

            if (cbbGenero.Text.Length == 0)
            {
                Not.SetError(cbbGenero, "Seleccione un genero");
                Valido = false;
            }


            return Valido;
        }

        private void Procesar()
        {

            try
            {
                CLS.Empleados Emp = new CLS.Empleados();
                Emp.Nombres = txbNombres.Text;
                Emp.Apellidos = txbApellidos.Text;
                Emp.Genero = ObtenerGenero();

                if (Validar()) {

                    if (txbID.TextLength > 0)
                    {
                        //Edicion
                        Emp.IDEmpleado = txbID.Text;

                        if (Emp.Actualizar())
                        {
                            MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        //Agregar
                        if (Emp.Agregar())
                        {
                            MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("El registro no fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }


            }
            catch (Exception)
            {

            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void txbNombres_TextChanged(object sender, EventArgs e)
        {
            Not2.Clear();
            if (txbNombres.TextLength == 0)
            {
                Not2.SetError(txbNombres, "Escriba los nombres");
            }
        }

        private void txbApellidos_TextChanged(object sender, EventArgs e)
        {
            Not3.Clear();
            if (txbApellidos.TextLength == 0)
            {
                Not3.SetError(txbApellidos, "Escriba los apellidos");
            }
        }

        private void cbbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            Not.Clear();
        }

        private void EmpleadosEdicion_Enter(object sender, EventArgs e)
        {
        }

        private void EmpleadosEdicion_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void cbbGenero_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Procesar();
            }
        }

        private void txbNombres_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Procesar();
            }
        }

        private void txbApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Procesar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

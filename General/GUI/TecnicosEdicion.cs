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
    public partial class TecnicosEdicion : Form
    {
        public TecnicosEdicion()
        {
            InitializeComponent();
        }
        
        private String ObtenerGenero()
        {
            String G = "";

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
            Not4.Clear();
            Not5.Clear();
            Not6.Clear();
            Not7.Clear();

            if (txbNombres.TextLength == 0)
            {
                Not.SetError(txbNombres, "Escriba los nombres");
                Valido = false;
            }

            if (txbApellidos.TextLength == 0)
            {
                Not2.SetError(txbApellidos, "Escriba los apellidos");
                Valido = false;
            }

            if (txbDUI.TextLength == 0)
            {
                Not3.SetError(txbDUI, "Este campo no puede quedar vacio");
                Valido = false;
            }

            if (txbDUI.TextLength < 9)
            {
                Not3.SetError(txbDUI, "Escriba un numero de DUI valido");
                Valido = false;
            }

            if (txbNIT.TextLength == 0)
            {
                Not4.SetError(txbNIT, "Este campo no puede quedar vacio");
                Valido = false;
            }

            if (txbNIT.TextLength < 14)
            {
                Not4.SetError(txbNIT, "Escriba un numero de NIT valido");
                Valido = false;
            }

            if (txbTelefono.TextLength == 0)
            {
                Not5.SetError(txbTelefono, "Este campo no puede quedar vacio");
                Valido = false;
            }
            
            if (txbTelefono.TextLength < 8)
            {
                Not5.SetError(txbTelefono, "Escriba un numero de telefono valido");
                Valido = false;
            }

            if (txbDireccion.TextLength == 0)
            {
                Not6.SetError(txbDireccion, "Escriba una direccion");
                Valido = false;
            }

            if (cbbGenero.Text.Length == 0)
            {
                Not7.SetError(cbbGenero, "Seleccione un genero");
                Valido = false;
            }


            return Valido;
        }

        private void Procesar()
        {

            try
            {
                CLS.Tecnicos Emp = new CLS.Tecnicos();
                Emp.Nombres = txbNombres.Text;
                Emp.Apellidos = txbApellidos.Text;
                Emp.DUI = txbDUI.Text;
                Emp.NIT = txbNIT.Text;
                Emp.Telefono = txbTelefono.Text;
                Emp.Direccion = txbDireccion.Text;
                Emp.Genero = ObtenerGenero();

                if (Validar())
                {

                    if (txbID.TextLength > 0)
                    {
                        //Edicion
                        Emp.IDTecnico = txbID.Text;

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
            Not.Clear();
            if (txbNombres.TextLength == 0)
            {
                Not.SetError(txbNombres, "Escriba los nombres");
            }
        }

        private void txbApellidos_TextChanged(object sender, EventArgs e)
        {
            Not2.Clear();
            if (txbApellidos.TextLength == 0)
            {
                Not2.SetError(txbApellidos, "Escriba los apellidos");
            }
        }

        private void txbDUI_TextChanged(object sender, EventArgs e)
        {
            Not3.Clear();

            if (txbDUI.TextLength == 0)
            {
                Not3.SetError(txbDUI, "Este campo no puede quedar vacio");
            }

            if (txbDUI.TextLength < 9)
            {
                Not3.SetError(txbDUI, "Escriba un numero de DUI valido");
            }
        }

        private void TecnicosEdicion_Load(object sender, EventArgs e)
        {
        }

        private void txbNIT_TextChanged(object sender, EventArgs e)
        {
            Not4.Clear();

            if (txbNIT.TextLength == 0)
            {
                Not4.SetError(txbNIT, "Este campo no puede quedar vacio");
            }

            if (txbNIT.TextLength < 14)
            {
                Not4.SetError(txbNIT, "Escriba un numero de NIT valido");
            }
        }

        private void txbTelefono_TextChanged(object sender, EventArgs e)
        {
            Not5.Clear();

            if (txbTelefono.TextLength == 0)
            {
                Not5.SetError(txbTelefono, "Este campo no puede quedar vacio");
            }

            if (txbTelefono.TextLength < 8)
            {
                Not5.SetError(txbTelefono, "Escriba un numero de telefono valido");
            }
        }

        private void cbbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            Not7.Clear();
        }

        private void txbDireccion_TextChanged(object sender, EventArgs e)
        {
            Not6.Clear();
            if (txbDireccion.TextLength == 0)
            {
                Not6.SetError(txbDireccion, "Escriba una direccion");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Procesar();
            }

        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

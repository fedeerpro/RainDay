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
    public partial class RolesEdicion : Form
    {
        public RolesEdicion()
        {
            InitializeComponent();
        }

        private bool Validar()
        {
            bool Valido = true;

            Not.Clear();
            
            if (txbRol.TextLength == 0)
            {
                Not.SetError(txbRol, "Este campo no puede quedar vacio");
                Valido = false;
            }
            return Valido;
        }

        private void Procesar()
        {
            try
            {
                CLS.Roles rol = new CLS.Roles();
                rol.Rol = txbRol.Text;

                if (Validar())
                {
                    if (txbID.TextLength > 0)
                    {
                        //Editar
                         rol.IDRol = txbID.Text;
                        if (rol.Actualizar())
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
                        if (rol.Agregar())
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
               
                throw;
            }
            
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }
    }
}

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
    public partial class CambiarContraseña : Form
    {

        String _VerUsuarios;

        public string VerUsuarios
        {
            get
            {
                return _VerUsuarios;
            }

            set
            {
                _VerUsuarios = value;
            }
        }
        
        private String ValidarClaves()
        {
            String Valido = "No Valido";

            if (txbClave.Text == txbRepiteClave.Text)
            {
                Valido = "Valido";
            }
            else
            {
                Valido = "No Valido";
            }

            if (txbClave.TextLength == 0 || txbRepiteClave.TextLength == 0)
            {
                Valido = "Vacio";
            }


            return Valido;
        }

        private void Procesar() {

            try
            {
                if (ValidarClaves().Equals("Valido"))
                {
                    CLS.Usuarios oUsuario = new CLS.Usuarios();

                    oUsuario.IDUsuario = lblIDUsuario.Text;
                    oUsuario.Clave = txbClave.Text;
                    
                    switch (this._VerUsuarios)
                    {
                        case "Empleado":
                            {
                                if (oUsuario.CambiarContraseña())
                                {
                                    MessageBox.Show("La contraseña fue actualizada", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo cambiar la contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            break;

                        case "Cliente":
                            {
                                if (oUsuario.CambiarContraseña_Usuario_Cliente())
                                {
                                    MessageBox.Show("La contraseña fue actualizada", "Confirmación - Usuario Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo cambiar la contraseña", "Aviso - Usuario Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            break;

                        case "Tecnico":
                            {
                                if (oUsuario.CambiarContraseña_Usuario_Tecnico())
                                {
                                    MessageBox.Show("La contraseña fue actualizada", "Confirmación - Usuario Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo cambiar la contraseña", "Aviso - Usuario Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            break;
                    }

                }

            }
            catch (Exception)
            {

            }
        }


        public CambiarContraseña()
        {
            InitializeComponent();
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void txbClave_TextChanged_1(object sender, EventArgs e)
        {
            Notificador.Clear();
            if (ValidarClaves().Equals("Vacio"))
            {

                lblCoincidencia.Text = "";
                if (txbClave.TextLength == 0)
                {
                    Notificador.SetError(txbClave, "Debe proporcionar una contraseña valida");
                }
            }
            else if (ValidarClaves().Equals("Valido"))
            {

                lblCoincidencia.ForeColor = Color.Green;
                lblCoincidencia.TextAlign = ContentAlignment.TopCenter;
                lblCoincidencia.Text = "Contraseñas coinciden";

            }
            else
            {
                Notificador.SetError(txbRepiteClave, "Las contraseñas no coinciden");
            }
        }

        private void txbRepiteClave_TextChanged(object sender, EventArgs e)
        {
            Not2.Clear();
            if (ValidarClaves().Equals("Vacio"))
            {

                lblCoincidencia.Text = "";

                if (txbRepiteClave.TextLength == 0)
                {
                    Not2.SetError(txbRepiteClave, "Este campo no puede quedar vacio");
                }
            }
            else if (ValidarClaves().Equals("Valido"))
            {

                lblCoincidencia.ForeColor = Color.Green;
                lblCoincidencia.TextAlign = ContentAlignment.TopCenter;
                lblCoincidencia.Text = "Contraseñas coinciden";

            }
            else
            {
                Not2.SetError(txbRepiteClave, "Las contraseñas no coinciden");
            }
        }

        private void chbMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            txbClave.UseSystemPasswordChar = chbMostrarPass.Checked;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de actualizar la contraseña?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Procesar();
            }    
        }

        
    }
}

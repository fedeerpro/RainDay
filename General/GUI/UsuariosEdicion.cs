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
    public partial class UsuariosEdicion : Form
    {

        String _Usuario;
        String _VerUsuarios;

        public string Usuario
        {
            get
            {
                return _Usuario;
            }

            set
            {
                _Usuario = value;
            }
        }

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

        private void LlenarRoles()
        {
            try
            {
                cbbRol.DataSource = DataSource.Consultas.TODOS_LOS_ROLES();
                cbbRol.DisplayMember = "Rol";
                cbbRol.ValueMember = "IDRol";
            }
            catch (Exception)
            {

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
        
        private String ValidarOpcEmpleado()
        {
            String res= "NADA";

            try
            {
                CLS.Usuarios oUsuario = new CLS.Usuarios();
                oUsuario.Usuario = txbUsuario.Text;
                oUsuario.IDEmpleado = txbIDEmpleado.Text;

                switch (this._VerUsuarios)
                {
                    case "Empleado":
                        {
                            if (oUsuario.UsuarioPorID())
                            {
                                res = "Empleado VALIDO";
                            }
                            else{
                                res = "Empleado NO VALIDO";
                            }
                        }
                        break;
                    case "Cliente":
                        {
                            if (oUsuario.Usuario_ClientePorID())
                            {
                                res = "Cliente VALIDO";
                            }
                            else
                            {
                                res = "Cliente NO VALIDO";
                            }
                        }
                        break;

                    case "Tecnico":
                        {
                            if (oUsuario.Usuario_TecnicoPorID())
                            {
                                res = "Tecnico VALIDO";
                            }
                            else
                            {
                                res = "Tecnico NO VALIDO";
                            }
                        }
                        break;
                }


            }
            catch (Exception)
            {
            }
            

            return res;
        }

        private bool Validar_OPC_Usuario()
        {
            bool res = false;
            int contValidos = 0;

            CLS.Usuarios oUsuario = new CLS.Usuarios();
            oUsuario.Usuario = txbUsuario.Text;

            if (oUsuario.ValidarNombredeUsuario())
            {
                contValidos++;
            }

            if (oUsuario.ValidarNombredeUsuario_Cliente())
            {
                contValidos++;
            }

            if (oUsuario.ValidarNombredeUsuario_Tecnico())
            {
                contValidos++;
            }

            if (contValidos == 3)
            {
                res = true;
            }


            return res;
        }
        
        private Boolean Validar()
        {
            Boolean Validado = true;
            try
            {
                Notificador.Clear();
                Not2.Clear();
                Not4.Clear();
                Not5.Clear();

                if (txbUsuario.TextLength == 0)
                {
                    Validado = false;
                    Not2.SetError(txbUsuario, "Escriba el nombre de usuario");
                }
                if (txbClave.TextLength == 0)
                {
                    Not5.SetError(txbClave, "Debe proporcionar una contraseña valida");
                    Validado = false;
                }
                if (ValidarClaves().Equals("No Valido"))
                {
                    Not4.SetError(txbRepiteClave, "Las contraseñas no coinciden");
                    Validado = false;
                }
                if (txbRepiteClave.TextLength < 1)
                {
                    Notificador.SetError(txbRepiteClave, "Este campo no puede quedar vacio");
                    Validado = false;

                }
                if (txbIDEmpleado.TextLength == 0)
                {
                    Not4.SetError(txbIDEmpleado,"Seleccione un empleado");
                    Validado = false;
                }
                if (cbbRol.Text.Length == 0)
                {
                    Not4.SetError(cbbRol, "Seleccione una opcion valida");
                    Validado = false;
                }

                if (!Validar_OPC_Usuario())
                {
                    Not2.SetError(txbUsuario, "Este usuario ya esta en uso");
                    Validado = false;
                }

                if (ValidarOpcEmpleado().Equals("Empleado NO VALIDO") || ValidarOpcEmpleado().Equals("Cliente NO VALIDO") || 
                    ValidarOpcEmpleado().Equals("Tecnico NO VALIDO"))
                {
                    Validado = false;
                }


            }
            catch (Exception)
            {
                Validado = false;
            }


            return Validado;
        }

        private Boolean ValidarEdicion()
        {
            Boolean Validado = true;

            Not2.Clear();

            try
            {
                if (txbUsuario.TextLength == 0)
                {
                    Not2.SetError(txbUsuario, "Escriba el nombre del usuario");
                    Validado = false;
                }
                if (cbbRol.Text.Length == 0)
                { 
                    Validado = false;
                }

                if (txbUsuario.Text.Equals(this._Usuario))
                {
                    Validado = true;
                }
                else if(!Validar_OPC_Usuario())
                {
                    Not2.SetError(txbUsuario, "Este usuario ya esta en uso");
                    Validado = false;
                }
                
            }
            catch (Exception)
            {
                Validado = false;
            }


            return Validado;
        }

        private void Cambiarlbl()
        {
            
            switch (this._VerUsuarios)
            {
                case "Empleado":
                    {
                        lblOpcEmp.Text = "Empleado";
                    }
                    break;
                case "Cliente":
                    {
                        lblOpcEmp.Text = "Cliente";

                    }
                    break;

                case "Tecnico":
                    {
                        lblOpcEmp.Text = "Tecnico";

                    }
                    break;
            }

        }
        
        private void Procesar()
        {
            try
            {
                    CLS.Usuarios oUsuario = new CLS.Usuarios();
                    
                    oUsuario.IDUsuario = txbIDUsuario.Text;
                    oUsuario.Usuario = txbUsuario.Text;
                    oUsuario.IDEmpleado = txbIDEmpleado.Text;
                    oUsuario.IDRol = cbbRol.SelectedValue.ToString();
                    oUsuario.Clave = txbClave.Text;

                
                    if (txbIDUsuario.TextLength > 0)
                    {
                        if (ValidarEdicion())
                        {

                            switch (this._VerUsuarios)
                            {
                                case "Empleado":
                                    {
                                        if (oUsuario.Actualizar())
                                        {
                                            MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    break;

                                case "Cliente":
                                    {
                                        if (oUsuario.Usuarios_Cliente_Actualizar())
                                        {
                                            MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    break;

                                case "Tecnico":
                                    {
                                        if (oUsuario.Usuarios_Tecnico_Actualizar())
                                        {
                                            MessageBox.Show("El registro fue actualizado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El registro no fue actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                    }
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proporcione datos correctos porfavor","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (Validar())
                        {

                            switch (this._VerUsuarios)
                            {
                                case "Empleado":
                                    {
                                        if (oUsuario.Guardar())
                                        {
                                            MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El registro no fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    break;

                                case "Cliente":
                                    {
                                        if (oUsuario.Usuarios_Cliente_Guardar())
                                        {
                                            MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El registro no fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    break;

                                case "Tecnico":
                                    {
                                        if (oUsuario.Usuarios_Tecnico_Guardar())
                                        {
                                            MessageBox.Show("El registro fue agregado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("El registro no fue agregado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                    }
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Proporcione datos correctos porfavor", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                

            }
            catch (Exception)
            {
                MessageBox.Show("Error al procesar el comando", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public UsuariosEdicion()
        {
            InitializeComponent();
            LlenarRoles();
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Procesar();
        }

        private void txbRepiteClave_TextChanged_1(object sender, EventArgs e)
        {
            Not4.Clear();
            Notificador.Clear();
            if (ValidarClaves().Equals("Vacio"))
            {

                lblCoincidencia.Text = "";

                if (txbRepiteClave.TextLength == 0)
                {
                    Notificador.SetError(txbRepiteClave, "Este campo no puede quedar vacio");
                }
            }
            else if (ValidarClaves().Equals("Valido"))
            {

                lblCoincidencia.ForeColor = Color.Green;
                lblCoincidencia.Text = "Contraseñas coinciden";

            }
            else
            {
                Notificador.SetError(txbRepiteClave, "Las contraseñas no coinciden");
            }
            
        }
        
        private void UsuariosEdicion_Load(object sender, EventArgs e)
        {
            if (txbIDUsuario.TextLength > 0) {

                btnBuscarEmpleado.Enabled = false;
                lblClave.Visible = false;
                txbClave.Visible = false;
                lblRepClave.Visible = false;
                txbRepiteClave.Visible = false;
                chbMostrarPass.Visible = false;
                
            }

            Cambiarlbl();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {

                Int32 w = 613, h = 412;

                switch (this._VerUsuarios)
                {
                    case "Empleado":
                        {
                            GUI.EmpleadosGestion f = new EmpleadosGestion();
                            f.SELECCION = true;
                            f.FormBorderStyle = FormBorderStyle.FixedSingle;
                            f.Width = w;
                            f.Height = h;
                            f.ShowDialog();
                            if (f.Seleccionado)
                            {
                                txbIDEmpleado.Text = f.IDEmpleadoSeleccionado;
                                txbEmpleado.Text = f.EmpleadoSeleccionado;
                            }
                        }
                        break;
                    case "Cliente":
                        {
                            GUI.ClientesGestion V = new ClientesGestion();
                            V.SELECCION = true;
                            V.FormBorderStyle = FormBorderStyle.FixedSingle;
                            V.Width = w;
                            V.Height = h;
                            V.ShowDialog();
                            if (V.Seleccionado)
                            {
                                txbIDEmpleado.Text = V.IDClienteSeleccionado;
                                txbEmpleado.Text = V.ClienteSeleccionado;
                            }

                        }
                        break;

                    case "Tecnico":
                        {
                            GUI.TecnicosGestion NV = new TecnicosGestion();
                            NV.SELECCION = true;
                            NV.FormBorderStyle = FormBorderStyle.FixedSingle;
                            NV.Width = w;
                            NV.Height = h;
                            NV.ShowDialog();
                            if (NV.Seleccionado)
                            {
                                txbIDEmpleado.Text = NV.IDTecnicoSeleccionado;
                                txbEmpleado.Text = NV.TecnicoSeleccionado;
                            }
                        }
                        break;
                }





            }
            catch (Exception)
            {


            }
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            Not2.Clear();

            if (txbIDUsuario.TextLength > 0)
            {

                if (txbUsuario.Text != this._Usuario)
                {
                    if (!Validar_OPC_Usuario()) {

                        Not2.SetError(txbUsuario, "Este usuario ya esta en uso");
                    }
                }

                if (txbUsuario.TextLength == 0) {
                    Not2.SetError(txbUsuario, "Escriba el nombre de usuario");
                }

            }
            else {
                
                if (!Validar_OPC_Usuario())
                {
                    Not2.SetError(txbUsuario, "Este usuario ya esta en uso");

                }

                if (txbUsuario.TextLength == 0)
                {
                    Not2.SetError(txbUsuario, "Escriba el nombre del usuario");

                }
            }
        }

        private void txbEmpleado_TextChanged(object sender, EventArgs e)
        {
            Not3.Clear();
            Not4.Clear();
            if (txbIDUsuario.TextLength == 0) {

                String aver = ValidarOpcEmpleado();

                switch (ValidarOpcEmpleado())
                {
                    case "Empleado NO VALIDO":
                        {
                            Not3.SetError(txbEmpleado, "Este empleado ya es usuario");

                        }
                        break;
                    case "Cliente NO VALIDO":
                        {
                            Not3.SetError(txbEmpleado, "Este cliente ya es usuario");

                        }
                        break;

                    case "Tecnico NO VALIDO":
                        {
                            Not3.SetError(txbEmpleado, "Este Tecnico ya es usuario");

                        }
                        break;
                }
            }   
            
        }

        private void txbIDEmpleado_TextChanged(object sender, EventArgs e)
        {
            if (txbIDEmpleado.TextLength > 0) {
                Not4.Clear();
            }
        }
        
        private void chbMostrarPass_CheckedChanged_1(object sender, EventArgs e)
        {

            txbClave.UseSystemPasswordChar = chbMostrarPass.Checked;
            

        }

        private void txbClave_TextChanged_1(object sender, EventArgs e)
        {
            Not4.Clear();
            Not5.Clear();
            if (ValidarClaves().Equals("Vacio"))
            {

                lblCoincidencia.Text = "";
                if (txbClave.TextLength == 0)
                {
                    Not5.SetError(txbClave, "Debe proporcionar una contraseña valida");
                }
            }
            else if (ValidarClaves().Equals("Valido"))
            {

                lblCoincidencia.ForeColor = Color.Green;
                lblCoincidencia.Text = "Contraseñas coinciden";

            }
            else
            {
                Not5.SetError(txbRepiteClave, "Las contraseñas no coinciden");
            }
        }
    }
}
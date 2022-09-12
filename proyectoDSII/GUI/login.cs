using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controles;
using System.IO;

namespace proyectoDSII.GUI
{
    public partial class login : Form
    {
        Boolean _Autorizado = false;
        SessionManager.Sesion oSesion = SessionManager.Sesion.Instance;
        String a = "";

        DataTable _DATOS = new DataTable();

        private void InicializarTabla()
        {
            _DATOS.TableName = "DatosConexion";
            _DATOS.Columns.Add("Usuario");
            _DATOS.Columns.Add("Clave");
            _DATOS.Columns.Add("Puerto");
            _DATOS.Columns.Add("BaseDeDatos");
            _DATOS.Columns.Add("Servidor");

        }

        private void CargarDatos()
        {
            try
            {
                _DATOS.ReadXml("DatosDeConexion.xml");
            }
            catch (Exception)
            {

            }
        }

        private bool Guardar()
        {
            bool Res = false;

            try
            {
                _DATOS.WriteXml("DatosDeConexion.xml");
                Res = true;
            }
            catch (Exception)
            {
                Res = false;
            }

            return Res;
        }

        public bool Autorizado
        {
            get
            {
                return _Autorizado;
            }

            set
            {
                _Autorizado = value;
            }
        }

        private bool UsuarioExistente()
        {
            bool Existente = false;

            DataTable Usuario = new DataTable();
            DataTable UsuarioCliente = new DataTable();
            DataTable UsuarioTecnico = new DataTable();

            try
            {
                Usuario = DataSource.Consultas.BuscarUsuario(txbUsuario.Text);
                UsuarioCliente = DataSource.Consultas.BuscarUsuarioCliente(txbUsuario.Text);
                UsuarioTecnico = DataSource.Consultas.BuscarUsuarioTecnico(txbUsuario.Text);

                if (Usuario.Rows.Count > 0)
                {
                    Existente = true;
                }
                else if (UsuarioCliente.Rows.Count > 0)
                {
                    Existente = true;
                }
                else if (UsuarioTecnico.Rows.Count > 0)
                {
                    Existente = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return Existente;
        }
        
        private void Validar()
        {
            DataTable Datos = new DataTable();
            DataTable Datos_Cliente = new DataTable();
            DataTable Datos_Tecnico = new DataTable();
            try
            {
                Datos = DataSource.Consultas.INICIO_SESION(txbUsuario.Text, txbClave.Text);
                Datos_Cliente = DataSource.Consultas.IniciarSesionCliente(txbUsuario.Text, txbClave.Text);
                Datos_Tecnico = DataSource.Consultas.IniciarSesionTecnico(txbUsuario.Text, txbClave.Text);

                if (Datos_Cliente.Rows.Count == 1)
                {
                    oSesion.IDUsuario = Datos_Cliente.Rows[0]["IDUsuario"].ToString();
                    oSesion.Usuario = Datos_Cliente.Rows[0]["Usuario"].ToString();
                    oSesion.IDRol = Datos_Cliente.Rows[0]["IDRol"].ToString();
                    oSesion.Rol = Datos_Cliente.Rows[0]["Rol"].ToString();
                    oSesion.IDEmpleado = Datos_Cliente.Rows[0]["IDEmpleado"].ToString();
                    oSesion.OpcEmpleado = "Cliente";
                    oSesion.ObtenerPermisos();
                    Autorizado = true;
                    Close();
                }

                else if (Datos.Rows.Count == 1)
                {

                    oSesion.IDUsuario = Datos.Rows[0]["IDUsuario"].ToString();
                    oSesion.Usuario = Datos.Rows[0]["Usuario"].ToString();
                    oSesion.IDRol = Datos.Rows[0]["IDRol"].ToString();
                    oSesion.Rol = Datos.Rows[0]["Rol"].ToString();
                    oSesion.IDEmpleado = Datos.Rows[0]["IDEmpleado"].ToString();
                    oSesion.OpcEmpleado = "Empleado";
                    oSesion.ObtenerPermisos();
                    Autorizado = true;
                    Close();

                }
                else if (Datos_Tecnico.Rows.Count == 1)
                {
                    oSesion.IDUsuario = Datos_Tecnico.Rows[0]["IDUsuario"].ToString();
                    oSesion.Usuario = Datos_Tecnico.Rows[0]["Usuario"].ToString();
                    oSesion.IDRol = Datos_Tecnico.Rows[0]["IDRol"].ToString();
                    oSesion.Rol = Datos_Tecnico.Rows[0]["Rol"].ToString();
                    oSesion.IDEmpleado = Datos_Tecnico.Rows[0]["IDEmpleado"].ToString();
                    oSesion.OpcEmpleado = "Tecnico";
                    oSesion.ObtenerPermisos();
                    Autorizado = true;
                    Close();
                }
                else
                {
                    lblAnuncio.ForeColor = Color.Firebrick;
                    lblAnuncio.Text = "Usuario o Contraseña incorrectos";
                    Anuncio.Start();

                }

                if (Autorizado == true)
                {
                    CLS.Logs log = new CLS.Logs();
                    log.User = txbUsuario.Text;
                    log.Detalle = "El usuario " + txbUsuario.Text + " inicio sesion";
                    log.Agregar();
                }
                else if(UsuarioExistente())
                {
                    CLS.Logs log = new CLS.Logs();
                    log.User = txbUsuario.Text;
                    log.Detalle = "El usuario " + txbUsuario.Text + " intento iniciar sesion";
                    log.Agregar();

                }
            }
            catch (Exception)
            {

            }

        }

        public login()
        {
            InitializeComponent();
            InicializarTabla();
            CargarDatos();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txbUsuario.TextLength < 1 || txbClave.TextLength < 1)
            {

                MessageBox.Show("Complete campo(s) vacio(s)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                String path = Directory.GetCurrentDirectory() + "/DatosDeConexion.txt";
                if (File.Exists(path))
                {
                    Validar();
                }
                else {
                    MessageBox.Show
                    ("No existen datos de conexion a la base de datos, por favor proporcione los datos de conexion","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

            }

        }

        private void Anuncio_Tick(object sender, EventArgs e)
        {
            lblAnuncio.ForeColor = Color.RoyalBlue;
            lblAnuncio.Text = "Escriba sus credenciales correctamente";
            Anuncio.Stop();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chbMostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            String pass = txbClave.Text;
            txbClave.UseSystemPasswordChar = chbMostrarPass.Checked;
        }

        private void login_Load(object sender, EventArgs e)
        {
            txbUsuario.SelectedText = a;
        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            a = "Cambio";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DatosConexion f = new DatosConexion();
            f.ShowDialog();
        }
    }
}


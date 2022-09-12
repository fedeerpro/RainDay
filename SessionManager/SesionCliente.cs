using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionManager
{
    public sealed class SesionCliente
    {
        private static SesionCliente instance = null;
        private static readonly object padlock = new object();

        String _IDUsuario;
        String _Usuario;
        String _IDRol;
        String _Rol;
        DataTable _Permisos = new DataTable();

        public string IDUsuario
        {
            get
            {
                return _IDUsuario;
            }

            set
            {
                _IDUsuario = value;
            }
        }

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

        public string IDRol
        {
            get
            {
                return _IDRol;
            }

            set
            {
                _IDRol = value;
            }
        }

        public string Rol
        {
            get
            {
                return _Rol;
            }

            set
            {
                _Rol = value;
            }
        }

        public DataTable Permisos
        {
            get
            {
                return _Permisos;
            }

            set
            {
                _Permisos = value;
            }
        }

        public static SesionCliente Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SesionCliente();
                        }
                    }
                }
                return instance;
            }
        }

        public void ObtenerPermisos()
        {

            try
            {
                _Permisos = DataSource.Consultas.PERMISOS(_IDRol);
            }
            catch (Exception)
            {

            }

        }

        public Boolean VerificarPermiso(Int32 pID)
        {
            Boolean verificado = false;
            Int32 IDVerificado = 0;
            foreach (DataRow Fila in _Permisos.Rows)
            {

                IDVerificado = Convert.ToInt32(Fila["IDOpcion"].ToString());
                if (IDVerificado == pID)
                {
                    verificado = true;
                    break;
                }

            }

            if (!verificado)
            {

                MessageBox.Show("Usted no cuenta con la autorizacion para realizar esta tarea", "Permiso " + pID.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            return verificado;
        }

        private SesionCliente()
        { }
    }
}

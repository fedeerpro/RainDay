using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Usuarios
    {
        String _IDUsuario;
        String _Usuario;
        String _Clave;
        String _IDEmpleado;
        String _IDRol;

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
        public string Clave
        {
            get
            {
                return _Clave;
            }

            set
            {
                _Clave = value;
            }
        }
        public string IDEmpleado
        {
            get
            {
                return _IDEmpleado;
            }

            set
            {
                _IDEmpleado = value;
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

        public Boolean Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO usuarios(Usuario, Clave, IDEmpleado, IDRol) values(");
                Sentencia.Append("'" + this._Usuario + "',");
                Sentencia.Append("MD5(SHA1('" + this._Clave + "')),");
                Sentencia.Append("'" + this._IDEmpleado + "',");
                Sentencia.Append("'" + this._IDRol + "');");

                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public bool UsuarioPorID()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from Usuarios where IDEmpleado = "+this._IDEmpleado+";");

                TablaRes = operacion.Consultar(Sentencia.ToString());

                if (TablaRes.Rows.Count == 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        
        public bool Usuario_ClientePorID()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from Usuarios_Cliente where IDEmpleado = " + this._IDEmpleado + ";");

                TablaRes = operacion.Consultar(Sentencia.ToString());

                if (TablaRes.Rows.Count == 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        
        public bool Usuario_TecnicoPorID()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from Usuarios_Tecnico where IDEmpleado = " + this._IDEmpleado + ";");

                TablaRes = operacion.Consultar(Sentencia.ToString());

                if (TablaRes.Rows.Count == 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        
        public bool ValidarNombredeUsuario()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from Usuarios where Usuario = '" + this._Usuario +"';" );

                TablaRes = operacion.Consultar(Sentencia.ToString());

                if (TablaRes.Rows.Count == 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public bool ValidarNombredeUsuario_Cliente()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from Usuarios_Cliente where Usuario = '" + this._Usuario + "';");

                TablaRes = operacion.Consultar(Sentencia.ToString());

                if (TablaRes.Rows.Count == 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        
        public bool ValidarNombredeUsuario_Tecnico()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from Usuarios_Tecnico where Usuario = '" + this._Usuario + "';");

                TablaRes = operacion.Consultar(Sentencia.ToString());

                if (TablaRes.Rows.Count == 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        
        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE usuarios SET ");
                Sentencia.Append("Usuario='" + this._Usuario + "',");
                Sentencia.Append("IDEmpleado='" + this._IDEmpleado + "',");
                Sentencia.Append("IDRol='" + this._IDRol + "' ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean CambiarContraseña()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE usuarios SET ");
                Sentencia.Append("Clave= MD5(SHA1('" + this._Clave + "')) ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean CambiarContraseña_Usuario_Cliente()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE Usuarios_Cliente SET ");
                Sentencia.Append("Clave= MD5(SHA1('" + this._Clave + "')) ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean CambiarContraseña_Usuario_Tecnico()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE Usuarios_Tecnico SET ");
                Sentencia.Append("Clave= MD5(SHA1('" + this._Clave + "')) ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        
        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("DELETE FROM usuarios ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
        
        public Boolean Usuarios_Cliente_Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO Usuarios_cliente(Usuario, Clave, IDEmpleado, IdRol) values(");
                Sentencia.Append("'" + this._Usuario + "',");
                Sentencia.Append("MD5(SHA1('" + this._Clave + "')),");
                Sentencia.Append("'" + this._IDEmpleado + "',");
                Sentencia.Append("'" + this._IDRol + "');");

                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Usuarios_Cliente_Actualizar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE Usuarios_Cliente SET ");
                Sentencia.Append("Usuario='" + this._Usuario + "', ");
                Sentencia.Append("IdRol='" + this._IDRol + "' ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Usuarios_Cliente_Eliminar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("DELETE FROM Usuarios_Cliente ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Usuarios_Tecnico_Guardar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO Usuarios_Tecnico(Usuario, Clave, IDEmpleado, IdRol) values(");
                Sentencia.Append("'" + this._Usuario + "',");
                Sentencia.Append("MD5(SHA1('" + this._Clave + "')),");
                Sentencia.Append("'" + this._IDEmpleado + "',");
                Sentencia.Append("'" + this._IDRol + "');");

                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Usuarios_Tecnico_Actualizar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE Usuarios_Tecnico SET ");
                Sentencia.Append("Usuario='" + this._Usuario + "',");
                Sentencia.Append("IdRol='" + this._IDRol + "' ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }

        public Boolean Usuarios_Tecnico_Eliminar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("DELETE FROM Usuarios_Tecnico ");
                Sentencia.Append("WHERE IDUsuario=" + this._IDUsuario + ";");
                if (operacion.Insertar(Sentencia.ToString()) > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }


    }
}

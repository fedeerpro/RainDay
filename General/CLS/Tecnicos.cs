using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Tecnicos
    {
        String _IDTecnico;
        String _Nombres;
        String _Apellidos;
        String _DUI;
        String _NIT;
        String _Telefono;
        String _Direccion;
        String _Genero;

        public string IDTecnico
        {
            get
            {
                return _IDTecnico;
            }

            set
            {
                _IDTecnico = value;
            }
        }

        public string Nombres
        {
            get
            {
                return _Nombres;
            }

            set
            {
                _Nombres = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return _Apellidos;
            }

            set
            {
                _Apellidos = value;
            }
        }

        public string DUI
        {
            get
            {
                return _DUI;
            }

            set
            {
                _DUI = value;
            }
        }

        public string NIT
        {
            get
            {
                return _NIT;
            }

            set
            {
                _NIT = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _Telefono;
            }

            set
            {
                _Telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }

            set
            {
                _Direccion = value;
            }
        }

        public string Genero
        {
            get
            {
                return _Genero;
            }

            set
            {
                _Genero = value;
            }
        }

        public Boolean Agregar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO Tecnicos(Nombres, Apellidos,DUI,NIT,Telefono, Direccion, Genero) values(");
                Sentencia.Append("'" + this._Nombres + "', ");
                Sentencia.Append("'" + this._Apellidos + "', ");
                Sentencia.Append("'" + this._DUI + "', ");
                Sentencia.Append("'" + this._NIT + "', ");
                Sentencia.Append("'" + this._Telefono + "', ");
                Sentencia.Append("'" + this.Direccion + "', ");
                Sentencia.Append("'" + this.Genero + "');");

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

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("UPDATE Tecnicos SET ");
                Sentencia.Append("Nombres ='" + this._Nombres + "', ");
                Sentencia.Append("Apellidos = '" + this.Apellidos + "', ");
                Sentencia.Append("DUI = '" + this._DUI + "', ");
                Sentencia.Append("NIT = '" + this._NIT + "', ");
                Sentencia.Append("Telefono = '" + this._Telefono + "', ");
                Sentencia.Append("Direccion = '" + this._Direccion + "', ");
                Sentencia.Append("Genero = '" + this._Genero + "' ");
                Sentencia.Append("WHERE IDTecnico = " + this._IDTecnico + ";");
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
                Sentencia.Append("DELETE FROM Tecnicos ");
                Sentencia.Append("WHERE IDTecnico = " + this._IDTecnico + ";");
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

        public bool BuscarTecnico_EnUsuariosTecnico()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from Usuarios_Tecnico where IDEmpleado = '" + this._IDTecnico + "';");

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

    }
}

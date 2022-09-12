using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Equipos
    {
        String _IDEquipo;
        String _Equipo;
        String _Detalles;

        public string IDEquipo
        {
            get
            {
                return _IDEquipo;
            }

            set
            {
                _IDEquipo = value;
            }
        }

        public string Equipo
        {
            get
            {
                return _Equipo;
            }

            set
            {
                _Equipo = value;
            }
        }

        public string Detalles
        {
            get
            {
                return _Detalles;
            }

            set
            {
                _Detalles = value;
            }
        }

        public Boolean Agregar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO Equipos(Equipo, Detalles) values(");
                Sentencia.Append("'" + this._Equipo + "', ");
                Sentencia.Append("'" + this._Detalles + "');");

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
                Sentencia.Append("UPDATE Equipos SET ");
                Sentencia.Append("Detalles = '" + this._Detalles + "' ");
                Sentencia.Append("WHERE IDEquipo =" + this._IDEquipo + ";");
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
                Sentencia.Append("DELETE FROM Equipos ");
                Sentencia.Append("WHERE IDEquipo= " + this._IDEquipo + ";");
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

        public bool BuscarEquipo_EnIncidencias()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from Incidencias where IDEquipo = '" + this._IDEquipo + "';");

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

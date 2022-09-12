using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controles.CLS
{
    class Opciones
    {
        String _IDOpcion;
        String _Opcion;

        public string IDOpcion
        {
            get
            {
                return _IDOpcion;
            }

            set
            {
                _IDOpcion = value;
            }
        }

        public string Opcion
        {
            get
            {
                return _Opcion;
            }

            set
            {
                _Opcion = value;
            }
        }

        public Boolean Agregar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("insert into opciones(opcion)values(");
                Sentencia.Append("'"+ this._Opcion +"');");

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
                Sentencia.Append("update opciones set opcion = '"+this._Opcion+"' where idopcion = "+this._IDOpcion+";");
               
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
                Sentencia.Append("DELETE FROM Opciones WHERE IdOpcion = " + this._IDOpcion+ ";");
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
        public bool BuscarOpcion()
        {
            bool Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            DataTable TablaRes = new DataTable();
            try
            {

                Sentencia.Append("Select *from opciones where IDOpcion= '" + this._IDOpcion + "';");

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

using System;
using System.Text;
namespace proyectoDSII.CLS
{
    class Logs
    {
        String _user;
        String _detalle;
        String Fecha;
        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public string Detalle
        {
            get
            {
                return _detalle;
            }

            set
            {
                _detalle = value;
            }
        }

        public string Fecha1
        {
            get
            {
                return Fecha;
            }

            set
            {
                Fecha = value;
            }
        }

        public Boolean Agregar()
        {
            Boolean Resultado = false;
            StringBuilder Sentencia = new StringBuilder();
            DataManager.DBOperacion operacion = new DataManager.DBOperacion();
            try
            {
                Sentencia.Append("INSERT INTO logs_1(usuario, detalle, fecha) values('");
                Sentencia.Append(this._user + "', '");
                Sentencia.Append(this._detalle+ "', ");
                Sentencia.Append("now()); ");
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
